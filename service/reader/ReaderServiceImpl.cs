using Bookful.dao.reader;
using Bookful.domain.dto;
using Bookful.util.db;

namespace Bookful.service.reader
{
    public class ReaderServiceImpl : IReaderService
    {
        private readonly IReaderDao readerDao;

        public ReaderServiceImpl(DBConnection connection)
        {
            this.readerDao = new ReaderDaoImpl(connection);
        }

        public bool AddReader(Reader reader)
        {
            return readerDao.AddReader(reader);
        }

        public bool DeleteReaderById(int id)
        {
            return readerDao.DeleteReaderById(id);
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

        public bool UpdateReader(Reader reader)
        {
            return readerDao.UpdateReader(reader);
        }
    }
}
