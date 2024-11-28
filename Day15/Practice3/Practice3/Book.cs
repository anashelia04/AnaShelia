using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    public class Book
    {
        public string FullName { get; set; }
        public int ReleaseYear { get; set; }
        public string BookName { get; set; }
        public string ISBN { get; set; }
        public Genre BookGenre { get; set; }
        public Book( string bookName, string fullName, int releaseYear, Genre bookGenre, string isbn)
        {
            this.FullName = fullName;
            this.BookName = bookName;
            this.ReleaseYear = releaseYear;
            this.ISBN = isbn;
            this.BookGenre = bookGenre;
        }
        public enum Genre
        {
            Fantasy,
            Fiction,
            Horror,
            Mystery,
            Romance,
            Thriller,
            Realism
        }

    }
}
