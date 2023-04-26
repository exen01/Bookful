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
            if (this.connection.IsConnect())
            {
                string query = "INSERT INTO book(title, author, description, publishing_house, publication_date) " +
                "VALUES (@title, @author, @description, @publishingHouse, @publicationDate)";
                var command = new MySqlCommand(query, connection.Connection);

                command.Parameters.AddWithValue("@title", book.Title);
                command.Parameters.AddWithValue("@author", book.Author);
                command.Parameters.AddWithValue("@description", book.Description);
                command.Parameters.AddWithValue("@publishingHouse", book.PublishingHouse);
                command.Parameters.AddWithValue("@publicationDate", book.PublicationDate.ToString("yyyy-MM-dd"));

                command.ExecuteNonQuery();
            }
        }

        public void DeleteBook(int id)
        {
            if (this.connection.IsConnect())
            {
                string query = "DELETE FROM book WHERE id = @id";
                var cmd = new MySqlCommand(query, connection.Connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Book> GetAllBooks()
        {
            List<Book> list = new List<Book>();

            if (this.connection.IsConnect())
            {
                string query = string.Format("SELECT id, title, author, description, publishing_house, publication_date FROM book;");
                var cmd = new MySqlCommand(query, connection.Connection);

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
                        PublicationDate = DateOnly.FromDateTime(reader.GetDateTime("publication_date"))
                    };

                    list.Add(book);
                }

                reader.Close();
            }

            return list;
        }

        public Book? GetBookById(int id)
        {
            if (this.connection.IsConnect())
            {
                string query = string.Format("SELECT id, title, author, description, publishing_house, publication_date FROM book WHERE id = @id;");
                var cmd = new MySqlCommand(query, connection.Connection);
                cmd.Parameters.AddWithValue("@id", id);

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
                        PublicationDate = DateOnly.FromDateTime(reader.GetDateTime("publication_date"))
                    };

                    reader.Close();

                    return book;
                }
            }

            return null;
        }

        public string GetBookNameAndYearById(int id)
        {
            string bookName = "";

            if (connection.IsConnect())
            {
                string query = "SELECT title, publication_date FROM book WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, connection.Connection);

                command.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        bookName = string.Format("{0} ({1})", reader.GetString("title"), reader.GetDateTime("publication_date").Year);
                    }
                }
            }

            return bookName;
        }

        public List<Book> SearchBooks(string searchText)
        {
            List<Book> books = new List<Book>();
            if (this.connection.IsConnect())
            {
                string query = "SELECT id, title, author, description, publishing_house, publication_date FROM book WHERE " +
                    "title LIKE @searchText OR " +
                    "author LIKE @searchText OR " +
                    "description LIKE @searchText OR " +
                    "publishing_house LIKE @searchText OR " +
                    "publication_date LIKE @searchText";

                var cmd = new MySqlCommand(query, connection.Connection);

                cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Book book = new Book()
                        {
                            Id = reader.GetInt32("id"),
                            Title = reader.GetString("title"),
                            Author = reader.GetString("author"),
                            Description = reader.GetString("description"),
                            PublishingHouse = reader.GetString("publishing_house"),
                            PublicationDate = DateOnly.FromDateTime(reader.GetDateTime("publication_date"))
                        };

                        books.Add(book);
                    }
                }
            }

            return books;
        }

        public void UpdateBook(Book book)
        {
            if (this.connection.IsConnect())
            {
                string query = "UPDATE book SET title = @title, author = @author, description = @description, " +
                "publishing_house = @publishingHouse, publication_date = @publicationDate " +
                "WHERE id = @id;";
                var cmd = new MySqlCommand(query, connection.Connection);

                cmd.Parameters.AddWithValue("@title", book.Title);
                cmd.Parameters.AddWithValue("@author", book.Author);
                cmd.Parameters.AddWithValue("@description", book.Description);
                cmd.Parameters.AddWithValue("@publishingHouse", book.PublishingHouse);
                cmd.Parameters.AddWithValue("@publicationDate", book.PublicationDate.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@id", book.Id);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
