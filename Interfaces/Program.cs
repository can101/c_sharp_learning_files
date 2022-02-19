using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PersonManager personManager = new PersonManager();
            //Customer customer = new Customer { Id = 1, FirstName = "can", LastName = "celik", Address = "Istanbul" };
            //Student student = new Student { Id = 1, FirstName = "seyma", LastName = "celik", Deparmant = "Computer Siences" };
            //Worker worker = new Worker { Id = 1, FirstName = "seyma", LastName = "celik", Deparment = "casier" };

            //personManager.Add(student);
            //CustomerMenager customerMenager = new CustomerMenager();
            //customerMenager.Add(new OracleCustomerDal());
            ICustomerDal[] customerDals = new ICustomerDal[] { new SqlServerCustomerDal(), new OracleCustomerDal(), new MySqlCustomerDal() };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            Console.ReadLine();
        }
        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }
        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Address { get; set; }
        }
        class Worker : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Deparment { get; set; }
        }
        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Deparmant { get; set; }

        }
        class PersonManager
        {
            public void Add(IPerson customer)
            {
                Console.WriteLine(customer.FirstName);
            }
        }
    }
}
