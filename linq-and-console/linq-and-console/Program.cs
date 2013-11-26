using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_and_console
{

    class Program
    {


        public class numSet
        {

            public int cnt { get; set; }
            public IEnumerable<int> aboveQuery { get; set; }
            public IEnumerable<int> halfQuery { get; set; }
            public IEnumerable<int> belowQuery { get; set; }

            public numSet(List<int> list)
            {
                aboveQuery = from r in list where r > 50 orderby r ascending select r;
                halfQuery = from r in list where r == 50 orderby r ascending select r;
                belowQuery = from r in list where r < 50 orderby r ascending select r;
            }


            public void printBelow()
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Below 50: " + belowQuery.Count());
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   At 50: " + halfQuery.Count());
                Console.WriteLine("Above 50: " + aboveQuery.Count());
                Console.WriteLine(String.Concat(Enumerable.Repeat("-", 50)));

                foreach (var n in belowQuery)
                {
                    Console.Write(String.Format("{0} ", n));
                }

                Console.ReadLine();

            }
            public void printHalf()
            {

                Console.Clear();
                Console.WriteLine("Below 50: " + belowQuery.Count());
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("   At 50: " + halfQuery.Count());
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Above 50: " + aboveQuery.Count());
                Console.WriteLine(String.Concat(Enumerable.Repeat("-", 50)));


                foreach (var n in halfQuery)
                {
                    Console.Write(String.Format("{0} ", n));
                }


                Console.ReadLine();


            }

            public void printAbove()
            {

                Console.Clear();

                Console.WriteLine("Below 50: " + belowQuery.Count());
                Console.WriteLine("   At 50: " + halfQuery.Count());
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Above 50: " + aboveQuery.Count());
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine(String.Concat(Enumerable.Repeat("-", 50)));

                foreach (var n in aboveQuery)
                {
                    Console.Write(String.Format("{0} ", n));
                }

                Console.ReadLine();
            }



        }



        public void printAllRandoms(List<int> rndList)
        {
            Console.WriteLine("Random Numbers");
            Console.WriteLine(String.Concat(Enumerable.Repeat("-", 50)) + "\n");

            int count = 0;
            foreach (var n in rndList)
            {
                switch (count++ % 5)
                {
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
                    default:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
                Console.Write(String.Format("{0} ", n));
            }
            Console.ReadLine();
        }

        public List<int> generateRandomNumbers(int length, int minOut = 0, int maxOut = 10)
        {
            Random rnd = new Random();
            List<int> list = new List<int>();


            for (int i = 0; i < length; i++)
            {
                list.Add(rnd.Next(minOut, maxOut));
            }
            return list;

        }

        static void Main(string[] args)
        {

            Program prog = new Program();
            List<int> list = prog.generateRandomNumbers(100, 0, 100);
            prog.printAllRandoms(list);
            numSet data = new numSet(list);
            data.printBelow();
            data.printHalf();
            data.printAbove();

        }
    }
}
