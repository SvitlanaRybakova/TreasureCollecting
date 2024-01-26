using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreasureCollecting
{
    internal class Program
    {
        private static int userX = 6;
        private static int userY = 6;
        static void Main(string[] args)
        {
            char[,] gameMap ={
                {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#','#'},
                {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ','#'},
                {'#', 'X', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ','#'},
                {'#', ' ', ' ', '#', '#', '#', '#', '#', '#', '#', '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ',' ', ' ', ' ', '#'},
                {'#', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#', '#', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ',' ', ' ', ' ', '#'},
                {'#', ' ', ' ', '#', ' ', 'X', ' ', ' ', ' ', 'X', ' ', '#', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', 'X', ' ', ' ', ' ','#'},
                {'#', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ','#'},
                {'#', ' ', ' ', '#', '#', '#', '#', '#', '#', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ','#'},
                {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', '#', '#', '#', ' ', ' ', ' ', ' ', ' ', '#', ' ',' ', ' ', ' ', '#'},
                {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ','#'},
                {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#', ' ',' ', ' ', ' ', '#'},
                {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', '#', ' ', ' ', '#', ' ', ' ', '#', ' ', ' ', ' ', ' ','#'},
                {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', 'X', '#', ' ', ' ', ' ', ' ','#'},
                {'#', ' ', '#', '#', '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', '#', ' ',' ', ' ', ' ', '#'},
                {'#', ' ', ' ', ' ', '#', ' ', 'X', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', '#', ' ', ' ', ' ', ' ','#'},
                {'#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ','#'},
                {'#', ' ', ' ', ' ', '#', '#', '#', '#', '#', ' ', 'X', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ','#'},
                {'#', 'X', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'X', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', 'X', ' ','#'},
                {'#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ','#'},
                {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#','#', '#', '#', '#'},
            };

            char[] bag = new char[1];

            while (true)
            {
                Console.SetCursorPosition(0, 23);
                Console.Write("Collected tresure: ");

                for (int i=0; i<bag.Length; i++)
                {
                    Console.Write(bag[i] + " ");
                }

                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < gameMap.GetLength(0); i++)
                {
                    for (int j = 0; j < gameMap.GetLength(1); j++)
                    {
                        Console.Write(gameMap[i, j]);
                    }
                    Console.WriteLine();
                }

                Console.SetCursorPosition(userY, userX); 
                Console.Write("@");

                ConsoleKeyInfo charKey = Console.ReadKey(true);

                switch (charKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (userX - 1 >= 0 && gameMap[userX - 1, userY] != '#')
                        {
                            userX--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (userX + 1 < gameMap.GetLength(0) && gameMap[userX + 1, userY] != '#')
                        {
                            userX++;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (userY - 1 >= 0 && gameMap[userX, userY - 1] != '#')
                        {
                            userY--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (userY + 1 < gameMap.GetLength(1) && gameMap[userX, userY + 1] != '#')
                        {
                            userY++;
                        }
                        break;
                    case ConsoleKey.Escape:
                        Console.CursorVisible = true; 
                        return; 
                }

                if (gameMap[userX, userY] == 'X')
                {
                    gameMap[userX, userY] = ' ';
                    char[] tempBag = new char[bag.Length + 1];

                    for (int i = 0; i < bag.Length; i++)
                    {
                        tempBag[i] = bag[i];
                    }

                    tempBag[bag.Length] = 'X';
                    bag = tempBag;
                }

                Console.Clear();
            }


        }
    }
}
