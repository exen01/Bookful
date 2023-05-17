using Bookful.domain.dto;

namespace Bookful.service.issuedBook
{
    public interface IIssuedBookService
    {
        IssuedBook GetById(int id);
        List<IssuedBook> GetAll();
        List<IssuedBook> GetByReaderId(int readerId);
        List<IssuedBook> GetByBookId(int bookId);
        List<IssuedBook> GetUreturnedBooks();
        bool AddIssueBook(IssuedBook issuedBook);
        bool UpdateIssueBook(IssuedBook issuedBook);
        bool DeleteIssueBookById(int id);
        List<IssuedBook> SearchIssuedBooks(string searchText);
    }
}
