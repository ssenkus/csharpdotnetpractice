using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Person
    {
        public string name { get; set; }
        public int  age { get; set; }


        public Person() { 
            this.name = "default name";
            this.age = -1;
        }

        public String greet() {
            return String.Format("Howdy, I'm a person named {0}", this.name);
        }

    }
}
