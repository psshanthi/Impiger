using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            //FirstExercise();
           Factorial f = new Factorial();
            //f.Execute();
            /*for (int i = 1; i <= 5; i++)
            {
                f.Execute1(i);
            }*/
            Console.WriteLine("Enter the Range");
            int k = int.Parse (Console.ReadLine());
            Console.WriteLine("The Range: " + k);
            do
            {
                f.Execute1(k);
                k--;
            } while (k > 0);
            Console.Read();
        }

        private static void FirstExercise()
        {
            List<int> Lobj = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Lobj.Add(i + 1);
            }
            Console.WriteLine("List of Numbers");
            foreach (var item in Lobj)
            {
                Console.WriteLine(item);
            }
            var res = Lobj.OrderByDescending(item => item);
            Console.WriteLine("Descending Order");

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
            var res1 = Lobj.Where(item => item % 2 == 0);
            Console.WriteLine("Even Numbers");
            foreach (var item in res1)
            {
                Console.WriteLine(item);
            }
            var res2 = Lobj.Where(item => item % 2 != 0);
            Console.WriteLine("Odd Numbers");
            foreach (var item in res2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
