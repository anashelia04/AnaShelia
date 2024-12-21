using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    public class BookNameComparer : IComparer<Book>
    {
        public int Compare(Book? x, Book? y)
        {
            return string.Compare(x.BookName, y.BookName, StringComparison.Ordinal);
        }
    }
}
