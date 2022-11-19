namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MessageBox.Show(System.Environment.CurrentDirectory+"\n"+System.Environment.CurrentDirectory);
            using (LibraryDbContext dbContext = LibraryDbContext.Shared) { 
                //初始化数据库
                dbContext.Database.EnsureCreated();

                
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());


        }
    }
}