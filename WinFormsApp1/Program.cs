using Microsoft.EntityFrameworkCore;

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
            //MessageBox.Show(System.Environment.CurrentDirectory+"\n"+System.Environment.CurrentDirectory);
            LibraryDbContext.SetSharedInstance("Data Source=Database\\Library.db");
            LibraryDbContext.Shared.Database.EnsureCreated();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            #region 应用程序关闭时执行的语句
           // LibraryDbContext.Shared.Dispose();
            //LibraryDbContext.Shared = null;//释放上下文
            #endregion
        }
    }
}