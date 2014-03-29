using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() { 
                name = "Steve",
                age = 29
            };

            Employee emp = new Employee()
            {
                name = "Robot",
                age = 1,
                jobTitle = "Toilet Scrubber"
            };

            Console.WriteLine("Name: {0}, Age: {1}, Greeting: {2}", person.name, person.age, person.greet());
            Console.WriteLine("{0} - {1} - {2} - {3}", emp.name, emp.age, emp.jobTitle, emp.greet());
            Console.ReadLine();
        }
    }

   

}
