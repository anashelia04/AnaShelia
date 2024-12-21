using Chess.Enums;

namespace Chess.Models.Pieces;

public class Bishop : Piece
{
    public Bishop(Color color, Position position) : base(color, position)
    {
        Type = PieceType.Bishop;
    }

    public override List<Position> GetPossibleMoves(Board board, bool checkKingSafety = true)
    {
        List<Position> moves = [];

        moves.AddRange(GetMovesInDirection(board, 1, 1));
        moves.AddRange(GetMovesInDirection(board, 1, -1));
        moves.AddRange(GetMovesInDirection(board, -1, 1));
        moves.AddRange(GetMovesInDirection(board, -1, -1));

        if (checkKingSafety)
        {
            moves = moves.Where(move => !board.WouldMoveExposeKing(Position, move, Color)).ToList();
        }

        return moves;
    }
}