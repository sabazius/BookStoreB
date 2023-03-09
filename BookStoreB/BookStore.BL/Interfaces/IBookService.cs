using BookStore.Models.Data;
using BookStore.Models.Request;

namespace BookStore.BL.Interfaces
{
    public interface IBookService
    {
        IEnumerable<Book> GetAll();

        Book GetById(int id);

        void Add(AddBookRequest author);

        void Delete(int id);
    }
}
