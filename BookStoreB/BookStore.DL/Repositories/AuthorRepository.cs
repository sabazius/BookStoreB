using BookStore.DL.InMemoryDb;
using BookStore.DL.Interfaces;
using BookStore.Models.Data;

namespace BookStore.DL.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        public IEnumerable<Author> GetAll()
        {
            return DataStore.Authors;
        }

        public Author GetById(int id)
        {
            return DataStore.Authors
                .FirstOrDefault(author => author.Id == id);
        }

        public void AddAuthor(Author author)
        {
            DataStore.Authors.Add(author);
        }

        public void DeleteAuthor(int id)
        {
            var author = GetById(id);
            if (author != null)
            {
                DataStore.Authors.Remove(author);
            }
        }
    }
}
