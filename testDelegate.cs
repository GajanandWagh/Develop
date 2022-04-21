using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icertics_program
{
    public delegate void sampleDelegate(int num);
    public class testDelegate
    {
        public void checkEven(int num)
        {
            if (num % 2 == 0)
                Console.WriteLine("This number is an even number");
            else
                Console.WriteLine("This number is an odd number");
        }

        public void squareNumber(int num)
        {
            Console.WriteLine("Square of this number is: {0}", num * num);
        }
    }

    class sample
    {
        public static void Main()
        {
            testDelegate obj = new testDelegate();
            sampleDelegate delegateObj = new sampleDelegate(obj.checkEven);
            delegateObj += new sampleDelegate(obj.squareNumber);
            delegateObj(25);
            Console.ReadLine();
        }
    }
}
