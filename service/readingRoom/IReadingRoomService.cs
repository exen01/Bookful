using Bookful.domain.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookful.service.readingRoom
{
    public interface IReadingRoomService
    {
        bool AddReadingRoom(ReadingRoom readingRoom);
        List<ReadingRoom> GetAllReadingRooms();
        ReadingRoom? GetReadingRoomById(int id);
        bool UpdateReadingRoom(ReadingRoom readingRoom);
        bool DeleteReadingRoomById(int id);
    }
}
