using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icertics_program
{
    class stringQuiz
    {
        public void countOccurancesChar(string message)
        {
            message = message.Replace(" ", string.Empty);

            while (message.Length > 0)
            {
                Console.Write(message[0] + " : ");
                int count = 0;
                for (int j = 0; j < message.Length; j++)
                {
                    if (message[0].ToString().ToLower() == message[j].ToString().ToLower())
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                message = message.Replace(message[0].ToString(), string.Empty);
            }


        }

        static void Main()
        {
            stringQuiz stringQuiz = new stringQuiz();
            stringQuiz.countOccurancesChar("google");
            Console.ReadLine();
        }
    }
}
