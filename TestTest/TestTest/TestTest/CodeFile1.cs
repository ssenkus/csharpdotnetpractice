using System;

namespace Derp
{
    public class MyClass
    {


        static void Main()
        {
            TimeOfDay time = TimeOfDay.Evening;
            Console.WriteLine(String.Format("{0}, {1}, {2}", 1,2,3));
            string x = Console.ReadLine();
            Console.WriteLine(x);
            Console.ReadLine();

        }

    }

    public enum TimeOfDay { 
        Morning = 0,
        Afternoon = 1,
        Evening = 2,
        Night = 3
    }

}