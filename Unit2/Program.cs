using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;

            if (b > a)
            {

                Console.WriteLine($"число {b} больше числа {a}");
            }

            else if (b < a)
            {
                Console.WriteLine($"число {b} меньше числа {a}");
            }
            else

            {
                Console.WriteLine($"число {b} равно {a}");
            }
        }
    }
}


