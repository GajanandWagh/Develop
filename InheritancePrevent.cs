using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icertics_program
{
    public class InheritancePrevent
    {
        //private InheritancePrevent()
        //{ }
    }
    public class A: InheritancePrevent
    {
        public void Main()
        {
            A a = new A();
            
            Console.ReadLine();
        }
    }
   

}
