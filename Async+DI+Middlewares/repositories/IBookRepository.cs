using async_DI_middlewares.models;

namespace async_DI_middlewares.repositories
{
    public interface IBookRepository
    {
        Task<int> AddBookAsync(Book book);
        Task<int> SetBookTitleAsync(int id, string title);
    }
}
