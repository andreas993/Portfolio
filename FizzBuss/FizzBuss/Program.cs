using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuss
{
    class Program
    {
        static void Main(string[] args)
        {
            string fizz = "Fizz";
            string buzz = "Buzz";
            string jazz = "Jazz";


            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(fizz + buzz + $" ({i.ToString()})");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(fizz + $" ({i.ToString()})");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(buzz + $" ({i.ToString()})");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }

            Console.ReadLine();
        }
    }
}
