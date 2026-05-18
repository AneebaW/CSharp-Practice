using async_DI_middlewares.models;
using async_DI_middlewares.repositories;

namespace async_DI_middlewares.serices
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository) 
        {
            _bookRepository = bookRepository;
        }

        public async Task<int> AddBookAsync(Book book)
        {
            return await _bookRepository.AddBookAsync(book);
        }

        public async Task<int> SetBookTitleAsync(int id, string title)
        {
            return await _bookRepository.SetBookTitleAsync(id, title);
        }
    }
}
