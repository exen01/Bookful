using Bookful.domain.dto;
using Bookful.util.db;
using MySql.Data.MySqlClient;

namespace Bookful.dao.book
{
    public class BookDaoImpl : IBookDao
    {
        private DBConnection connection;

        public BookDaoImpl(DBConnection connection)
        {
            this.connection = connection;
        }

        public void DeleteBook(int bookId)
        {
            if (this.connection.IsConnect())
            {
                string query = string.Format("DELETE FROM book WHERE id = {0}", bookId);
                var cmd = new MySqlCommand(query, connection.Connection);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Book> GetAllBooks()
        {
            List<Book> list = new List<Book>();

            if (this.connection.IsConnect())
            {
                string query = string.Format("SELECT * FROM book;");
                var cmd = new MySqlCommand(query, connection.Connection);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var book = new Book();
                    book.Id = reader.GetInt32(0);
                    book.Title = reader.GetString(1);
                    book.Description = reader.GetString(2);
                    book.PublishingHouse = reader.GetString(3);
                    book.PublicationDate = reader.GetString(4);

                    list.Add(book);
                }

                reader.Close();
            }

            return list;
        }

        public void InsertNewBook(Book book)
        {
            if (this.connection.IsConnect())
            {
                string query = string.Format("INSERT INTO book(title, description, publishing_house, publication_date) " +
                    "VALUES('{0}', '{1}', '{2}', {3});", book.Title, book.Description, book.PublishingHouse, book.PublicationDate);
                var cmd = new MySqlCommand(query, connection.Connection);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
