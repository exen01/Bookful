using Bookful.domain.dto;

namespace Bookful.dao.book
{
    public interface IBookDao
    {
        void InsertNewBook(Book book);
        void DeleteBook(int bookId);
        List<Book> GetAllBooks();
    }
}
