namespace Chess.Models;

public class Position(int row, int column)
{
    public int Row { get; set; } = row;
    public int Column { get; set; } = column;

    public bool IsValid()
    {
        return Row is >= 0 and < 8 && Column is >= 0 and < 8;
    }
}