using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Position(int row, int column)
    {
        public int Row { get; set; } = row;
        public int Column { get; set; } = column;

        public bool IsValid()
        {
            return Row is >= 0 and < 10 && Column is >= 0 and < 10;
        }
    }
}
