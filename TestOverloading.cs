using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icertics_program
{
    class TestOverloading
    {
        public void Print()
        {
            Console.WriteLine("Print Hello???");
        }
        public string Print(string str_a)
        {
            return "Base Class Call"+str_a;
        }
    }
    class TestOverloading2 : TestOverloading
    {
        public new string Print(string str_a)
        {
            return str_a;
        }
        public static void Main()
        {
            TestOverloading2 testOverloading2 = new TestOverloading2();
            testOverloading2.Print();
            Console.WriteLine(testOverloading2.Print("Hello"));
            

            Console.ReadLine();
        }


    }
}
