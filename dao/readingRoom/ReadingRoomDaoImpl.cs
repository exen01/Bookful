using Bookful.domain.dto;
using Bookful.util.db;
using MySql.Data.MySqlClient;

namespace Bookful.dao.readingRoom
{
    public class ReadingRoomDaoImpl : IReadingRoomDao
    {
        private readonly DBConnection connection;

        public ReadingRoomDaoImpl(DBConnection connection)
        {
            this.connection = connection;
        }

        public bool AddReadingRoom(ReadingRoom readingRoom)
        {
            bool result = false;

            if (connection.IsConnect())
            {
                string query = "INSERT INTO reading_room (room_number, specialization, number_of_seats) " +
                    "VALUES (@room_number, @specialization, @number_of_seats)";
                var command = new MySqlCommand(query, connection.Connection);

                command.Parameters.AddWithValue("@room_number", readingRoom.Number);
                command.Parameters.AddWithValue("@specialization", readingRoom.Specialization);
                command.Parameters.AddWithValue("@number_of_seats", readingRoom.SeatsCount);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    result = true;
                }
            }

            return result;
        }

        public bool DeleteReadingRoomById(int id)
        {
            bool result = false;

            if (connection.IsConnect())
            {
                string query = "DELETE FROM reading_room WHERE id = @id";
                var command = new MySqlCommand(query, connection.Connection);
                command.Parameters.AddWithValue("@id", id);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    result = true;
                }
            }

            return result;
        }

        public List<ReadingRoom> GetAllReadingRooms()
        {
            List<ReadingRoom> readingRooms = new List<ReadingRoom>();

            if (connection.IsConnect())
            {
                string query = "SELECT id, room_number, specialization, number_of_seats FROM reading_room;";
                var command = new MySqlCommand(query, connection.Connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ReadingRoom readingRoom = new ReadingRoom()
                        {
                            Id = reader.GetInt32("id"),
                            Number = reader.GetInt32("room_number"),
                            Specialization = reader.GetString("specialization"),
                            SeatsCount = reader.GetInt32("number_of_seats")
                        };
                        readingRooms.Add(readingRoom);
                    }
                }
            }

            return readingRooms;
        }

        public ReadingRoom? GetReadingRoomById(int id)
        {
            ReadingRoom? readingRoom = null;

            if (connection.IsConnect())
            {
                string query = "SELECT * FROM reading_room WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, connection.Connection);
                command.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        readingRoom = new ReadingRoom()
                        {
                            Id = reader.GetInt32("id"),
                            Number = reader.GetInt32("room_number"),
                            Specialization = reader.GetString("specialization"),
                            SeatsCount = reader.GetInt32("number_of_seats")
                        };
                    }
                }
            }

            return readingRoom;
        }

        public ReadingRoom? GetReadingRoomByNumber(int number)
        {
            ReadingRoom? readingRoom = null;

            if (connection.IsConnect())
            {
                string query = "SELECT * FROM reading_room WHERE room_number = @number";
                MySqlCommand command = new MySqlCommand(query, connection.Connection);
                command.Parameters.AddWithValue("@number", number);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        readingRoom = new ReadingRoom()
                        {
                            Id = reader.GetInt32("id"),
                            Number = reader.GetInt32("room_number"),
                            Specialization = reader.GetString("specialization"),
                            SeatsCount = reader.GetInt32("number_of_seats")
                        };
                    }
                }
            }

            return readingRoom;
        }

        public bool UpdateReadingRoom(ReadingRoom readingRoom)
        {
            bool result = false;

            if (connection.IsConnect())
            {
                string query = "UPDATE reading_room SET room_number = @number, specialization = @specialization, number_of_seats = @number_of_seats WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, connection.Connection);
                command.Parameters.AddWithValue("@number", readingRoom.Number);
                command.Parameters.AddWithValue("@specialization", readingRoom.Specialization);
                command.Parameters.AddWithValue("@number_of_seats", readingRoom.SeatsCount);
                command.Parameters.AddWithValue("@id", readingRoom.Id);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
