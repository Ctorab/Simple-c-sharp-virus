using ProgramKiller.Basics;
using System.Runtime.InteropServices;

namespace ProgramKiller.Viruses
{
    internal class HideWindow : IVirus
    {
        [DllImport("kernel32.dll")]
        private static extern IntPtr GetConsoleWindow();
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        public void Run() => ShowWindow(GetConsoleWindow(), 0);
    }
}
