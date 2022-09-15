using LibraryAPI.Models;

namespace LibraryAPI.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetByAll();
        Book Add(Book newBook);
        Book GetByID(Guid id);
        
        void Remove (Guid id);

    }
}
