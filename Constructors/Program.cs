using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(200);
            customerManager.List();
            Product product = new Product { Id = 1, Name = "Mouse" };
            Product product2 = new Product(2, "monitor");
            EmployeManager employeManeger = new EmployeManager(new DatabaseLogger());
            employeManeger.Add();
            PersonMannager personMannager = new PersonMannager("Product");
            personMannager.Add();
            //Teacher teacher = new Teacher();   not working!
            Teacher.number = 10;
            Utilities.Validate();
            Manager.DoSomething();
            Manager manager = new Manager();
            manager.DoSomething2();
            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        private int _count = 15;//filled startwith _
        public CustomerManager(int count)
        {
            _count = count;
        }
        public CustomerManager()
        {

        }
        public void List()
        {
            Console.WriteLine("Listed {0} items", _count);
        }
        public void Add()
        {
            Console.WriteLine("Added");
        }
    }
    class Product
    {
        public Product()
        {

        }
        private int _id;
        string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
    interface ILogger
    {
        void Log();
    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            System.Console.WriteLine("Logged to File");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            System.Console.WriteLine("Logged to database");
        }
    }
    class EmployeManager
    {
        private ILogger _logger;
        public EmployeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added");
        }
    }
    class BaseClass
    {
        private string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} message", _entity);
        }
    }
    class PersonMannager : BaseClass
    {
        public PersonMannager(string entity) : base(entity)
        {
        }
        public void Add()
        {
            Console.WriteLine("Adde!d");
            Message();
        }
    }
    static class Teacher
    {
        public static int number { get; set; }
    }
    static class Utilities
    {
        static Utilities()
        {
        }

        public static void Validate()
        {
            Console.WriteLine("Validation is done");
        }
    }
    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("Done");
        }
        public void DoSomething2()
        {
            Console.WriteLine("Done 2");
        }
    }
}
