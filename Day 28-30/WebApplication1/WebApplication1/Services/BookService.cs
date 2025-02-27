using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class BookService : IBookService
    {
        private readonly List<Book> books = new()
    {
        new Book { Id = 1, Title = "The Catcher in the Rye", Author = "J.D. Salinger", YearPublished = 1951 },
        new Book { Id = 2, Title = "Harry Potter and the Sorcerer's Stone", Author = "J.K. Rowling", YearPublished = 1997 },
        new Book { Id = 3, Title = "Harry Potter and the Half Blood Prince", Author = "J.K. Rowling", YearPublished = 2005 }
    };

        public IEnumerable<Book> GetBooks() => books;
        public Book GetBook(int id) => books.FirstOrDefault(b => b.Id == id);
    }
}
