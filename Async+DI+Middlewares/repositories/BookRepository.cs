using async_DI_middlewares.ExtensionMethods;
using async_DI_middlewares.models;

namespace async_DI_middlewares.repositories
{
    public class BookRepository : IBookRepository
    {
        List<Book> books = new List<Book>();
        public async Task<int> AddBookAsync(Book book)
        {
            books.Add(book);
            Console.WriteLine("Books added!" + books[books.Count - 1]);
            await Task.Delay(1000);
            Console.WriteLine("Delay!");
            return books.Count;
        }

        public async Task<int> SetBookTitleAsync(int id, string title)
        {
            var book = books.FirstOrDefault(b => b.BookId == id);
            Console.WriteLine(book);
            if(book != null)
            {
                book.setBookTitle(title);
                return id;
            }
            return 0;
        }

    }
}
