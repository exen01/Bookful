using Bookful.dao.reader;
using Bookful.dao.readingRoom;
using Bookful.domain.dto;
using Bookful.domain.exception;
using Bookful.util.db;

namespace Bookful.service.readingRoom
{
    public class ReadingRoomServiceImpl : IReadingRoomService
    {
        private readonly IReadingRoomDao readingRoomDao;
        private readonly IReaderDao readerDao;

        public ReadingRoomServiceImpl(IReadingRoomDao readingRoomDao, IReaderDao readerDao)
        {
            this.readerDao = readerDao;
            this.readingRoomDao = readingRoomDao;
        }

        public bool AddReadingRoom(ReadingRoom readingRoom)
        {
            if (!IsReadingRoomNumberUnique(readingRoom.Number))
            {
                return false;
            }

            return readingRoomDao.AddReadingRoom(readingRoom);
        }

        public bool DeleteReadingRoomById(int id)
        {
            bool result = false;
            if (HasReadingRoomReaders(id))
            {
                throw new CommonException(domain.constant.Code.READING_ROOM_HAS_READERS, "Невозможно удалить данный читальный зал, так как в нем зарегистрированы читатели. Перед удалением необходимо удалить всех читателей, зарегистрированных в данном зале.");
            }
            else
            {
                result = readingRoomDao.DeleteReadingRoomById(id);
            }
            return result;
        }

        public List<ReadingRoom> GetAllReadingRooms()
        {
            return readingRoomDao.GetAllReadingRooms();
        }

        public ReadingRoom GetReadingRoomById(int id)
        {
            var result = readingRoomDao.GetReadingRoomById(id);
            if (result == null)
            {
                return new ReadingRoom();
            }
            return result;
        }

        public ReadingRoom GetReadingRoomByNumber(int number)
        {
            return readingRoomDao.GetReadingRoomByNumber(number);
        }

        public int GetReadingRoomNumberById(int id)
        {
            return readingRoomDao.GetReadingRoomNumberById(id);
        }

        public bool HasReadingRoomReaders(int readingRoomId)
        {
            List<Reader> readers = readerDao.GetReadersByReadingRoomId(readingRoomId);
            if (readers.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool IsReadingRoomNumberUnique(int number)
        {
            // Проверка на уникальность номера читального зала
            ReadingRoom existingReadingRoom = readingRoomDao.GetReadingRoomByNumber(number);
            return existingReadingRoom == null; // Если читальный зал с таким номером не найден, то номер уникален
        }

        public List<ReadingRoom> SearchReadingRooms(string searchText)
        {
            return readingRoomDao.SearchReadingRooms(searchText);
        }

        public bool UpdateReadingRoom(ReadingRoom readingRoom)
        {
            if (!IsReadingRoomNumberUnique(readingRoom.Number))
            {
                return false;
            }

            return readingRoomDao.UpdateReadingRoom(readingRoom);
        }
    }
}
