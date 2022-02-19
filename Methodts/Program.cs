using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //var result = Add2(5);
            int number1;
            int number2 = 100;
            var result2 = Add3(out number1, number2); //ref use the number refrence // out
            Console.WriteLine(result2);
            Console.WriteLine(number1);
            Console.WriteLine(Multiply(4,2,2));
            Console.WriteLine(Add4(4, 2, 2,3,4,6,765));
            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added!");
        }
        static int Add2(int number1, int number2 = 0)
        {
            return number1 + number2;
        }
        static int Add3(out int number1, int number2)
        {
            number1 = 30;
            return (number1 + number2);
        }
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2*number3;
        }
        static int Add4(params int[] numbers)
        {
            return numbers.Sum();   
        }
    }
}
