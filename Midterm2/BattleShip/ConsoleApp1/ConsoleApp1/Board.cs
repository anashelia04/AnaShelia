using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class Board
    {
        Ship[,] board1 = new Ship[10, 10];
        Ship[,] board2 = new Ship[10, 10];
        public void CreateBoard1()
        {
            Console.WriteLine("First Player's Board: ");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    board1[i, j] = new Ship("#");
                    Console.Write(board1[i, j].Name + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Second Player's Board: ");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    board2[i, j] = new Ship("#");
                    Console.Write(board2[i, j].Name + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Player 1 Choose which ship to place on the board: ");
                Console.WriteLine("Choose 1 for Aircraft Carier ");
                Console.WriteLine("Choose 2 for Battleship");
                Console.WriteLine("Choose 3 for Cruiser");
                Console.WriteLine("Choose 4 for Submarine");
                Console.WriteLine("Choose 5 for Destroyer");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Enter where you want to place the Aircraft Carier "); //a1 a5 formati
                        AircraftCarrier aircraft = new AircraftCarrier(new Position(input1, input2), name);


                        break;
                    case "2":
                        Console.WriteLine("Enter where you want to place the Battleship ");
                        string input2 = Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Enter where you want to place the Cruiser ");
                        string input3 = Console.ReadLine();
                        break;
                    case "4":
                        Console.WriteLine("Enter where you want to place the Submarine ");
                        string input4 = Console.ReadLine();
                        break;
                    case "5":
                        Console.WriteLine("Enter where you want to place the Destroyer ");
                        string input5 = Console.ReadLine();
                        break;

                }



            }
        }
    }
}
