using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace well_fuck
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;

            int a, b;

            Console.WriteLine("Enter first number:");

            str = Console.ReadLine();

            a = Convert.ToInt32(str);

            Console.WriteLine("Enter second number:");

            str = Console.ReadLine();

            b = Convert.ToInt32(str);

            int result = a + b;

            Console.WriteLine("Result:" + result);
            Console.ReadKey();
        }
    }
}
