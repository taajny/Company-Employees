using System;
using System.IO;
using System.Windows.Forms;

namespace Company_Employees
{
    
    internal static class Program
    {
        public static string FilePathJson = Path.Combine(Environment.CurrentDirectory, "employeesJson.txt");
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());
        }
    }
}
