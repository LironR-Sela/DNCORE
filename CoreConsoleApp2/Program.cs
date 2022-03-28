using Microsoft.Win32;
using System;
using System.Collections;
using System.Net;
using System.Runtime.InteropServices;

namespace CoreConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                var registryKey = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion";
                var key = Registry.LocalMachine.OpenSubKey(registryKey);
                var versionName = key.GetValue("ProductName");
            }

            var wc = new WebClient();
            var arr = new ArrayList();
        }
    }
}
