using Bookful.domain.dto;

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
    }
}
