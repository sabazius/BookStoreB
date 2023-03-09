using BookStore.Models.Data;

namespace BookStore.DL.Interfaces
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAll();

        Book GetById(int id);

        void Add(Book author);

        void Delete(int id);
    }
}
