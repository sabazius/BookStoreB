using BookStore.Models.Data;

namespace BookStore.DL.InMemoryDb
{
    public static class DataStore
    {
        public static List<Author> Authors
            = new List<Author>()
            {
                new Author()
                {
                    Id = 1,
                    Name = "Gosho",
                    Bio = "Gosho bio"
                },
                new Author()
                {
                    Id = 2,
                    Name = "Ginka",
                    Bio = "Ginka bio"
                }
            };

    }
}
