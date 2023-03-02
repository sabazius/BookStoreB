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
    }
}