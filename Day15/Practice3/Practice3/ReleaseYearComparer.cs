using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    public class ReleaseYearComparer : IComparer<Book>
    {
        public int Compare(Book? x, Book? y)
        {
            return x.ReleaseYear.CompareTo(y.ReleaseYear);
        }

    }
}
