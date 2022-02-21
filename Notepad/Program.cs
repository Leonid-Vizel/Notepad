using System;
using System.Windows.Forms;

namespace TestForm
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length > 0)
            {
                Application.Run(new MainWindow(args[0]));
            }
            else
            {
                Application.Run(new MainWindow());
            }
        }
    }
}
