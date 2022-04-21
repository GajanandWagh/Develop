using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icertics_program
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class AbstarctClass
    {
        static AbstarctClass()
        { }
        public abstract void Print();
        public void SayHello()
        {
            Console.WriteLine("Say Hello???");
        }

    }
    class TestAbstract:AbstarctClass
    {
        public override void Print()
        {
            Console.WriteLine("Print Hello???");
        }
        public static void Main()
        {            
            TestAbstract testAbstract = new TestAbstract();
            testAbstract.Print();
            testAbstract.SayHello();
            AbstarctClass abstarctClass = testAbstract;
            abstarctClass.Print();
            abstarctClass.SayHello();
            Console.ReadLine();
        }
      
    }
}
