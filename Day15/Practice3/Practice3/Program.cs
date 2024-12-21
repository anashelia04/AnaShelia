using Practice3;


List<Book> books = new List<Book>
{
    new Book("Flowers For Algernon", "Daniel Keyes", 1966, Book.Genre.Fiction, "123-123-123"),
    new Book("1984", "George Orwell", 1949, Book.Genre.Fiction, "000-000-000"),
    new Book("The Catcher In The Rye", "J.D. Salinger", 1951, Book.Genre.Realism, "999-999-999"),
    new Book("After Dark", "Haruki Murakami", 2004, Book.Genre.Fiction, "123-456-789")
};

books.Sort(new ReleaseYearComparer());
books.Sort(new BookNameComparer());
books.Sort(new ISBNComparer());

foreach (var book in books)
{
    Console.WriteLine($"{book.FullName}, {book.BookName}, {book.ReleaseYear}, {book.ISBN}, {book.BookGenre}");
}
