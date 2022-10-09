using Library.Repository;

namespace WF
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
            RepositoryFactory rf = new RepositoryFactory();
            IRepository repo = rf.GiveThisManARepository();

            if (repo.HasSettings())
            {
                Application.Run(new MainForm());
            }
            else
            {
                Application.Run(new EntryForm());
            }
            
        }
    }
}