using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OpenReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a message to write to file:");
            string txt = Console.ReadLine();
            Random rnd = new Random();
            string randomData = "";
            for (int i = 0; i < 10000; i++)
            {
                char randomChar = Convert.ToChar(rnd.Next(200, 400));
                randomData += randomChar;
                switch (i % 6) { 
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
                Console.Write("{0}", Convert.ToChar(rnd.Next(200, 400)));
            }
                
            string text = System.IO.File.ReadAllText(@"c:\users\steveo\documents\visual studio 2012\Projects\OpenReadFile\OpenReadFile\data_file.txt");
            Console.WriteLine("\n\n");
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
