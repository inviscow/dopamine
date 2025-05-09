using System.Diagnostics;

namespace Dopamine.Utils
{
    internal class Data
    {
        internal static void OpenProcess(string process, string args = null)
        {
            Process.Start(process, args);
        }

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
    }
}
