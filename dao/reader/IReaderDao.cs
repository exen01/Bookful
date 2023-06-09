﻿using Bookful.domain.dto;

namespace Bookful.dao.reader
{
    public interface IReaderDao
    {
        Reader? GetReaderById(int id);
        Reader? GetReaderByLibraryCardNumber(int cardNumber);
        List<Reader> GetAllReaders();
        bool AddReader(Reader reader);
        bool DeleteReaderById(int id);
        bool UpdateReader(Reader reader);
        string GetReaderFullNameById(int id);
        List<Reader> SearchReaders(string searchText);
        List<Reader> GetReadersByReadingRoomId(int readingRoomId);
    }
}
