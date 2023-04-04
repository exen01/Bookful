using Bookful.dao.book;
using Bookful.domain.dto;
using Bookful.util.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookful.service.book
{
    public class BookServiceImpl : IBookService
    {
        private readonly IBookDao bookDao;

        public BookServiceImpl(DBConnection connection)
        {
            bookDao = new BookDaoImpl(connection);
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
            bookDao.DeleteBook(id);
        }
    }
}
