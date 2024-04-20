namespace SeansTakip
{
    public static class Program
    {
        public static Form1 homePage = new Form1();
        public const string pathDB = @"DB\DB.db";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        public static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(homePage);
        }

        public static bool existsDB()
        {
            if (!File.Exists(pathDB))
                return false;

            return true;
        }
    }
}