using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icertics_program
{
    public class ReverseStringAndNumber
    {
        public int ReverseInt(int Number)
        {
            int Reverse = 0;
            while (Number > 0)
            {
                int remainder = Number % 10;
                Reverse = (Reverse * 10) + remainder;
                Number = Number / 10;
            }
            return Reverse;
        }

        public string ReverseString(string str)
        {
            string reverse = "";
            int Length = 0;           
            Length = str.Length - 1;
            while (Length >= 0)
            {
                reverse = reverse + str[Length];
                Length--;
            }
            return reverse;
        }
        static void Main()
        {
            ReverseStringAndNumber reverse = new ReverseStringAndNumber();
            Console.WriteLine("Resverse Int : " + reverse.ReverseInt(12345));
            Console.WriteLine("Resverse String : " + reverse.ReverseString("Gajanand"));
            Console.ReadLine();
        }
    }
}
