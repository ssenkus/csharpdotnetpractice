using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool dump = true;
            string output;
            for (int i = 0; i < 100; i++)
            {
                output = String.Format("{0}: {1}{2}", i, (i % 3 == 0) ? "Fizz" : "", (i % 5 == 0) ? "Buzz" : "");
                Console.WriteLine(output);
                if (i % 10 == 0 && i != 0 && dump) 
                {
                    derp();
                    Console.ReadLine();
                }
            }
            Console.ReadLine();
        }
        static void derp() 
        {
            Console.WriteLine("sdfsd");
        }
    }
}
