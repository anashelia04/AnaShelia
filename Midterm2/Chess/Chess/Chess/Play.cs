using Chess.Enums;
using Chess.Models;

namespace Chess;

public class Play
{
    private readonly Board _board = new();

    public void PlayGame()
    {
        while (!_board.IsGameOver)
        {
            _board.DisplayBoard();
            Console.WriteLine($"\n{_board.CurrentTurn}'s turn");
            if (_board.IsKingInCheck(_board.CurrentTurn))
            {
                Console.WriteLine($"{_board.CurrentTurn} is in check!");
            }

            Console.Write("Enter: where to move from and where to move to (or quit): ");
            string input = Console.ReadLine();

            if (input?.ToLower() == "quit")
                break;

            if (input?.Length != 5)
            {
                Console.WriteLine("Invalid input format. Please use format 'e1 e2'");
                continue;
            }

            Position? from = ParsePosition(input.Substring(0, 2));
            Position? to = ParsePosition(input.Substring(3, 2));

            if (from is null || to is null)
            {
                Console.WriteLine("Invalid position format! Try again");
                continue;
            }

            if (!_board.MovePiece(from, to))
            {
                Console.WriteLine("Invalid move! Please Try again.");
            }
        }

        if (_board.IsGameOver)
        {
            _board.DisplayBoard();
            Color winner = _board.CurrentTurn;
            Console.WriteLine($"\nCheckmate! {winner} wins!");
        }
        else
        {
            Console.WriteLine("\nGame ended ");
        }
    }

    private static Position? ParsePosition(string pos)
    {
        if (pos.Length != 2)
            return null;

        try
        {
            int column = char.ToLower(pos[0]) - 'a';
            int row = 8 - (pos[1] - '0');

            if (row is >= 0 and < 8 && column is >= 0 and < 8)
            {
                return new Position(row, column);
            }
        }
        catch
        {
            return null;
        }

        return null;
    }
}