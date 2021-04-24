using System;

namespace MazeGame
{
    public class Game
    {
        public static bool GameEnd()
        {
            return Logic.reached;
        }
        public static void Generate()
        {
            Maze.GenerateField();
            Player.Placepl();
        } 
    }
}