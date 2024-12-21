using Chess.Enums;

namespace Chess.Models.Pieces;

public class Knight : Piece
{
    public Knight(Color color, Position position) : base(color, position)
    {
        Type = PieceType.Knight;
    }

    public override List<Position> GetPossibleMoves(Board board, bool checkKingSafety = true)
    {
        List<Position> moves = [];
        int[][] knightMoves =
        [
            [-2, -1], [-2, 1],
            [-1, -2], [-1, 2],
            [1, -2], [1, 2],
            [2, -1], [2, 1]
        ];

        foreach (var move in knightMoves)
        {
            Position newPos = new Position(Position.Row + move[0], Position.Column + move[1]);
            
            if (!newPos.IsValid()) continue;
            
            Piece? piece = board.GetPiece(newPos);
            if (piece is null || piece.Color != Color)
            {
                moves.Add(newPos);
            }
        }

        if (checkKingSafety)
        {
            moves = moves.Where(move => !board.WouldMoveExposeKing(Position, move, Color)).ToList();
        }

        return moves;
    }
}