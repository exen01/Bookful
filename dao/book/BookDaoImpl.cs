using Bookful.domain.dto;
using Bookful.util.db;
using MySql.Data.MySqlClient;

namespace Bookful.dao.book
{
    public class BookDaoImpl : IBookDao
    {
        private readonly DBConnection connection;

        public BookDaoImpl(DBConnection connection)
        {
            this.connection = connection;
        }

        public void AddBook(Book book)
        {
            string query = "INSERT INTO book(title, author, description, publishing_house, publication_date) " +
                "VALUES (@title, @author, @description, @publishingHouse, @publicationDate)";
            var command = new MySqlCommand(query, connection.Connection);

            command.Parameters.AddWithValue("@title", book.Title);
            command.Parameters.AddWithValue("@author", book.Author);
            command.Parameters.AddWithValue("@description", book.Description);
            command.Parameters.AddWithValue("@publishingHouse", book.PublishingHouse);
            command.Parameters.AddWithValue("@publicationDate", book.PublicationDate);

            if (this.connection.IsConnect())
            {
                command.ExecuteNonQuery();
            }

        }

        public void DeleteBook(int id)
        {
            string query = "DELETE FROM book WHERE id = @id";
            var cmd = new MySqlCommand(query, connection.Connection);
            cmd.Parameters.AddWithValue("@id", id);

            if (this.connection.IsConnect())
            {

                cmd.ExecuteNonQuery();
            }
        }

        public List<Book> GetAllBooks()
        {
            List<Book> list = new List<Book>();

            string query = string.Format("SELECT id, title, author, description, publishing_house, publication_date FROM book;");
            var cmd = new MySqlCommand(query, connection.Connection);

            if (this.connection.IsConnect())
            {
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var book = new Book()
                    {
                        Id = reader.GetInt32("id"),
                        Title = reader.GetString("title"),
                        Author = reader.GetString("author"),
                        Description = reader.GetString("description"),
                        PublishingHouse = reader.GetString("publishing_house"),
                        PublicationDate = reader.GetString("publication_date")
                    };

                    list.Add(book);
                }

                reader.Close();
            }

            return list;
        }

        public Book? GetBookById(int id)
        {
            string query = string.Format("SELECT id, title, author, description, publishing_house, publication_date FROM book WHERE id = @id;");
            var cmd = new MySqlCommand(query, connection.Connection);
            cmd.Parameters.AddWithValue("@id", id);

            if (this.connection.IsConnect())
            {
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var book = new Book()
                    {
                        Id = reader.GetInt32("id"),
                        Title = reader.GetString("title"),
                        Author = reader.GetString("author"),
                        Description = reader.GetString("description"),
                        PublishingHouse = reader.GetString("publishing_house"),
                        PublicationDate = reader.GetString("publication_date")
                    };

                    return book;
                }
            }

            return null;
        }

        public void UpdateBook(Book book)
        {
            string query = "UPDATE book SET title = @title, author = @author, description = @description, " +
                "publishing_house = @publishingHouse, publication_date = @publicationDate " +
                "WHERE id = @id;";
            var cmd = new MySqlCommand(query, connection.Connection);

            cmd.Parameters.AddWithValue("@title", book.Title);
            cmd.Parameters.AddWithValue("@author", book.Author);
            cmd.Parameters.AddWithValue("@description", book.Description);
            cmd.Parameters.AddWithValue("@publishingHouse", book.PublishingHouse);
            cmd.Parameters.AddWithValue("@publicationDate", book.PublicationDate);

            if (this.connection.IsConnect())
            {
                cmd.ExecuteNonQuery();
            }
        }
    }
}
