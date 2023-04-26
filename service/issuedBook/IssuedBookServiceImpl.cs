using Bookful.dao.issuedBook;
using Bookful.domain.dto;

namespace Bookful.service.issuedBook
{
    public class IssuedBookServiceImpl : IIssuedBookService
    {
        private readonly IIssuedBookDao issuedBookDao;

        public IssuedBookServiceImpl(IIssuedBookDao issuedBookDao)
        {
            this.issuedBookDao = issuedBookDao;
        }

        public bool AddIssueBook(IssuedBook issuedBook)
        {
            try
            {
                issuedBookDao.AddIssueBook(issuedBook);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool DeleteIssueBookById(int id)
        {
            try
            {
                issuedBookDao.DeleteIssueBook(id);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool UpdateIssueBook(IssuedBook issuedBook)
        {
            try
            {
                issuedBookDao.UpdateIssueBook(issuedBook);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public List<IssuedBook> GetAll()
        {
            return issuedBookDao.GetAll();
        }

        public List<IssuedBook> GetByBookId(int bookId)
        {
            return issuedBookDao.GetByBookId(bookId);
        }

        public IssuedBook GetById(int id)
        {
            IssuedBook? issuedBook = issuedBookDao.GetById(id);
            if (issuedBook == null)
            {
                return new IssuedBook();
            }

            return issuedBook;
        }

        public List<IssuedBook> GetByReaderId(int readerId)
        {
            return issuedBookDao.GetByReaderId(readerId);
        }

        public List<IssuedBook> SearchIssuedBooks(string searchText)
        {
            return issuedBookDao.SearchIssuedBooks(searchText);
        }
    }
}
