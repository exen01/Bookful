using Bookful.domain.dto;

namespace Bookful.dao.readingRoom
{
    public interface IReadingRoomDao
    {
        bool AddReadingRoom(ReadingRoom readingRoom);
        List<ReadingRoom> GetAllReadingRooms();
        ReadingRoom? GetReadingRoomById(int id);
        bool UpdateReadingRoom(ReadingRoom readingRoom);
        bool DeleteReadingRoomById(int id);
    }
}
