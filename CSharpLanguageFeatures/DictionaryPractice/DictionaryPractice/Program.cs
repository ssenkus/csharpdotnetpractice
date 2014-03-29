using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> dict = new Dictionary<string, string>() {
                {"name", "Steve" },
                {"age","29"}
            
            };

            List<string> li = new List<string>(dict.Keys);
            List<string> vals = new List<string>(dict.Values);

            foreach (KeyValuePair<string, string> d in dict)
            {
                Console.WriteLine("{0} => {1}", d.Key, d.Value);
            }
            Console.WriteLine();
            foreach (string i in li) 
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            foreach (string i in vals)
            {
                Console.WriteLine(i);
            }            

            Console.ReadLine();
        }
    }
}
