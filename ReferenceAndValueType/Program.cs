using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;

            Console.WriteLine(number2); //return value 10

            string[] cities1 = new string[] { "Ankara", "Adana", "Afyon" };//101
            string[] cities2 = new string[] { "Bursa", "Bolu", "Balikesir" };//-102- -->new refrence is  101
            cities2 = cities1;
            cities1[0] = "Istanbul";
            Console.WriteLine(cities2[0]);

            Console.ReadLine();
        }
    }
}
