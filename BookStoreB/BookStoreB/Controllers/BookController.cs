using BookStore.BL.Interfaces;
using BookStore.Models.Data;
using BookStore.Models.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("GetAll")]
        public IEnumerable<Book> GetAll()
        {
            return _bookService.GetAll();
        }

        [HttpGet("GetById")]
        public Book GetById(int id)
        {
            return _bookService.GetById(id);
        }

        [HttpPost("Add")]
        public void Add([FromBody] AddBookRequest book)
        {
            _bookService.Add(book);
        }

        [HttpDelete("Delete")]
        public void Delete(int bookId)
        {
            _bookService.Delete(bookId);
        }
    }
}
