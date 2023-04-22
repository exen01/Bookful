using Bookful.domain.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookful.service.book
{
    public interface IBookService
    {
        void AddBook(Book book);
        List<Book> GetAllBooks();
        Book GetBookById(int id);
        void UpdateBook(Book book);
        void DeleteBook(int id);
        List<Book> SearchBooks(string searchText);
    }
}
