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
            void HelloWorld()
            {
                Console.WriteLine("Hello World");
            }
            void Sum(int a, int b) 
            {
                int sum = a + b;
                Console.WriteLine(sum);
            }
            void human(string name, int age)
            {
                Console.WriteLine($"{name}, {age}");
            }
            human("Дмитрий", 33);
           
        }
    }
}


