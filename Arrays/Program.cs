using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string student1 = "can";
            //string student2 = "cem";
            //string student3 = "cenk";
            string[] students = new string[3];
            students[0] = "can";
            students[1] = "cem";
            students[2] = "cenk";
            string[] students2 = { "can", "Derin", "Salih" };

            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }
            string[,] regions = new string[3, 3] { { "q", "b", "c" }, { "e", "f", "g" }, { "w", "p", "o" } };
            for(int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("----------------------");
            }
            Console.ReadLine();
        }
    }
}
