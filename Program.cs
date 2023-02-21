using System;
using System.Threading;
using System.Windows.Forms;

namespace SysMon
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (Mutex mutex = new Mutex(false, @"Global\" + "SysMon"))
            {
                if (!mutex.WaitOne(0, false))
                {
                    MessageBox.Show("Приложение уже запущено!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new body());
            }
        }
    }
}
