using Bookful.domain.dto;
using Bookful.util.db;
using MySql.Data.MySqlClient;

namespace Bookful.dao.issuedBook
{
    public class IssuedBookDaoImpl : IIssuedBookDao
    {
        private readonly DBConnection connection;

        public IssuedBookDaoImpl(DBConnection connection)
        {
            this.connection = connection;
        }

        public void AddIssueBook(IssuedBook issuedBook)
        {
            if (connection.IsConnect())
            {
                string query = "INSERT INTO issued_books(reader_id, book_id, issue_date, expected_return_date) " +
                    "VALUES (@reader_id, @book_id, @issue_date, @expected_return_date)";
                MySqlCommand command = new MySqlCommand(query, connection.Connection);

                command.Parameters.AddWithValue("@reader_id", issuedBook.ReaderId);
                command.Parameters.AddWithValue("@book_id", issuedBook.BookId);
                command.Parameters.AddWithValue("@issue_date", issuedBook.IssueDate);
                command.Parameters.AddWithValue("@expected_return_date", issuedBook.ExpectedReturnDate);

                command.ExecuteNonQuery();
            }
        }

        public void DeleteIssueBook(int id)
        {
            if (connection.IsConnect())
            {
                string query = "DELETE FROM issued_books WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, connection.Connection);

                command.Parameters.AddWithValue("@id", id);

                command.ExecuteNonQuery();
            }
        }

        public void UpdateIssueBook(IssuedBook issuedBook)
        {
            if (connection.IsConnect())
            {
                string query = "UPDATE issued_books " +
                    "SET reader_id = @reader_id, " +
                    "book_id = @book_id, " +
                    "issue_date = @issue_date, " +
                    "return_date = @return_date, " +
                    "expected_return_date = @expected_return_date " +
                    "WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, connection.Connection);

                command.Parameters.AddWithValue("@reader_id", issuedBook.ReaderId);
                command.Parameters.AddWithValue("@book_id", issuedBook.BookId);
                command.Parameters.AddWithValue("@issue_date", issuedBook.IssueDate);
                command.Parameters.AddWithValue("@return_date", issuedBook.ReturnDate);
                command.Parameters.AddWithValue("@expected_return_date", issuedBook.ExpectedReturnDate);
                command.Parameters.AddWithValue("@id", issuedBook.Id);

                command.ExecuteNonQuery();
            }
        }

        public List<IssuedBook> GetAll()
        {
            List<IssuedBook> issuedBooks = new List<IssuedBook>();

            if (connection.IsConnect())
            {
                string query = "SELECT id, reader_id, book_id, issue_date, return_date, expected_return_date " +
                    "FROM issued_books";
                MySqlCommand command = new MySqlCommand(query, connection.Connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateOnly? returnDate = null;
                        if (!reader.IsDBNull(reader.GetOrdinal("return_date")))
                        {
                            returnDate = DateOnly.FromDateTime(reader.GetDateTime("return_date"));
                        }

                        IssuedBook issuedBook = new IssuedBook()
                        {
                            Id = reader.GetInt32("id"),
                            ReaderId = reader.GetInt32("reader_id"),
                            BookId = reader.GetInt32("book_id"),
                            IssueDate = DateOnly.FromDateTime(reader.GetDateTime("issue_date")),
                            ReturnDate = returnDate,
                            ExpectedReturnDate = DateOnly.FromDateTime(reader.GetDateTime("expected_return_date"))
                        };

                        issuedBooks.Add(issuedBook);
                    }
                }
            }

            return issuedBooks;
        }

        public List<IssuedBook> GetByBookId(int bookId)
        {
            List<IssuedBook> issuedBooks = new List<IssuedBook>();

            if (connection.IsConnect())
            {
                string query = "SELECT id, reader_id, book_id, issue_date, return_date, expected_return_date " +
                    "FROM issued_books WHERE book_id = @book_id";
                MySqlCommand command = new MySqlCommand(query, connection.Connection);

                command.Parameters.AddWithValue("@book_id", bookId);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateOnly? returnDate = null;
                        if (!reader.IsDBNull(reader.GetOrdinal("return_date")))
                        {
                            returnDate = DateOnly.FromDateTime(reader.GetDateTime("return_date"));
                        }

                        IssuedBook issuedBook = new IssuedBook()
                        {
                            Id = reader.GetInt32("id"),
                            ReaderId = reader.GetInt32("reader_id"),
                            BookId = reader.GetInt32("book_id"),
                            IssueDate = DateOnly.FromDateTime(reader.GetDateTime("issue_date")),
                            ReturnDate = returnDate,
                            ExpectedReturnDate = DateOnly.FromDateTime(reader.GetDateTime("expected_return_date"))
                        };

                        issuedBooks.Add(issuedBook);
                    }
                }
            }

            return issuedBooks;
        }

        public IssuedBook? GetById(int id)
        {
            IssuedBook? issuedBook = null;

            if (connection.IsConnect())
            {
                string query = "SELECT id, reader_id, book_id, issue_date, return_date, expected_return_date " +
                    "FROM issued_books WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, connection.Connection);

                command.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        DateOnly? returnDate = null;
                        if (!reader.IsDBNull(reader.GetOrdinal("return_date")))
                        {
                            returnDate = DateOnly.FromDateTime(reader.GetDateTime("return_date"));
                        }

                        issuedBook = new IssuedBook()
                        {
                            Id = reader.GetInt32("id"),
                            ReaderId = reader.GetInt32("reader_id"),
                            BookId = reader.GetInt32("book_id"),
                            IssueDate = DateOnly.FromDateTime(reader.GetDateTime("issue_date")),
                            ReturnDate = returnDate,
                            ExpectedReturnDate = DateOnly.FromDateTime(reader.GetDateTime("expected_return_date"))
                        };
                    }
                }
            }

            return issuedBook;
        }

        public List<IssuedBook> GetByReaderId(int readerId)
        {
            List<IssuedBook> issuedBooks = new List<IssuedBook>();

            if (connection.IsConnect())
            {
                string query = "SELECT id, reader_id, book_id, issue_date, return_date, expected_return_date " +
                    "FROM issued_books WHERE reader_id = @reader_id";
                MySqlCommand command = new MySqlCommand(query, connection.Connection);

                command.Parameters.AddWithValue("@reader_id", readerId);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateOnly? returnDate = null;
                        if (!reader.IsDBNull(reader.GetOrdinal("return_date")))
                        {
                            returnDate = DateOnly.FromDateTime(reader.GetDateTime("return_date"));
                        }

                        IssuedBook issuedBook = new IssuedBook()
                        {
                            Id = reader.GetInt32("id"),
                            ReaderId = reader.GetInt32("reader_id"),
                            BookId = reader.GetInt32("book_id"),
                            IssueDate = DateOnly.FromDateTime(reader.GetDateTime("issue_date")),
                            ReturnDate = returnDate,
                            ExpectedReturnDate = DateOnly.FromDateTime(reader.GetDateTime("expected_return_date"))
                        };

                        issuedBooks.Add(issuedBook);
                    }
                }
            }

            return issuedBooks;
        }
    }
}
