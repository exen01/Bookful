using Bookful.dao.book;
using Bookful.dao.issuedBook;
using Bookful.domain.dto;
using Bookful.domain.exception;

namespace Bookful.service.book
{
    public class BookServiceImpl : IBookService
    {
        private readonly IBookDao bookDao;
        private readonly IIssuedBookDao issuedBookDao;

        public BookServiceImpl(IBookDao bookDao, IIssuedBookDao issuedBookDao)
        {
            this.bookDao = bookDao;
            this.issuedBookDao = issuedBookDao;
        }

        public void AddBook(Book book)
        {
            bookDao.AddBook(book);
        }

        public List<Book> GetAllBooks()
        {
            return bookDao.GetAllBooks();
        }

        public Book GetBookById(int id)
        {
            var result = bookDao.GetBookById(id);
            if (result == null)
            {
                return new Book();
            }
            return result;
        }

        public void UpdateBook(Book book)
        {
            bookDao.UpdateBook(book);
        }

        public void DeleteBook(int id)
        {
            if (IsBookReturned(id))
            {
                bookDao.DeleteBook(id);
            }
            else
            {
                throw new CommonException(domain.constant.Code.BOOK_IS_NOT_RETURNED, "Книга еще не возвращена");
            }
            
        }

        public bool IsBookReturned(int bookId)
        {
            bool result = true;
            List<IssuedBook> issuedBooks = issuedBookDao.GetByBookId(bookId);
            foreach(var issuedBookItem in issuedBooks)
            {
                if(issuedBookItem.ReturnDate == null)
                {
                    result = false;
                }
            }

            return result;
        }

        public List<Book> SearchBooks(string searchText)
        {
            return bookDao.SearchBooks(searchText);
        }

        public string GetBookNameAndYearById(int id)
        {
            string bookName = bookDao.GetBookNameAndYearById(id);
            if (string.IsNullOrEmpty(bookName))
            {
                return string.Format("Книга с id: {0} не найдена.", id);
            }

            return bookName;
        }

        public bool CheckBookAvailability(int bookId, int quantity)
        {
            Book book = GetBookById(bookId); // Получаем книгу по id
            int availableQuantity = book.Quantity - issuedBookDao.GetIssuedBookQuantity(bookId); // Вычисляем остаток книг
            return quantity <= availableQuantity; // Сравниваем запрашиваемое количество с остатком
        }
    }
}
