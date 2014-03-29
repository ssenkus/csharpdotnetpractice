using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Employee : Person
    {
        public string jobTitle { get; set; }

        public string greet()
        {
            return String.Format("Howdy, I'm an employee named {0}, base method output {1}", this.name, base.greet());
        }

    }



}
