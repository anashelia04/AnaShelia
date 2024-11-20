using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter size of the board: ");
            int size = Int32.Parse(Console.ReadLine());
            char[,] board = new char[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }

            
                while ((board[0, 0] != board[0, 1] && board[0, 0] != board[0, 2]) || (board[1, 0] != board[1, 1] && board[1, 0] != board[1, 2]) )
                {
                    Console.WriteLine("Player 1 enter index for X:");
                    int index1 = Int32.Parse(Console.ReadLine());
                    int index2 = Int32.Parse(Console.ReadLine());
                    board[index1, index2] = 'O';


                    Console.WriteLine("Player 2 enter index for O:");
                    int index3 = Int32.Parse(Console.ReadLine());
                    int index4 = Int32.Parse(Console.ReadLine());
                    board[index3, index4] = 'O';
                }
        }
    }
}
