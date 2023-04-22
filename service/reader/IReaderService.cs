using Bookful.domain.dto;

namespace Bookful.service.reader
{
    public interface IReaderService
    {
        Reader GetReaderById(int id);
        Reader GetReaderByLibraryCardNumber(int cardNumber);
        List<Reader> GetAllReaders();
        bool AddReader(Reader reader);
        bool DeleteReaderById(int id);
        bool UpdateReader(Reader reader);
    }
}
