using async_DI_middlewares.models;
using async_DI_middlewares.serices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace async_DI_middlewares.Controllers
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

        [HttpPost]
        public async Task<int> AddBook(Book book)
        {
            return await _bookService.AddBookAsync(book);

        }
        [HttpPatch("{id}/title")]
        public async Task<int> SetBookTitle(int id, [FromBody] string title)
        {
            return await _bookService.SetBookTitleAsync(id, title);
        }

    }
}
