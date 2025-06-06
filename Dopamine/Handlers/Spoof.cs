﻿using Dopamine.Utils;
using DotNetConfig;
using Memory;
using System.IO;
using System.Text;
using System.Text.Json;
using static Dopamine.Utils.Data;

namespace Dopamine.Handlers
{
    internal class Spoof
    {
        private static Mem mem = new Mem();
        private static List<long> didPtrs = new List<long>();

        internal class TelemetryStruct
        {
            public int file_version { get; set; }
            public string guard { get; set; }
            public string lastsession_Build { get; set; }
            public string lastsession_id { get; set; }
            /* Example file below
             {
   "file_version" : 1,
   "guard" : "f61478be-a14f-3a8f-a583-c6f9cbfbb902",
   "lastsession_Build" : "1.21.62",
   "lastsession_id" : "50cbeb3a-687d-44f0-856e-d583ddfec8e5"
}
            These have to be set to public or the code won't work
             */
        }

        internal static async Task<(bool success, string msg)> RandomizeData()
        {
            return await Task.Run(() => {
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
                            File.WriteAllText(cidPath, RandomString(19, false, true));

                        // Modify telemetry.json
                        var json = File.ReadAllText(Path.Combine(Minecraft.McpeDirectory, "telemetry_info.json"));
                        var info = JsonSerializer.Deserialize<TelemetryStruct>(json);

                        info.guard = Guid.NewGuid().ToString().ToLower();
                        info.lastsession_id = Guid.NewGuid().ToString().ToLower();

                        var opts = new JsonSerializerOptions { WriteIndented = true };
                        var outJson = JsonSerializer.Serialize(info, opts);
                        File.WriteAllText(Path.Combine(Minecraft.McpeDirectory, "telemetry_info.json"), outJson);

                        string[] lines = File.ReadAllLines(Minecraft.OptionsFile);
                        for (int i = 0; i < lines.Length; i++)
                        {
                            if (lines[i].StartsWith("mp_username"))
                            {
                                string[] parts = lines[i].Split(':');
                                parts[1] = RandomString(RandomInt(4, 10));
                                lines[i] = string.Join(":", parts);
                            }
                            if (lines[i].StartsWith("mp_prev_app_name"))
                            {
                                string[] parts = lines[i].Split(':');
                                parts[1] = RandomString(RandomInt(4, 10));
                                lines[i] = string.Join(":", parts);
                            }
                            if (lines[i].StartsWith("last_xuid"))
                            {
                                string[] parts = lines[i].Split(':');
                                parts[1] = RandomString(16, false, true);
                                lines[i] = string.Join(":", parts);
                            }
                            if (lines[i].StartsWith("game_skintypefull"))
                            {
                                string[] parts = lines[i].Split(':');
                                parts[1] = RandomString(RandomInt(7, 50)).ToLower();
                                lines[i] = string.Join(":", parts);
                            }
                            if (lines[i].StartsWith("game_lastcustomskinnew"))
                            {
                                string[] parts = lines[i].Split(':');
                                parts[1] = RandomString(RandomInt(20, 100)).ToLower();
                                lines[i] = string.Join(":", parts);
                            }
                            if (lines[i].StartsWith("last_minecraft_id"))
                            {
                                string[] parts = lines[i].Split(':');
                                parts[1] = RandomString();
                                lines[i] = string.Join(":", parts);
                            }
                            if (lines[i].StartsWith("app_launched_count"))
                            {
                                string[] parts = lines[i].Split(':');
                                parts[1] = RandomInt(1, 1738).ToString();
                                lines[i] = string.Join(":", parts);
                            }
                            if (lines[i].StartsWith("device_lost_telemetry_enabled"))
                            {
                                string[] parts = lines[i].Split(':');
                                parts[1] = "0";
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

        internal static async Task<(bool success, string msg)> SpoofDID(string customDid = "")
        {
            return await Task.Run(async () => {
                try
                {
                    Config config = GetConfig();
                    int CurrentProcessId = 0;
                    CurrentProcessId = Minecraft.GetProcessID();
                    string uuid = string.Empty;
                    int lastKnownId = 0;

                    if (CurrentProcessId == 0)
                        return (false, "Minecraft is not open");

                    if (CurrentProcessId != config.GetNumber("Minecraft", "Process", "LastKnownProcessID"))
                        config.SetNumber("Minecraft", "Process", "LastKnownProcessID", CurrentProcessId);
                    else
                    {
                        lastKnownId = (int)config.GetNumber("Minecraft", "Process", "LastKnownProcessID");
                        didPtrs.Clear();
                        foreach (ConfigEntry savedDidPtr in GetConfig().GetAll("Minecraft", "Process", "Pointers").ToList())
                            didPtrs.Add(savedDidPtr.GetNumber());
                    }

                    if (string.IsNullOrEmpty(customDid))
                        uuid = Guid.NewGuid().ToString();
                    else
                        uuid = customDid;

                    string did = await Minecraft.GetDIDFromFile();
                    string didaob = BitConverter.ToString(Encoding.UTF8.GetBytes(did)).Replace("-", " ");

                    int count = 0;
                    try
                    {
                        if (mem.OpenProcess("Minecraft.Windows"))
                        {
                            if (lastKnownId != Minecraft.GetProcessID())
                            {
                                didPtrs = new List<long>();
                                config.UnsetAll("Minecraft", "Process", "Pointers", null);
                                IEnumerable<long> results = await mem.AoBScan(0x0000000000000000, 0x00007fffffffffff, didaob, true, false);

                                foreach (long res in results)
                                {
                                    if (count >= 7) break;
                                    count++;
                                    didPtrs.Add(res);
                                    GetConfig().AddNumber("Minecraft", "Process", "Pointers", res);

                                    if (mem.WriteMemory(res.ToString("X"), "string", uuid))
                                    {
                                        // Wrote DID
                                    }
                                    else
                                    {
                                        // Couldn't write to memory
                                    }
                                }
                            }
                            else
                            {
                                foreach (long cachedDidPtr in didPtrs)
                                {
                                    if (mem.WriteMemory(cachedDidPtr.ToString("X"), "string", uuid))
                                    {
                                        //[2] Wrote DID
                                    }
                                    else
                                    {
                                        //[2] Couldn't write to Memory
                                    }
                                }
                            }
                            Minecraft.GetProcessID();
                            return (true, uuid);
                        }
                        else
                        {
                            return (false, "Could not open Minecraft, is it open?");
                        }
                    }
                    catch (Exception ex)
                    {
                        return (false, "Error occured when trying to spoof.\n" + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    return (false, ex.Message);
                }
            });
        }
    }
}
