using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
// ReSharper disable InconsistentNaming

namespace CalendarFireBrigade {
    public static class DockUtil {

        [DllImport("user32.dll")]
        private static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        public static void LaunchDocked(string exec, Panel panel) {
            var hWndParent = IntPtr.Zero;
            var hWndDocked = IntPtr.Zero;

            var pDocked = Process.Start(exec);

            while (hWndDocked == IntPtr.Zero) {
                Thread.Sleep(100);
                pDocked.Refresh();

                if (pDocked.HasExited) {
                    return;
                }

                hWndDocked = pDocked.MainWindowHandle;
            }

            hWndParent = SetParent(hWndDocked, panel.Handle);

            void PanelOnSizeChanged(object sender, EventArgs e) {
                MoveWindow(hWndDocked, 0, 0, panel.Width, panel.Height, true);
            }

            panel.SizeChanged += PanelOnSizeChanged;

            PanelOnSizeChanged(null, null);
        }

    }
}
