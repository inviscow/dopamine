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
            Application.Run(new Panel());
            /*
        public readonly static string McpeDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"Packages\Microsoft.MinecraftUWP_8wekyb3d8bbwe\LocalState\games\com.mojang\minecraftpe\");
        public static string OptionsFile = Path.Combine(McpeDirectory, "options.txt");
        public static string RootDataDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "FadedSolutions");
        public static readonly string DataDir = Path.Combine(RootDataDir, "Kaffee");
        public static readonly string AppDir = AppDomain.CurrentDomain.BaseDirectory;
        public static readonly string AppPath = Assembly.GetExecutingAssembly().Location;
             */
        }

        internal static string AppVersion = "1.0";
    }
}