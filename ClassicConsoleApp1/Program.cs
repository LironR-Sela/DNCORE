using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var svc = new ServiceReference1.WebService1SoapClient();
            var result = svc.AddNumbers(4, 6);
        }
    }
}
