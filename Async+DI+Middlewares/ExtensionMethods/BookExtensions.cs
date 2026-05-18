using async_DI_middlewares.models;

namespace async_DI_middlewares.ExtensionMethods
{
    public static class BookExtensions
    {
        public static void setBookTitle(this Book book, string bookTitle)
        {
            book.Title = bookTitle;
        }
    }
}
