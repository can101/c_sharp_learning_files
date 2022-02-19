using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] cities = new string[] { "Ankara", "Istanbul" };
            //cities = new string[3];
            //Console.WriteLine(cities[0]);
            //cities[2] = "Adana";

            //ArrayList cties = new ArrayList();
            //cties.Add("Ankara");
            //cties.Add("Adana");
            //cties.Add("istanbul");
            //cties.Add(1);
            //cties.Add('A');
            //foreach (string item in cties)
            //{
            //    Console.WriteLine(item);
            //}
            //List<string> cities = new List<string>();
            //cities.Add("Ankara");
            //cities.Add("Istanbul");

            //foreach (var item in cities)
            //{
            //    Console.WriteLine(item);
            //}
            //List<Customer> customers= new List<Customer>();
            //customers.Add(new Customer{ Id=1,FirstName="Can"});
            //customers.Add(new Customer { Id = 2, FirstName = "Ebru" });
            //List<Customer> customers = new List<Customer>()
            //{
            //    new Customer{ Id=1,FirstName="Can"},
            //    new Customer { Id = 2, FirstName = "Ebru" }
            //};
            //var customer = new Customer { Id = 3, FirstName = "Emre" };
            //customers.Add(customer);
            //customers.AddRange(new Customer[] { new Customer { Id = 4, FirstName = "Ali" }, new Customer { Id = 5, FirstName = "cenk" } });
            ////customers.Clear();
            //Console.WriteLine(cities.Contains("Adana"));
            //Console.WriteLine("---> {0}", customers.Contains(customer));
            //var index = customers.IndexOf(customer);
            //Console.WriteLine("Index :{0}", index);
            //customers.Add(customer);
            //var index2 = customers.LastIndexOf(customer);
            //Console.WriteLine("Index :{0}", index2);
            //customers.Insert(0, customer);
            //customers.Remove(customer);
            //customers.Remove(customer);
            //customers.Remove(customer);
            //customers.RemoveAll(c => c.FirstName == "Emre");
            //foreach (var item in customers)
            //{
            //    Console.WriteLine(item.FirstName);
            //}
            //var count = customers.Count;
            //Console.WriteLine("Count : {0}", count);

            //          key  ,  value
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary.Add("Book", "Kitap");
            dictionary.Add("Table", "Tablo");
            dictionary.Add("Computer", "Bilgisayar");

            Console.WriteLine(dictionary["Book"]);
            //Console.WriteLine(dictionary["Hat"]);
            foreach (string key in dictionary.Keys)
            {
                Console.WriteLine(dictionary[key]); 
            }
            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.WriteLine(dictionary.ContainsKey("Table"));
            Console.ReadLine();
        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
