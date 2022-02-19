using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerMenager = new CustomerManager();
            customerMenager.Add();
            customerMenager.Update();
            ProductManager productMenager = new ProductManager();
            productMenager.Add();
            productMenager.Update();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.City = "Istanbul";
            customer.FirstName = "Can";
            customer.LastName = "Celik";

            Customer customer2 = new Customer
            {
                Id = 1,
                City = "Istanbul",
                FirstName = "Can",
                LastName = "Celik",
            };

            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }
}
