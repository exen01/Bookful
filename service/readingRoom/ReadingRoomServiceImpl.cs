using Bookful.dao.readingRoom;
using Bookful.domain.dto;
using Bookful.util.db;

namespace Bookful.service.readingRoom
{
    public class ReadingRoomServiceImpl : IReadingRoomService
    {
        private readonly IReadingRoomDao readingRoomDao;

        public ReadingRoomServiceImpl(DBConnection connection)
        {
            this.readingRoomDao = new ReadingRoomDaoImpl(connection);
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
            return readingRoomDao.DeleteReadingRoomById(id);
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
