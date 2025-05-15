using Microsoft.Win32.SafeHandles;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;

namespace Dopamine.Handlers
{
    internal class Injection
    {
        //Credits Echo
        [DllImport("kernel32.dll")]
        private static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        private static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress,
            uint dwSize, uint flAllocationType, uint flProtect);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out UIntPtr lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        private static extern IntPtr CreateRemoteThread(IntPtr hProcess,
            IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

        private const int PROCESS_CREATE_THREAD = 0x0002;
        private const int PROCESS_QUERY_INFORMATION = 0x0400;
        private const int PROCESS_VM_OPERATION = 0x0008;
        private const int PROCESS_VM_WRITE = 0x0020;
        private const int PROCESS_VM_READ = 0x0010;

        private const uint MEM_COMMIT = 0x00001000;
        private const uint MEM_RESERVE = 0x00002000;
        private const uint PAGE_READWRITE = 4;

        private static void ApplyAccess(string path)
        {
            FileInfo InfoFile = new FileInfo(path);
            FileSecurity fSecurity = InfoFile.GetAccessControl();
            fSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier("S-1-15-2-1"), FileSystemRights.FullControl, InheritanceFlags.None, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
            InfoFile.SetAccessControl(fSecurity);
        }

        internal static async Task<(bool Success, string Error)> InjectDLL(string path)
        {
            return await Task.Run(() =>
            {
                try
                {
                    Process[] targetProcessIndex = Process.GetProcessesByName("Minecraft.Windows");
                    if (targetProcessIndex.Length > 0)
                    {
                        ApplyAccess(path);

                        Process targetProcess = Process.GetProcessesByName("Minecraft.Windows")[0];
                        IntPtr procHandle = OpenProcess(PROCESS_CREATE_THREAD | PROCESS_QUERY_INFORMATION | PROCESS_VM_OPERATION | PROCESS_VM_WRITE | PROCESS_VM_READ, false, targetProcess.Id);

                        IntPtr loadLibraryAddr = GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA");

                        IntPtr allocMemAddress = VirtualAllocEx(procHandle, IntPtr.Zero, (uint)((path.Length + 1) * Marshal.SizeOf(typeof(char))), MEM_COMMIT | MEM_RESERVE, PAGE_READWRITE);

                        UIntPtr bytesWritten;
                        WriteProcessMemory(procHandle, allocMemAddress, Encoding.Default.GetBytes(path), (uint)((path.Length + 1) * Marshal.SizeOf(typeof(char))), out bytesWritten);
                        CreateRemoteThread(procHandle, IntPtr.Zero, 0, loadLibraryAddr, allocMemAddress, 0, IntPtr.Zero);
                        return (true, "Injected");
                    }
                    else
                    {
                        return (false, "Minecraft is not running");
                    }
                }
                catch (Exception ex)
                {
                    return (false, $"ERROR - {ex.Message}");
                }
            });
        }

        internal static async Task<(bool Success, string Error)> GetAndInjectClient(string clientName)
        {
            return await Task.Run(async () =>
            {
                try
                {
                    if (Utils.Minecraft.GetProcessID() == 0)
                        return (false, "Minecraft is not open");

                    switch (clientName)
                    {
                        case "Horion":
                            await Utils.Data.DownloadFile("https://horion.download/dll", Path.Combine(Utils.Data.ConfigDirectory, $"{clientName}.dll"));
                            await InjectDLL(Path.Combine(Utils.Data.ConfigDirectory, $"{clientName}.dll"));
                            return (true, $"Injected {clientName}");

                        case "Latite":
                            await Utils.Data.DownloadFile("https://github.com/Imrglop/Latite-Releases/releases/latest/download/Latite.dll", Path.Combine(Utils.Data.ConfigDirectory, $"{clientName}.dll"));
                            await InjectDLL(Path.Combine(Utils.Data.ConfigDirectory, $"{clientName}.dll"));
                            return (true, $"Injected {clientName}");

                        case "Flarial":
                            await Utils.Data.DownloadFile("https://github.com/flarialmc/newcdn/raw/main/dll/latest.dll", Path.Combine(Utils.Data.ConfigDirectory, $"{clientName}.dll"));
                            await InjectDLL(Path.Combine(Utils.Data.ConfigDirectory, $"{clientName}.dll"));
                            return (true, $"Injected {clientName}");

                        case "Onix":
                            await Utils.Data.DownloadFile("https://github.com/bernarddesfosse/onixclientautoupdate/raw/main/OnixClient.dll", Path.Combine(Utils.Data.ConfigDirectory, $"{clientName}.dll"));
                            await InjectDLL(Path.Combine(Utils.Data.ConfigDirectory, $"{clientName}.dll"));
                            return (true, $"Injected {clientName}");
                    }

                    return (false, "Client not in list");
                }
                catch (Exception ex)
                {
                    return (false, $"ERROR - {ex.Message}");
                }
            });
        }
    }
}
