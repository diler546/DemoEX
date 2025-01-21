using Shuler_MasterPol.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shuler_MasterPol
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>

        public static MasterPolDb context = new MasterPolDb();

        [STAThread]
        static void Main()
        {
            if (context == null)
            {
                MessageBox.Show("Не удается установить соединение с базой данных");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
