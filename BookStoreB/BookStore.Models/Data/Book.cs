namespace BookStore.Models.Data
{
    public class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int AuthorId { get; set; }

        public string Description { get; set; }
    }
}
