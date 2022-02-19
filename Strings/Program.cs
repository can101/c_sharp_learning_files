using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "My name is can101";
            var res=sentence.Length;
            var res2 = sentence.Clone(); // new reference creating
            sentence = "my name is can101";
            bool res3 = sentence.EndsWith("y");
            bool res4 = sentence.StartsWith("z");
            var res5 = sentence.IndexOf("name");
            var res6 = sentence.IndexOf(" ");
            var res7 = sentence.LastIndexOf(" ");
            var res8 = sentence.Insert(0, "hello world");
            var res9 = sentence.Substring(0,4);
            var res10 = sentence.ToLower();
            var res11 = sentence.ToUpper();
            var res12 = sentence.Replace(" ", "-");
            var res13=sentence.Remove(2,4);
            Console.WriteLine(res13);
            Console.WriteLine(res12);
            Console.WriteLine(res11);
            Console.WriteLine("==>"+res9);
            Console.WriteLine(res8);
            Console.WriteLine(res7);
            Console.WriteLine(res2);
            Console.WriteLine(res);
            string city = "Ankara";
            //Console.WriteLine(city[0]);
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }
            string city2 = "Istanbul";
            string result = city + city2;
            Console.WriteLine(result);  
            Console.WriteLine(String.Format("{0} {1}",city,city2));
            Console.ReadLine();
        }
    }
}
