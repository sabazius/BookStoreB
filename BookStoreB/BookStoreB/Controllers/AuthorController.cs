using BookStore.BL.Interfaces;
using BookStore.Models.Data;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreB.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet("GetAll")]
        public IEnumerable<Author> GetAll()
        {
            return _authorService.GetAll();
        }

        [HttpGet("GetById")]
        public Author GetById(int id)
        {
            return _authorService.GetById(id);
        }

        [HttpPost("Add")]
        public void Add([FromBody]Author author)
        {
            _authorService.AddAuthor(author);
        }

        [HttpDelete("Delete")]
        public void Delete(int authorId)
        {
            _authorService.DeleteAuthor(authorId);
        }
    }
}