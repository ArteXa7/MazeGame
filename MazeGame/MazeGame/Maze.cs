using System;

namespace MazeGame
{
    public class Maze
    {
        public static int width = 10;
        public static int height = 10;
        public static char[,] field = new char[height, width];
        static int block_freq = 30;
        static char symbol;
        public static int finishX, finishY;

        public static void GenerateField()
        {
            for (int i = 0; i < height; i++)
            {
                field[i, 0] = ' ';
                for (int j = 0; j < width; j++)
                {
                    Random randd = new Random();

                    if (randd.Next(0, 101) < block_freq)
                    {
                        symbol = '#';
                    }
                    else
                    {
                        symbol = '.';
                    }

                    field[i, j] = symbol;
                }
            }

            Random rand = new Random();
            finishX = rand.Next(0, width - 1);
            finishY = rand.Next(0, height - 1);
            field[finishY, finishX] = 'O';
        }

        public static void DrawMaze()
        {
            Console.Clear();
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (Player.plX == j && Player.plY == i)
                        Console.Write(Player.pl);
                    else
                        Console.Write(field[i, j]);
                }

                Console.WriteLine();
            }
        }

    }
}