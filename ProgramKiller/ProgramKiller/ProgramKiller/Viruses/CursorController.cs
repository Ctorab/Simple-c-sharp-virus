using ProgramKiller.Basics;
using System.Runtime.InteropServices;

namespace ProgramKiller.Viruses
{
    internal class CursorController : IVirus
    {
        [DllImport("user32.dll")]
        private static extern bool SetCursorPos(int X, int Y);

        public void Run() => SetCursorPos(0, 0);
    }
}
