using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number - 1; i++)
            {
                if (number % 2 == 0)
                {
                    result = false;
                    i = number - 1;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            //for (int i = 100; i >= 0; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Finshed");
            //int number = 100;
            //while (number>=0)
            //{
            //    Console.WriteLine(number);
            //    number--;
            //}
            //Console.WriteLine("Now number is {0}", number);
            //int number = 11;
            //do
            //{
            //    Console.WriteLine(number);
            //    number--;
            //}
            //while (number>=0);
            //string[] students = { "can", "Derin", "Salih" };
            //foreach (var student in students)
            //{
            //    Console.WriteLine(student);
            //}
            if (IsPrimeNumber(6))
            {
                Console.WriteLine("this is a prime number");
            }
            else
            {
                Console.WriteLine("this is not a prime number");

            }
            Console.ReadLine();
        }
    }
}
