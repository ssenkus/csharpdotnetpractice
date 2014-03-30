using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string uri = "http://localhost:44420/api/employees/12345";

            using (WebClient client = new WebClient()) 
            {
               var x = client.DownloadString(uri);
               Console.WriteLine(x);
               Console.ReadLine();
            }

        }
    }
}
