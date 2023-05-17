using Bookful.domain.dto;

namespace Bookful.service.book
{
    public interface IBookService
    {
        void AddBook(Book book);
        List<Book> GetAllBooks();
        Book GetBookById(int id);
        Book GetBookByTitleAndYear(string title, int year);
        void UpdateBook(Book book);
        void DeleteBook(int id);
        List<Book> SearchBooks(string searchText);
        string GetBookNameAndYearById(int id);
        bool IsBookReturned(int bookId);
        bool CheckBookAvailability(int bookId, int quantity);
        List<string> GetAllAuthors();
        List<string> GetAllPublishingHouses();
    }
}
