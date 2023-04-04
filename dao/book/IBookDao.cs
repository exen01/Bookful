using Bookful.domain.dto;

namespace Bookful.dao.book
{
    public interface IBookDao
    {
        void AddBook(Book book);
        void DeleteBook(int bookId);
        List<Book> GetAllBooks();
        Book? GetBookById(int id);
        void UpdateBook(Book book);
    }
}
