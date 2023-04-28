using Bookful.dao.issuedBook;
using Bookful.dao.reader;
using Bookful.domain.dto;
using Bookful.domain.exception;
using Bookful.util.db;

namespace Bookful.service.reader
{
    public class ReaderServiceImpl : IReaderService
    {
        private readonly IReaderDao readerDao;
        private readonly IIssuedBookDao issuedBookDao;

        public ReaderServiceImpl(IReaderDao readerDao, IIssuedBookDao issuedBookDao)
        {
            this.readerDao = readerDao;
            this.issuedBookDao = issuedBookDao;
        }

        public bool AddReader(Reader reader)
        {
            return readerDao.AddReader(reader);
        }

        public bool DeleteReaderById(int id)
        {
            bool result = false;
            if (HasReaderUnreturnedBooks(id))
            {
                throw new CommonException(domain.constant.Code.READER_NOT_RETURNED_BOOK, "У читателя есть невозвращенные книги");
            }
            else
            {
                result = readerDao.DeleteReaderById(id);
            }

            return result;
        }

        public List<Reader> GetAllReaders()
        {
            return readerDao.GetAllReaders();
        }

        public Reader GetReaderById(int id)
        {
            var reader = readerDao.GetReaderById(id);
            if (reader == null)
            {
                return new Reader();
            }
            return reader;
        }

        public Reader GetReaderByLibraryCardNumber(int cardNumber)
        {
            var reader = readerDao.GetReaderByLibraryCardNumber(cardNumber);
            if (reader == null)
            {
                return new Reader();
            }
            return reader;
        }

        public string GetReaderFullNameById(int id)
        {
            string fullName = readerDao.GetReaderFullNameById(id);
            if (string.IsNullOrEmpty(fullName))
            {
                return "Читатель не найден.";
            }
            return fullName;
        }

        public bool HasReaderUnreturnedBooks(int id)
        {
            bool result = false;
            List<IssuedBook> issuedBooks = issuedBookDao.GetByReaderId(id);
            foreach (var issuedBookItem in issuedBooks)
            {
                if (issuedBookItem.ReturnDate == null)
                {
                    result = true;
                }
            }

            return result;
        }

        public List<Reader> SearchReaders(string searchText)
        {
            return readerDao.SearchReaders(searchText);
        }

        public bool UpdateReader(Reader reader)
        {
            return readerDao.UpdateReader(reader);
        }
    }
}
