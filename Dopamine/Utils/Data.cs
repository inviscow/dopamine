using DotNetConfig;

namespace Dopamine.Utils
{
    internal class Data
    {
        internal static Task? ConfigSetupTask { get; set; }
        internal static string ConfigPath = "";
        internal static string ConfigDirectory = "";

        #region General Functions
        internal static string RandomString(int length = 16, bool alphabet = true, bool numbers = false)
        {
            string chars = "";
            if (alphabet)
                chars += "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            if (numbers)
                chars += "0123456789";
            var random = new Random();
            var randomString = new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
            return randomString;
        }

        internal static int RandomInt(int min, int max)
        {
            Random rnd = new Random();
            return rnd.Next(min, max);
        }

        internal static async Task DownloadFile(string url, string path)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead);
                using (Stream stream = await response.Content.ReadAsStreamAsync())
                using (FileStream fileStream = new FileStream(path, FileMode.Create))
                {
                    await stream.CopyToAsync(fileStream);
                }
            }
        }

        internal static bool CompareVersions(string version1, string version2)
        {
            var parts1 = version1.Split('.');
            var parts2 = version2.Split('.');

            int minLen = Math.Min(parts1.Length, parts2.Length);
            for (int i = 0; i < minLen; i++)
            {
                if (int.Parse(parts1[i]) > int.Parse(parts2[i]))
                    return true;
                else if (int.Parse(parts1[i]) < int.Parse(parts2[i]))
                    return false;
            }

            if (parts1.Length != parts2.Length)
                return parts1.Length > parts2.Length;

            // versions are equal
            return false;
        }
        #endregion


        #region Config
        internal static Config GetConfig()
        {
            /*
         config.GetString("section", "subsection", "variable");
         config.SetString("section", "subsection", "variable", value);
        */

            if (!string.IsNullOrEmpty(ConfigPath))
                return Config.Build(ConfigPath);
            else
                throw new Exception("Config path is not yet built");
        }

        internal static void StartConfigSetup()
        {
            // Fire-and-forget, but keep the Task for later status checks.
            ConfigSetupTask = SetupConfigFile();
        }

        internal static async Task SetupConfigFile()
        {
            string primaryDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FadedSolutions", "Dopamine");
            string fallbackDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Dopamine");

            string chosenDir = primaryDir;
            try
            {
                Directory.CreateDirectory(primaryDir);
            }
            catch
            {
                chosenDir = fallbackDir;
                Directory.CreateDirectory(fallbackDir);
            }

            ConfigDirectory = chosenDir;
            string cfgPath = Path.Combine(chosenDir, "config.json");
            if (!File.Exists(cfgPath))
                File.Create(cfgPath).Close();

            ConfigPath = cfgPath;
            GetConfig().SetNumber("Minecraft", "Process", "Pointers", 0);
        }
        #endregion
    }
}
