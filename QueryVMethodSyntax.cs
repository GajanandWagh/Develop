using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Icertics_program
{
    class QueryVMethodSyntax
    {
        
        static void Main()
        {
            int[] numbers = { 5, 10, 8, 3, 6, 12 };

            //Query syntax:
            IEnumerable<int> numQuery1 =
                from num in numbers
                where num % 2 == 0
                orderby num
                select num;

            int res = numbers.ElementAtOrDefault(3);

            var secondmax= numbers.OrderByDescending(r => r).Skip(1).FirstOrDefault();

            var second = (from no in numbers
                          orderby no descending
                          where no<(from n in numbers select n).Max()
                          select no).FirstOrDefault();
            //Method syntax:
            // IEnumerable<int> numQuery2 = numbers.Where(num => num % 2 == 0).OrderBy(n => n);
            List<int> numQuery2 = numbers.Where(num => num % 3 == 0).OrderBy(n => n).ToList<int>();

            foreach (int i in numQuery1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(System.Environment.NewLine);
            foreach (int i in numQuery2)
            {
                Console.Write(i + " ");
            }

            List<Employee> ListEmployee = new List<Employee>();
            ListEmployee.Add(new Employee("Gajanand", 51000, 34, "Male"));
            ListEmployee.Add(new Employee("Shital", 46000, 33, "Female"));
            ListEmployee.Add(new Employee("Gaurav", 46000, 32, "Male"));
            ListEmployee.Add(new Employee("shweta", 36000, 33, "Female"));
            ListEmployee.Add(new Employee("Mahesh", 36000, 33, "Male"));

            var result= (from emp in ListEmployee
                         orderby emp.salary descending 
                         where emp.salary<((from e in ListEmployee select e.salary).Max())
                         select emp.salary).FirstOrDefault();

            var secondhighestsal = ListEmployee.OrderByDescending(em => em.salary).Skip(1)                                              .FirstOrDefault();

            var result2 = (from emp1 in ListEmployee
                           group emp1 by emp1.gender into g
                           orderby g.Key
                           select new { Gender = g.Key, count = g.Count() });
                          


            // Keep the console open in debug mode.
            Console.WriteLine(System.Environment.NewLine);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
    public class Employee
    {
        public Employee(string Name, int Salary, int Age, string Gender)
        {
            this.name = Name;
            this.salary = Salary;
            this.age = Age;
            this.gender = Gender;
        }
        public string name { get; set; }
        public int salary { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
    }
}
