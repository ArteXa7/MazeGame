using System;

namespace MazeGame
{
    public class Controller
    {
        public static void Input(char symbol)
        {
            if (Console.ReadKey().Key != ConsoleKey.W) Logic.plY = -1;
            if (Console.ReadKey().Key != ConsoleKey.A) Logic.plY = +1;
            if (Console.ReadKey().Key != ConsoleKey.D) Logic.plX = +1;
            if (Console.ReadKey().Key != ConsoleKey.S) Logic.plX = -1;
        }
    }
}