using Bookful.domain.dto;
using Bookful.util.db;
using MySql.Data.MySqlClient;

namespace Bookful.dao.reader
{
    public class ReaderDaoImpl : IReaderDao
    {
        private readonly DBConnection connection;

        public ReaderDaoImpl(DBConnection connection)
        {
            this.connection = connection;
        }

        public bool AddReader(Reader reader)
        {
            bool result = false;

            if (connection.IsConnect())
            {
                string query = "INSERT INTO reader (first_name, last_name, library_card_number, reading_room_id, registration_date) " +
                    "VALUES (@first_name, @last_name, @library_card_number, @reading_room_id, @registration_date)";
                MySqlCommand command = new MySqlCommand(query, connection.Connection);

                command.Parameters.AddWithValue("@first_name", reader.FirstName);
                command.Parameters.AddWithValue("@last_name", reader.LastName);
                command.Parameters.AddWithValue("@library_card_number", reader.LibraryCardNumber);
                command.Parameters.AddWithValue("@reading_room_id", reader.ReadingRoomId);
                command.Parameters.AddWithValue("@registration_date", reader.RegistrationDate.ToString("yyyy-MM-dd"));

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    result = true;
                }
            }

            return result;
        }

        public bool DeleteReaderById(int id)
        {
            bool result = false;

            if (connection.IsConnect())
            {
                string query = "DELETE FROM reader WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, connection.Connection);
                command.Parameters.AddWithValue("@id", id);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    result = true;
                }
            }

