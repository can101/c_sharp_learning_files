using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger=new SmseLogger();
            customerManager.Add();
            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        public ILogger Logger { get; set; }

        public void Add()
        {
            Logger.Log();
            Console.WriteLine("Customer added");
        }
    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Loged to file!");
        }
    }
    class SmseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to sms");
        }
    }
    interface ILogger
    {
        void Log();
    }
}
