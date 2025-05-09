using Dopamine.Utils;

namespace Dopamine.Handlers
{
    internal class Spoof
    {
        internal static async Task<(bool success, string msg)> RandomizeData()
        {
            return await Task.Run<(bool succ, string resp)>(() => {
                try
                {
                    string cidPath = Path.Combine(Minecraft.McpeDirectory, "clientId.txt");
                    if (!Directory.Exists(Minecraft.McpeDirectory))
                    {
                        return (false, $"Minecraft directory does not exist. ({Minecraft.McpeDirectory})");
                    }
                    else
                    {
                        if (File.Exists(cidPath))
                            File.WriteAllText(cidPath, Data.RandomString(19, false, true));

                        string[] lines = File.ReadAllLines(Minecraft.OptionsFile);
                        for (int i = 0; i < lines.Length; i++)
                        {
                            if (lines[i].StartsWith("mp_username"))
                            {
                                string[] parts = lines[i].Split(':');
                                parts[1] = Data.RandomString(Data.RandomInt(4, 10));
                                lines[i] = string.Join(":", parts);
                            }
                            if (lines[i].StartsWith("last_xuid"))
                            {
                                string[] parts = lines[i].Split(':');
                                parts[1] = Data.RandomString(16, false, true);
                                lines[i] = string.Join(":", parts);
                            }
                            if (lines[i].StartsWith("game_skintypefull"))
                            {
                                string[] parts = lines[i].Split(':');
                                parts[1] = Data.RandomString(Data.RandomInt(7, 50)).ToLower();
                                lines[i] = string.Join(":", parts);
                            }
                            if (lines[i].StartsWith("game_lastcustomskinnew"))
                            {
                                string[] parts = lines[i].Split(':');
                                parts[1] = Data.RandomString(Data.RandomInt(20, 100)).ToLower();
                                lines[i] = string.Join(":", parts);
                            }
                            if (lines[i].StartsWith("last_minecraft_id"))
                            {
                                string[] parts = lines[i].Split(':');
                                parts[1] = Data.RandomString();
                                lines[i] = string.Join(":", parts);
                                break;
                            }
                        }
                        File.WriteAllLines(Minecraft.OptionsFile, lines);
                        return (true, "Spoofed");
                    }
                } catch (Exception ex)
                {
                    return (false, ex.Message);
                }
            });
        }
    }
}
