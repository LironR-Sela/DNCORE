using System;
using MutliTargetConsoleApp.Models;

namespace MutliTargetConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if NET45
            Console.WriteLine("Hello Legacy 4.5!");
#elif NET5_0
            Console.WriteLine("Hello 5.0!");
#elif NET6_0
            var p6 = new Person6();
            Console.WriteLine("Hello 6.0!");
#elif NETCOREAPP
            var p6 = new Person6();
            var p3 = new Person3();
            Console.WriteLine("Hello .NET Core!");
#endif

            Console.ReadKey();
        }
    }
}
