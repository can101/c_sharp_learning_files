using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //try
            //{
            //    string[] strudents = new string[3] { "Engin", "Can", "Salih" };

            //    strudents[3] = "Mehmet";
            //}
            //catch (IndexOutOfRangeException exception)
            //{
            //    Console.WriteLine(exception.Message);
            //}
            //catch (DivideByZeroException exception)
            //{
            //    Console.WriteLine(exception.Message);
            //}
            //catch (Exception exception)
            //{
            //    Console.WriteLine(exception.Message);
            //}

            //try
            //{
            //    Find();
            //}
            //catch (RecordNotFoundException exception)
            //{
            //    Console.WriteLine(exception.Message);
            //}

            //Method
            HandleExeption(() =>
            {

                Find();
            });

            Console.ReadLine();
        }

        private static void HandleExeption(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            string[] students = new string[3] { "Engin", "Can", "Salih" };

            if (!students.Contains("Murat"))
            {
                throw new RecordNotFoundException("Record not found");
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }
    }
}
