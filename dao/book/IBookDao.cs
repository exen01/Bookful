﻿using Bookful.domain.dto;

namespace Bookful.dao.book
{
    public interface IBookDao
    {
        void AddBook(Book book);
        void DeleteBook(int bookId);
        List<Book> GetAllBooks();
        Book? GetBookById(int id);
        Book? GetBookByTitleAndYear(string title, int year);
        void UpdateBook(Book book);
        List<Book> SearchBooks(string searchText);
        string GetBookNameAndYearById(int id);
        public void DecrementBookCount(int bookId);
        void IncreaseBookCount(int bookId);
        List<string> GetAllAuthors();
        List<string> GetAllPublishingHouses();
    }
}
