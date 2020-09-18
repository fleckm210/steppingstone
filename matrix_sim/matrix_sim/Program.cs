using System;
using System.Threading;

namespace matrix_sim
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.Black;

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

            while (true)
            {
                //Console.Clear();

                Console.BackgroundColor = random[m.Next(0, 9)];

                Thread.Sleep(100);
                //Console.Clear();
                for (int i = 0; i < 10; i++)
                {
                    Console.SetCursorPosition(m.Next(0, 80), m.Next(0, 24));
                    Console.ForegroundColor = random[m.Next(0, 9)];
                    Console.Write(m.Next(0, 10));
                }

                for (int i = 0; i < 30; i++)
                {
                    Console.SetCursorPosition(m.Next(0, 5), m.Next(0, 24));
                    Console.ForegroundColor = random[m.Next(0, 9)];
                    Console.Write(m.Next(0, 10));
                }

                for (int i = 0; i < 30; i++)
                {
                    Console.SetCursorPosition(m.Next(35, 40), m.Next(0, 24));
                    Console.ForegroundColor = random[m.Next(0, 9)];
                    Console.Write(m.Next(0, 10));
                }

                for (int i = 0; i < 30; i++)
                {
                    Console.SetCursorPosition(m.Next(70, 75), m.Next(0, 24));
                    Console.ForegroundColor = random[m.Next(0, 9)];
                    Console.Write(m.Next(0, 10));
                }
                for (int i = 0; i < 60; i++)
                {
                    Console.SetCursorPosition(m.Next(0, Console.WindowWidth), m.Next(0, Console.WindowHeight));
                    Console.ForegroundColor = random[m.Next(0, 9)];
                    Console.Write(' ');
                }
            }
        }
    }
}
