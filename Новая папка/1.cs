using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] ab = Console.ReadLine().Split();
            byte a = Convert.ToByte(ab[0]);
            byte b = Convert.ToByte(ab[1]);

            Console.WriteLine(a + b);

        }
    }
}
