using Chess.Enums;
using Chess.Models.Pieces;

namespace Chess.Models;

public class Board
{
    private readonly Piece?[,] _pieces;
    public bool IsGameOver { get; private set; }
    public Color CurrentTurn { get; private set; }

    public Board()
    {
        _pieces = new Piece[8, 8];
        CurrentTurn = Color.White;
        InitializeBoard();
    }

    private void InitializeBoard()
    {
        for (int i = 0; i < 8; i++)
        {
            _pieces[1, i] = new Pawn(Color.Black, new Position(1, i));
            _pieces[6, i] = new Pawn(Color.White, new Position(6, i));
        }
        _pieces[0, 1] = new Knight(Color.Black, new Position(0, 1));
        _pieces[0, 6] = new Knight(Color.Black, new Position(0, 6));
        _pieces[0, 2] = new Bishop(Color.Black, new Position(0, 2));
        _pieces[0, 5] = new Bishop(Color.Black, new Position(0, 5));
        _pieces[0, 4] = new King(Color.Black, new Position(0, 4));

        _pieces[7, 1] = new Knight(Color.White, new Position(7, 1));
        _pieces[7, 6] = new Knight(Color.White, new Position(7, 6));
        _pieces[7, 2] = new Bishop(Color.White, new Position(7, 2));
        _pieces[7, 5] = new Bishop(Color.White, new Position(7, 5));
        _pieces[7, 4] = new King(Color.White, new Position(7, 4));
    }

    public Piece? GetPiece(Position position)
    {
        return _pieces[position.Row, position.Column];
    }

    public bool IsPositionUnderAttack(Position position, Color defendingColor)
    {
        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                Piece? piece = _pieces[row, col];
                if (piece != null && piece.Color != defendingColor)
                {
                    var moves = piece.GetPossibleMoves(this, false);
                }
            }
        }

        return false;
    }

    public bool IsKingInCheck(Color color)
    {
        Position kingPosition = FindKing(color);
        return IsPositionUnderAttack(kingPosition, color);
    }

    private bool IsCheckmate(Color color)
    {
        if (!IsKingInCheck(color))
            return false;

        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                Piece? piece = _pieces[row, col];
                if (piece != null && piece.Color == color)
                {
                    var moves = piece.GetPossibleMoves(this);
                
                    foreach (var move in moves)
                    {
                        var fromPos = piece.Position;
                        var targetPiece = _pieces[move.Row, move.Column];
                    
                        _pieces[move.Row, move.Column] = piece;
                        _pieces[fromPos.Row, fromPos.Column] = null;
                        piece.Position = move;

                        bool stillInCheck = IsKingInCheck(color);

                        _pieces[fromPos.Row, fromPos.Column] = piece;
                        _pieces[move.Row, move.Column] = targetPiece;
                        piece.Position = fromPos;

                        if (!stillInCheck)
                            return false;
                    }
                }
            }
        }

        return true;
    }

    public bool WouldMoveExposeKing(Position from, Position to, Color color)
    {
        Piece? originalPiece = _pieces[to.Row, to.Column];
        Piece? movingPiece = _pieces[from.Row, from.Column];
        _pieces[to.Row, to.Column] = movingPiece;
        _pieces[from.Row, from.Column] = null;

        Position kingPos = movingPiece is { Type: PieceType.King } ? to : FindKing(color);
        bool wouldBeInCheck = IsPositionUnderAttack(kingPos, color);

        _pieces[from.Row, from.Column] = movingPiece;
        _pieces[to.Row, to.Column] = originalPiece;

        return wouldBeInCheck;
    }

    private Position FindKing(Color color)
    {
       for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                Piece? piece = _pieces[row, col];
                if (piece is King && piece.Color == color)
                {
                    return new Position(row, col);
                }
            }
       }

        throw new Exception("King was not found!");
    }

    public bool MovePiece(Position from, Position to)
    {
        if (!from.IsValid() || !to.IsValid())
            return false;

        Piece? piece = GetPiece(from);
        if (piece is null || piece.Color != CurrentTurn)
            return false;

        List<Position> possibleMoves = piece.GetPossibleMoves(this);
        if (!possibleMoves.Exists(p => p.Row == to.Row && p.Column == to.Column))
            return false;

        if (piece is Pawn pawn)
        {
            foreach (var p in GetAllPieces().OfType<Pawn>())
            {
                p.IsEnPassantTarget = false;
            }

            if (Math.Abs(to.Row - from.Row) == 2)
            {
                pawn.IsEnPassantTarget = true;
            }

            if (Math.Abs(to.Column - from.Column) == 1 && _pieces[to.Row, to.Column] is null)
            {
                _pieces[from.Row, to.Column] = null;
            }
        }

        _pieces[to.Row, to.Column] = piece;
        _pieces[from.Row, from.Column] = null;
        piece.Position = to;
        piece.HasMoved = true;

        Color opposingColor = CurrentTurn == Color.White ? Color.Black : Color.White;
        if (IsCheckmate(opposingColor))
        {
            IsGameOver = true;
            return true;
        }

        CurrentTurn = CurrentTurn == Color.White ? Color.Black : Color.White;

        return true;
    }

    private IEnumerable<Piece?> GetAllPieces()
    {
        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                if (_pieces[row, col] != null)
                {
                    yield return _pieces[row, col];
                }
            }
        }
    }

    public void DisplayBoard()
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Piece? piece = _pieces[i, j];
                if (piece is null)
                    Console.Write("# ");
                else
                {
                    char pieceChar = GetPieceChar(piece);
                    Console.Write($"{pieceChar} ");
                }
            }

            Console.WriteLine();
        }
    }

    private static char GetPieceChar(Piece piece)
    {
        char c = piece.Type switch
        {
            PieceType.Pawn => 'p',
            PieceType.Knight => 'n',
            PieceType.Bishop => 'b',
            PieceType.King => 'k',
        };

        return piece.Color == Color.White ? char.ToUpper(c) : c;
    }
}