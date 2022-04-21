using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Icertics_program
{
    class HackerrunTest
    {
        public void FizzBuzz(int num)
        {
            int val = 1;
            while (val<=num)
            {
                if (val % 3 == 0 && val % 5 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (val % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (val % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else { Console.WriteLine(val); }

                val++;
            }
        }

        static void Main()
        {
            HackerrunTest hackerrunTest = new HackerrunTest();
            hackerrunTest.FizzBuzz(15);
            Console.ReadLine();
        }
    }
}
