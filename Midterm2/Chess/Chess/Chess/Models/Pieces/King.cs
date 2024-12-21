using Chess.Enums;

namespace Chess.Models.Pieces;

public class King : Piece
{
    public King(Color color, Position position) : base(color, position)
    {
        Type = PieceType.King;
    }

    public override List<Position> GetPossibleMoves(Board board, bool checkKingSafety = true)
    {
        List<Position> moves = [];
        int[][] kingMoves =
        [
            [-1, -1], [-1, 0], [-1, 1],
            [0, -1], [0, 1],
            [1, -1], [1, 0], [1, 1]
        ];

        foreach (var move in kingMoves)
        {
            Position newPos = new Position(Position.Row + move[0], Position.Column + move[1]);
            
            if (!newPos.IsValid()) continue;
            
            Piece? piece = board.GetPiece(newPos);
            if (piece is null || piece.Color != Color)
            {
                if (!checkKingSafety || !board.IsPositionUnderAttack(newPos, Color))
                {
                    moves.Add(newPos);
                }
            }
        }

        if (!HasMoved && checkKingSafety && !board.IsKingInCheck(Color))
        {
            Position kingsideRookPos = new Position(Position.Row, 7);
            Piece? kingsideRook = board.GetPiece(kingsideRookPos);
            

            Position queensideRookPos = new Position(Position.Row, 0);
            Piece? queensideRook = board.GetPiece(queensideRookPos);
            
        }

        return moves;
    }
}