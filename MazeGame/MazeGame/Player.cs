using System;

namespace MazeGame
{
    public class Player
    {
        public static char pl = '@';
        public static int plX = 0, plY = 0;

        public static void Placepl()
        {
            Random rand = new Random();
            plX = rand.Next(0, Maze.width - 1);
            plY = rand.Next(0, Maze.height - 1); ;
        }
    }
}