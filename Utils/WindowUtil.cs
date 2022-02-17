using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CalendarFireBrigade {
    public static class WindowUtil {

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        private static string GetProcessNameFromActiveWindow() {
            return GetProcessNameFromWindowHandle(GetForegroundWindow());
        }

        private static string GetProcessNameFromWindowHandle(IntPtr hwnd) {
            try {
                GetWindowThreadProcessId(hwnd, out var pid);
                Process p = Process.GetProcessById((int) pid);
                return p.MainModule?.FileName;
            } catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }

            return string.Empty;
        }

    }
}
