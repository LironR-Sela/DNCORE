using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var registryKey = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion";
            var key = Registry.LocalMachine.OpenSubKey(registryKey);
            var versionName = key.GetValue("ProductName");
        }
    }
}
