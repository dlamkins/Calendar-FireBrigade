using System;
using System.IO;
using System.Windows.Forms;

namespace CalendarFireBrigade {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CfbConfig.LoadState();

            Application.Run(new Main());
        }

        private static void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs e) {
            string err = $"Calendar FireBrigade crashed with unhandled exception.\r\nPlease submit this error to the repo for review.\r\n{(e.ExceptionObject as Exception).Message}";

            try {
                File.WriteAllText("calendarfirebrigade_crash.txt", err);
            } catch (Exception) {
                MessageBox.Show(err, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
