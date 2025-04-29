using System.Diagnostics;
using System.Text.Json;

namespace Dopamine.Utils
{
    internal class Minecraft
    {
        internal readonly static string McpeDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Packages", "Microsoft.MinecraftUWP_8wekyb3d8bbwe", "LocalState", "games", "com.mojang", "minecraftpe"); // lol
        internal readonly static string OptionsFile = Path.Combine(McpeDirectory, "options.txt");
        private static int LastKnownProcessID = 0;

        private static async Task<string> GetValueFromFile(string fileName, int line = 0)
        {
            string filePath = Path.Combine(McpeDirectory, fileName);

            if (!File.Exists(filePath))
                return "N/A";

            using (var sr = new StreamReader(filePath))
            {
                string result;
                int count = 0;
                do
                {
                    result = await sr.ReadLineAsync();
                    count++;
                } while (result != null && count <= line);

                return result != null ? result : "N/A";
            }
        }

        internal static async Task<(bool success, string result)> GetDataFromOptionsFile(string key)
        {
            return await Task.Run(() =>
            {
                try
                {
                    string[] lines = File.ReadAllLines(OptionsFile);
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (lines[i].StartsWith(key))
                        {
                            string[] parts = lines[i].Split(':');
                            return (true, parts[1]);
                        }
                    }
                    return (false, $"Couldn't find key ({key})");
                }
                catch (Exception ex)
                {
                    return (false, $"An error has occured: \n{ex.Message}");
                }
            });
        }

        internal static async Task<string> GetDIDFromFile() => await GetValueFromFile("hs", 1);
        internal static async Task<string> GetCIDFromFile() => await GetValueFromFile("clientId.txt", 0);

        internal static int GetProcessID()
        {
            try
            {
                Process[] targetProcessIndex = Process.GetProcessesByName("Minecraft.Windows");
                if (targetProcessIndex.Length > 0)
                {
                    Process targetProcess = Process.GetProcessesByName("Minecraft.Windows")[0];
                    LastKnownProcessID = targetProcess.Id;
                    return targetProcess.Id;
                } else
                {
                    return 0;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }

        internal static string GetMCVersion()
        {
            string telemetryFile = Path.Combine(McpeDirectory, "telemetry_info.json");
            if (!File.Exists(telemetryFile))
                return "N/A";

            try
            {
                using var doc = JsonDocument.Parse(File.ReadAllText(telemetryFile));
                var root = doc.RootElement;

                if (root.TryGetProperty("lastsession_Build", out JsonElement buildElem))
                    return buildElem.GetString() ?? "N/A";
            }
            catch (Exception ex)
            {
                return "N/A - " + ex.Message;
            }

            return "N/A";
        }
    }
}
