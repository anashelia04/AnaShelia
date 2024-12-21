using Chess.Enums;

namespace Chess.Models.Pieces;

public class Pawn : Piece
{
    public bool IsEnPassantTarget { get; set; }

    public Pawn(Color color, Position position) : base(color, position)
    {
        Type = PieceType.Pawn;
        IsEnPassantTarget = false;
    }

    public override List<Position> GetPossibleMoves(Board board, bool checkKingSafety = true)
    {
        List<Position> moves = new List<Position>();
        int direction = Color == Color.White ? -1 : 1;

        Position oneStep = new Position(Position.Row + direction, Position.Column);
        if (oneStep.IsValid() && board.GetPiece(oneStep) is null)
        {
            moves.Add(oneStep);

            if (!HasMoved)
            {
                Position twoSteps = new Position(Position.Row + (2 * direction), Position.Column);
                if (twoSteps.IsValid() && board.GetPiece(twoSteps) is null)
                {
                    moves.Add(twoSteps);
                }
            }
        }

        for (int i = -1; i <= 1; i += 2)
        {
            Position capturePos = new Position(Position.Row + direction, Position.Column + i);
            if (capturePos.IsValid())
            {
                Piece? piece = board.GetPiece(capturePos);
                if (piece != null && piece.Color != Color)
                {
                    moves.Add(capturePos);
                }
            }
        }

        if (Position.Row == (Color == Color.White ? 3 : 4))
        {
            for (int i = -1; i <= 1; i += 2)
            {
                Position adjacentPos = new Position(Position.Row, Position.Column + i);
                if (adjacentPos.IsValid())
                {
                    Piece? adjacentPiece = board.GetPiece(adjacentPos);
                    if (adjacentPiece is Pawn pawn && pawn.Color != Color && pawn.IsEnPassantTarget)
                    {
                        moves.Add(new Position(Position.Row + direction, Position.Column + i));
                    }
                }
            }
        }

        if (checkKingSafety)
        {
            moves = moves.Where(move => !board.WouldMoveExposeKing(Position, move, Color)).ToList();
        }

        return moves;
    }
}