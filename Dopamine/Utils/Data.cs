using DotNetConfig;
using System.Text.Json;

namespace Dopamine.Utils
{
    internal class Data
    {
        internal interface ClientConfigStruct
        {
            string PathToDataDirectory { get; }

            int LastKnownProcessID { get; set; }
        }

        internal static Task? ConfigSetupTask { get; set; }
        internal static string ConfigPath = "";
        internal static string ConfigDirectory = "";


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
            {
                var defaults = new
                {
                    SettinPathToDataDirectory = chosenDir,
                    LastKnownProcessID = 0
                };

                var json = JsonSerializer.Serialize(defaults, new JsonSerializerOptions { WriteIndented = true });
                await File.WriteAllTextAsync(cfgPath, json);
            }

            ConfigPath = cfgPath;
        }
    }
}
