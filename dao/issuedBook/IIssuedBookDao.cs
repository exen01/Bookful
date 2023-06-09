﻿using Bookful.domain.dto;

namespace Bookful.dao.issuedBook
{
    public interface IIssuedBookDao
    {
        IssuedBook? GetById(int id);
        List<IssuedBook> GetAll();
        List<IssuedBook> GetByReaderId(int readerId);
        List<IssuedBook> GetByBookId(int bookId);
        List<IssuedBook> GetUreturnedBooks();
        void AddIssueBook(IssuedBook issuedBook);
        void UpdateIssueBook(IssuedBook issuedBook);
        void DeleteIssueBook(int id);
        List<IssuedBook> SearchIssuedBooks(string searchText);
        int GetIssuedBookQuantity(int bookId);
    }
}
