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
            ApplicationConfiguration.Initialize();
            Data.StartConfigSetup();
            Application.Run(new Panel());
        }

        internal static string AppVersion = "1.0";
    }
}