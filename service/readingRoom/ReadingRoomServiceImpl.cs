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

        public bool UpdateReadingRoom(ReadingRoom readingRoom)
        {
            return readingRoomDao.UpdateReadingRoom(readingRoom);
        }
    }
}
