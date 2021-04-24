using System;
using System.Reflection.Metadata.Ecma335;

namespace MazeGame
{
    public class Logic
    {
        public static int plX = 0, plY = 0;
        public static bool reached;
        public static void Logical()
        {
            GoTo(Player.plX + plX, Player.plY + plY);
            Finishgame();
        }
        public static (int, int) GetInput()
        {
            (plX, plY) = (0, 0);
            char symbol = char.Parse(Console.ReadLine());
            Controller.Input(symbol);
            Console.Clear();
            return GetInput();   
        }
        public static void Finishgame()
        {
            if (Player.plX == Maze.finishX && Player.plY == Maze.finishY)
            {
                Console.WriteLine("Game finished!");

                reached = true;
            }
        }
        static void GoWalk(int newX, int newY)
        {
            if (CanWalk(newX, newY))
                GoWalk(newX, newY);
        }
        static bool Walking(int X, int Y)
        {
            if (Maze.field[Y, X] == '#')
            {
                Console.WriteLine("you hit the wall, be careful!");
                return false;
            }
            return true;
        }
        static bool CanWalk(int newX, int newY)
        {
            if (newX < 0 || newY < 0 || newX >= Maze.width || newY >= Maze.height)
                return false;
            if (!Walking(newX, newY))
                return false;
            return true;
        }
        static void GoTo(int newX, int newY)
        {
            (Player.plX, Player.plY) = (newX, newY);
        }
    }
}