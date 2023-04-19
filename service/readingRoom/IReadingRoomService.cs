using Bookful.domain.dto;

namespace Bookful.service.readingRoom
{
    public interface IReadingRoomService
    {
        bool AddReadingRoom(ReadingRoom readingRoom);
        List<ReadingRoom> GetAllReadingRooms();
        ReadingRoom? GetReadingRoomById(int id);
        bool UpdateReadingRoom(ReadingRoom readingRoom);
        bool DeleteReadingRoomById(int id);
        ReadingRoom? GetReadingRoomByNumber(int number);
        bool IsReadingRoomNumberUnique(int number);
        List<ReadingRoom> SearchReadingRooms(string searchText);
    }
}
