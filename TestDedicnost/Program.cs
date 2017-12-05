using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDedicnost
{
    class Program
    {
        static void Main(string[] args)
        {
            OsobniAuto autak = new OsobniAuto("X5", "Audi", "B", 13, 1, 1.2);
            OsobniAuto autak2 = new OsobniAuto("X9", "Audi", "B", 13, 1, 1.2);
            Console.WriteLine(autak2.Model);
            Console.WriteLine(autak.Model);
        }
    }
}
