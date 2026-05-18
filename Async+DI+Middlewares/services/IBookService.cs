using async_DI_middlewares.models;

namespace async_DI_middlewares.serices
{
    public interface IBookService
    {
        Task<int> AddBookAsync(Book book);
        Task<int> SetBookTitleAsync(int id, string title);
    }
}
