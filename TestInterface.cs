using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icertics_program
{
    interface I1
    {
        void Paint();
    }
    interface I2
    {
        void Paint();

    }
    public class Test : I1, I2
    {
        void I1.Paint()
        {
            Console.WriteLine("call from I1 Interface");
        }

        void I2.Paint()
        {
            Console.WriteLine("call from I2 Interface");
        }
        
    }
    class TestInterface
    {
        static void Main()
        {
            Test test = new Test();
            I1 i1 = new Test();
            i1.Paint();
            I2 i2 = new Test();
            i2.Paint();
            Console.ReadLine();
        }
    }
}
