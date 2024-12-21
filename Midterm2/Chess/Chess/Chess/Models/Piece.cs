using Chess.Enums;

namespace Chess.Models;

public abstract class Piece(Color color, Position position)
{
    public Color Color { get; } = color;
    public Position Position { get; set; } = position;
    public PieceType Type { get; protected init; }
    public bool HasMoved { get; set; }

    public abstract List<Position> GetPossibleMoves(Board board, bool checkKingSafety = true);
        
    protected List<Position> GetMovesInDirection(Board board, int rowDirection, int colDirection)
    {
        List<Position> moves = [];
        int row = Position.Row + rowDirection;
        int col = Position.Column + colDirection;

        while (row is >= 0 and < 8 && col is >= 0 and < 8)
        {
            Position newPos = new Position(row, col);
            if (board.GetPiece(newPos) is null)
            {
                moves.Add(newPos);
            }
            else if (board.GetPiece(newPos)?.Color != Color)
            {
                moves.Add(newPos);
                break;
            }
            else
            {
                break;
            }
            row += rowDirection;
            col += colDirection;
        }

        return moves;
    }
}