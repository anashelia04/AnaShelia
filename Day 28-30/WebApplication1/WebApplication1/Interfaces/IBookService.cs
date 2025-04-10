using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface IBookService
    {
        IEnumerable<Book> GetBooks();
        Book GetBook(int id);
    }
}
