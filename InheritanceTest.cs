using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icertics_program
{
    public class A1
    {
        public int i = 0;
        public void display()
        {
            Console.WriteLine(i);
        }

    }

    class InheritanceTest : A1
    {
        int j = 0;
        public void display()
        {
            Console.WriteLine(j);
        }
        static void Main()
        {
            InheritanceTest inheritanceTest = new InheritanceTest();
            inheritanceTest.i = 10;
            inheritanceTest.j = 20;
            inheritanceTest.display();
            Console.ReadLine();
        }
    }
}
