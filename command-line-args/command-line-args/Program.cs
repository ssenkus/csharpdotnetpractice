using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command_line_args
{
    class Program
    {
        static void Main(string[] args)
        {
            int len =  args.Length;
            for (int i = 0; i < len; i++) {
                Console.WriteLine(String.Format("{0}", args[i]));
            }
            Console.ReadLine();
        }
    }
}
