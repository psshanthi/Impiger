using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Factorial
    {
        public void Execute()
        {
            int fact = 1;
            for (int i = 1; i < 6; i++)
            {
                fact *= i;
            }
            Console.WriteLine("Factorial of a Given Number");
            Console.WriteLine(fact);
        }
        public void Execute1(int j)
        {
            int fact = 1;
            for (int i = 1; i <= j; i++)
            {
                fact *= i;
            }
            Console.WriteLine("Factorial of "+j+":");
            Console.WriteLine(fact);
        }
    }
}
