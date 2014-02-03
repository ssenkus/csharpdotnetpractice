using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusyNess
{
    class HotMess
    {

        private static int lineCount = 0;

        private static void setWindowSize()
        {

            int width = Console.WindowWidth;
            int height = Console.WindowHeight;
            ConsoleKeyInfo keypress;

            bool loop = true;
            while (loop)
            {
                Console.WriteLine(String.Format("\n\n\n\tUse arrow keys to adjust the console size, press Enter to start! \n\n\th:{0,4}\t\tw:{1,4}", Console.WindowHeight.ToString(), Console.WindowWidth.ToString()));
                keypress = Console.ReadKey(); // read keystrokes 
                switch (keypress.Key)
                {
                    case ConsoleKey.LeftArrow:
                        width--;
                        break;
                    case ConsoleKey.RightArrow:
                        width++;
                        break;
                    case ConsoleKey.UpArrow:
                        height--;
                        break;
                    case ConsoleKey.DownArrow:
                        height++;
                        break;
                    case ConsoleKey.Enter:
                        loop = false;
                        break;
                    default:
                        break;
                }
                width = (width == 0) ? 1 : width;
                width = (width > 100) ? 100 : width;
                height = (height == 0) ? 1 : height;
                height = (height > 30) ? 30 : height;

                Console.Clear();
                Console.SetWindowSize(width, height);
            }


        }

        private static void setColors()
        {

            ConsoleKeyInfo keypress;

            // Get a string array with the names of ConsoleColor enumeration members.
            String[] colors = ConsoleColor.GetNames(typeof(ConsoleColor));

            // starting defaults for my console
            // ** future: detect color of console first, then set index
            int fgColorIndex = 7;
            int bgColorIndex = 0;
            bool loop = true;
            while (loop)
            {
                Console.WriteLine(String.Format("\n\n\n\tUse arrow keys to adjust colors, press Enter to start! \n\n\tbg:{0,-11}\t\tfg:{1,-11}", Console.BackgroundColor.ToString(), Console.ForegroundColor.ToString()));
                keypress = Console.ReadKey(); // read keystrokes 
                switch (keypress.Key)
                {
                    case ConsoleKey.LeftArrow:
                        bgColorIndex--;
                        break;
                    case ConsoleKey.RightArrow:
                        bgColorIndex++;
                        break;
                    case ConsoleKey.UpArrow:
                        fgColorIndex++;
                        break;
                    case ConsoleKey.DownArrow:
                        fgColorIndex--;
                        break;
                    case ConsoleKey.Enter:
                        loop = false;
                        break;
                    default:
                        break;
                }

                bgColorIndex = (bgColorIndex == colors.Length) ? 0 : bgColorIndex;
                bgColorIndex = (bgColorIndex < 0) ? colors.Length - 1 : bgColorIndex;
                fgColorIndex = (fgColorIndex == colors.Length) ? 0 : fgColorIndex;
                fgColorIndex = (fgColorIndex < 0) ? colors.Length - 1 : fgColorIndex;
                ConsoleColor bgColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colors[bgColorIndex]);
                ConsoleColor fgColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colors[fgColorIndex]);
                Console.ForegroundColor = fgColor;
                Console.BackgroundColor = bgColor;
                Console.Clear();
            }
        }

        public static void Main(string[] args)
        {

            setColors();
            setWindowSize();
            HotMess messy = new HotMess();

            Action<int> WriteOut = WriteConsole;
            //Action<int, int, Action> Iterate = Loop;
            messy.Loop(1, 100, WriteOut);
            Console.ReadKey();

        }

        private void Loop(int start, int stop, Action<int> fn)
        {
            for (int i = start; i < stop; i++)
            {
                if (HotMess.lineCount % 20 == 0 && HotMess.lineCount != 0)
                {
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("\n\n");
                }
                if (HotMess.lineCount == 0) Console.WriteLine("\n\n");
                fn(i);
                HotMess.lineCount++;
            }
      
        }


        private static void WriteConsole(int lineNumber)
        {
            Console.Write(string.Format("{0,3} |{1}{2}\n", lineNumber.ToString(), (lineNumber % 3 == 0) ? "Hot" : "", (lineNumber % 7 == 0) ? "MESS" : ""));
        }
    }
}