            return result;
        }

        public List<Reader> GetAllReaders()
        {
            List<Reader> readers = new List<Reader>();

            if (connection.IsConnect())
            {
                string query = "SELECT id, first_name, last_name, library_card_number, reading_room_id, registration_date " +
                    "FROM reader";
                MySqlCommand command = new MySqlCommand(query, connection.Connection);

                using (MySqlDataReader mysqlReader = command.ExecuteReader())
                {
                    while (mysqlReader.Read())
                    {
                        Reader reader = new Reader()
                        {
                            Id = mysqlReader.GetInt32("id"),
                            FirstName = mysqlReader.GetString("first_name"),
                            LastName = mysqlReader.GetString("last_name"),
                            LibraryCardNumber = mysqlReader.GetInt32("library_card_number"),
                            ReadingRoomId = mysqlReader.GetInt32("reading_room_id"),
                            RegistrationDate = DateOnly.FromDateTime(mysqlReader.GetDateTime("registration_date"))
                        };

                        readers.Add(reader);
                    }
                }
            }

            return readers;
        }

        public Reader? GetReaderById(int id)
        {
            Reader? reader = null;

            if (connection.IsConnect())
            {
                string query = "SELECT id, first_name, last_name, library_card_number, reading_room_id, registration_date " +
                    "FROM reader WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, connection.Connection);
                command.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader mysqlReader = command.ExecuteReader())
                {
                    if (mysqlReader.Read())
                    {
                        reader = new Reader()
                        {
                            Id = mysqlReader.GetInt32("id"),
                            FirstName = mysqlReader.GetString("first_name"),
                            LastName = mysqlReader.GetString("last_name"),
                            LibraryCardNumber = mysqlReader.GetInt32("library_card_number"),
                            ReadingRoomId = mysqlReader.GetInt32("reading_room_id"),
                            RegistrationDate = DateOnly.FromDateTime(mysqlReader.GetDateTime("registration_date"))
                        };
                    }
                }
            }

            return reader;
        }

        public Reader? GetReaderByLibraryCardNumber(int cardNumber)
        {
            Reader? reader = null;

            if (connection.IsConnect())
            {
                string query = "SELECT id, first_name, last_name, library_card_number, reading_room_id, registration_date " +
                    "FROM reader WHERE library_card_number = @library_card_number";
                MySqlCommand command = new MySqlCommand(query, connection.Connection);
                command.Parameters.AddWithValue("@library_card_number", cardNumber);

                using (MySqlDataReader mysqlReader = command.ExecuteReader())
                {
                    if (mysqlReader.Read())
                    {
                        reader = new Reader()
                        {
                            Id = mysqlReader.GetInt32("id"),
                            FirstName = mysqlReader.GetString("first_name"),
                            LastName = mysqlReader.GetString("last_name"),
                            LibraryCardNumber = mysqlReader.GetInt32("library_card_number"),
                            ReadingRoomId = mysqlReader.GetInt32("reading_room_id"),
                            RegistrationDate = DateOnly.FromDateTime(mysqlReader.GetDateTime("registration_date"))
                        };
                    }
                }
            }

            return reader;
        }

        public string GetReaderFullNameById(int id)
        {
            string fullName = "";

            if (connection.IsConnect())
            {
                string query = "SELECT first_name, last_name FROM reader WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, connection.Connection);

                command.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader mysqlReader = command.ExecuteReader())
                {
                    if (mysqlReader.Read())
                    {
                        fullName = string.Format("{0} {1}", mysqlReader.GetString("first_name"), mysqlReader.GetString("last_name"));
                    }
                }
            }

            return fullName;
        }

        public List<Reader> GetReadersByReadingRoomId(int readingRoomId)
        {
            List<Reader> readers = new List<Reader>();

            if (connection.IsConnect())
            {
                string query = "SELECT id, first_name, last_name, library_card_number, reading_room_id, registration_date " +
                    "FROM reader WHERE reading_room_id = @id";
                MySqlCommand command = new MySqlCommand(query, connection.Connection);
                command.Parameters.AddWithValue("@id", readingRoomId);

                using (MySqlDataReader mysqlReader = command.ExecuteReader())
                {
                    while (mysqlReader.Read())
                    {
                        Reader reader = new Reader()
                        {
                            Id = mysqlReader.GetInt32("id"),
                            FirstName = mysqlReader.GetString("first_name"),
                            LastName = mysqlReader.GetString("last_name"),
                            LibraryCardNumber = mysqlReader.GetInt32("library_card_number"),
                            ReadingRoomId = mysqlReader.GetInt32("reading_room_id"),
                            RegistrationDate = DateOnly.FromDateTime(mysqlReader.GetDateTime("registration_date"))
                        };

                        readers.Add(reader);
                    }
                }
            }

            return readers;
        }

        public List<Reader> SearchReaders(string searchText)
        {
            List<Reader> readers = new List<Reader>();

            if (connection.IsConnect())
            {
                string query = "SELECT id, first_name, last_name, library_card_number, reading_room_id, registration_date " +
                    "FROM reader WHERE " +
                    "first_name LIKE @searchText OR " +
                    "last_name LIKE @searchText OR " +
                    "library_card_number LIKE @searchText OR " +
                    "reading_room_id LIKE @searchText OR " +
                    "registration_date LIKE @searchText";

                MySqlCommand command = new MySqlCommand(query, connection.Connection);
                command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                using (MySqlDataReader mysqlReader = command.ExecuteReader())
                {
                    while (mysqlReader.Read())
                    {
                        Reader reader = new Reader()
                        {
                            Id = mysqlReader.GetInt32("id"),
                            FirstName = mysqlReader.GetString("first_name"),
                            LastName = mysqlReader.GetString("last_name"),
                            LibraryCardNumber = mysqlReader.GetInt32("library_card_number"),
                            ReadingRoomId = mysqlReader.GetInt32("reading_room_id"),
                            RegistrationDate = DateOnly.FromDateTime(mysqlReader.GetDateTime("registration_date"))
                        };

                        readers.Add(reader);
                    }
                }
            }

            return readers;
        }

        public bool UpdateReader(Reader reader)
        {
            bool result = false;

            if (connection.IsConnect())
            {
                string query = "UPDATE reader " +
                    "SET first_name = @first_name, " +
                    "last_name = @last_name, " +
                    "library_card_number = @library_card_number, " +
                    "reading_room_id = @reading_room_id, " +
                    "registration_date = @registration_date " +
                    "WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, connection.Connection);

                command.Parameters.AddWithValue("@first_name", reader.FirstName);
                command.Parameters.AddWithValue("@last_name", reader.LastName);
                command.Parameters.AddWithValue("@library_card_number", reader.LibraryCardNumber);
                command.Parameters.AddWithValue("@reading_room_id", reader.ReadingRoomId);
                command.Parameters.AddWithValue("@registration_date", reader.RegistrationDate);
                command.Parameters.AddWithValue("@id", reader.Id);

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