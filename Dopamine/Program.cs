using Dopamine.Utils;

namespace Dopamine
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Data.StartConfigSetup();
            Application.Run(new Panel());
        }

        internal static string AppVersion = "1.0";
    }
}