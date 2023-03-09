using BookStore.Models.Data;

namespace BookStore.BL.Interfaces
{
    public interface IAuthorService
    {
        IEnumerable<Author> GetAll();

        Author GetById(int id);

        void AddAuthor(Author author);

        void DeleteAuthor(int id);
    }
}
