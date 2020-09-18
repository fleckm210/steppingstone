using System;
using System.Threading;
using System.Threading.Tasks;

namespace Satisfying
{
    
    class LineDrawer
    {
        static Random rnd = new Random();
        public async void HorizontalLine(int StartingPosx, int StartingPosy, int HowLong, int Direction)
        {
            for (int i = 0; i<HowLong; i++)
            {
                Thread.Sleep(35);

                if (Direction == 1)
                {
                    try
                    {
                        Console.SetCursorPosition(StartingPosx + (i * 2), StartingPosy);
                    }
                    catch
                    {

                    }
                }
                else 
                {
                    try
                    {
                        Console.SetCursorPosition(StartingPosx - (i * 2), StartingPosy);
                    }
                    catch
                    {

                    }
                }
                Console.Write(rnd.Next(0, 9));
            }
        }

        public async void VerticalLine(int StartingPosx, int StartingPosy, int HowLong, int Direction)
        {
            for (int i = 0; i < HowLong; i++)
            {
                Thread.Sleep(35);

                if (Direction == 1)
                {
                    try
                    {
                        Console.SetCursorPosition(StartingPosx, StartingPosy + i);
                    }
                    catch
                    {

                    }
                }
                else
                {
                    try
                    {
                        Console.SetCursorPosition(StartingPosx, StartingPosy - i);
                    }
                    catch
                    {

                    }
                }
                Console.Write(rnd.Next(0, 9));
            }
        }
    }

    class MainClass
    {
        public static async void CreateLines()
        {
            LineDrawer ld = new LineDrawer();
            Random rnd = new Random();
            rnd.Next(0, Console.BufferHeight);

            for (int i = 0; i<5; i++)
            {
                ld.VerticalLine(rnd.Next(0, Console.BufferWidth), rnd.Next(0, Console.BufferHeight), 3, 1);
                ld.HorizontalLine(rnd.Next(0, Console.BufferWidth), rnd.Next(0, Console.BufferHeight), 3, 1);
            }
        }

        public static bool mysearch()
        {
            Thread.Sleep(5000);
            Console.Write("Counted to 5");

            return true;
        }

        public static async void asynctest()
        {
            var test = await Task.Run(mysearch);
            Console.Write("!");
        }

        //public async Task<int> ExampleMethodAsync()
        //{
            //...
        //}

        public static void Main(string[] args)
        {
            asynctest();

            Random m = new Random();

            ConsoleColor[] random = new ConsoleColor[10];

            random[0] = ConsoleColor.Blue;
            random[1] = ConsoleColor.Red;
            random[2] = ConsoleColor.Green;
            random[3] = ConsoleColor.Blue;
            random[4] = ConsoleColor.DarkRed;
            random[5] = ConsoleColor.DarkBlue;
            random[6] = ConsoleColor.DarkGreen;
            random[7] = ConsoleColor.Yellow;

            LineDrawer ld = new LineDrawer();
            Random rnd = new Random();
            rnd.Next(0, Console.BufferHeight);

            for (int i = 0; i<100; i++)
            {
                Console.ForegroundColor = random[rnd.Next(0, 7)];

                CreateLines();

                if (Console.KeyAvailable)
                {
                    //Console.Clear();
                }
            }
        }
    }
}
