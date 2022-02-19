using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello World");
            int number1 = 2147483647;//-2147483648 between 2147483647;
            long number2 = 2147483648;
            short number3 = 32767;
            byte number4 = 255;
            double number5 = 10.4;
            decimal number6 = 10.4m;//10 10.4m 10.4M
            var number7 = 10;
            number7 = 'A';//not string "A"
            bool condition = false;
            char chracter = 'A';
            Console.WriteLine("Number1 is {0} max -> {1} min -> {2}", number1,int.MaxValue ,int.MinValue);
            Console.WriteLine("Number2 is {0} max -> {1} min -> {2} ", number2, long.MaxValue, long.MinValue);
            Console.WriteLine("Number3 is {0} max -> {1} min -> {2} ", number3, short.MaxValue, short.MinValue);
            Console.WriteLine("Number4 is {0} max -> {1} min -> {2} ", number4, byte.MaxValue, byte.MinValue);
            Console.WriteLine("Number5 is {0} max -> {1} min -> {2} ", number5, double.MaxValue, double.MinValue);
            Console.WriteLine("chracter is {0}",(int)chracter);
            Console.WriteLine((int)Days.Friday);
            Console.WriteLine(number7);
            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday=100,Tuesday,Wednesday,Thursday,Friday=32,Saturday,Sunday
    }
}
