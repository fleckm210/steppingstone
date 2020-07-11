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

            while (true)
            {
                Thread.Sleep(100);
                //Console.Clear();
                for (int i = 0; i < 10; i++)
                {
                    Console.SetCursorPosition(m.Next(0, 80), m.Next(0, 24));

                    Console.Write(m.Next(0, 10));
                }

                for (int i = 0; i < 30; i++)
                {
                    Console.SetCursorPosition(m.Next(0, 5), m.Next(0, 24));

                    Console.Write(m.Next(0, 10));
                }

                for (int i = 0; i < 30; i++)
                {
                    Console.SetCursorPosition(m.Next(35, 40), m.Next(0, 24));

                    Console.Write(m.Next(0, 10));
                }

                for (int i = 0; i < 30; i++)
                {
                    Console.SetCursorPosition(m.Next(70, 75), m.Next(0, 24));

                    Console.Write(m.Next(0, 10));
                }
                for (int i = 0; i < 60; i++)
                {
                    Console.SetCursorPosition(m.Next(0, Console.WindowWidth), m.Next(0, Console.WindowHeight));

                    Console.Write(' ');
                }
            }
        }
    }
}
