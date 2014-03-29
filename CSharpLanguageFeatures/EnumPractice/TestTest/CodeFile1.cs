using System;

namespace Derp
{
    public class MyClass
    {


        static void Main()
        {
            TimeOfDay time = new TimeOfDay();
            string[] outMessages = { DateTime.Now.Hour.ToString(), DateTime.Now.ToString(), DateTime.Today.Ticks.ToString() };
            WriteToConsole(outMessages);
            int hour = timeNow().Hour;
            
            Console.ReadLine();

        }

        public static DateTime timeNow()
        {
            return DateTime.Now;
        }

        public static void WriteToConsole(string[] strings)
        {
            foreach (string s in strings)
            {
                Console.WriteLine(s);
                Console.WriteLine();
            }
        }

    }



    public enum TimeOfDay
    {
        Morning = 0,
        Afternoon = 1,
        Evening = 2,
        Night = 3
    }

}