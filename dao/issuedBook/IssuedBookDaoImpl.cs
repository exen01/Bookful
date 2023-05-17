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
                

                string query = "INSERT INTO issued_books(reader_id, book_id, issue_date, return_date, expected_return_date) " +
                    "VALUES (@reader_id, @book_id, @issue_date, @return_date, @expected_return_date)";
                MySqlCommand command = new MySqlCommand(query, connection.Connection);

                command.Parameters.AddWithValue("@reader_id", issuedBook.ReaderId);
                command.Parameters.AddWithValue("@book_id", issuedBook.BookId);
                command.Parameters.AddWithValue("@issue_date", issuedBook.IssueDate.ToString("yyyy-MM-dd"));

                if (issuedBook.ReturnDate != null)
                {
                    command.Parameters.AddWithValue("@return_date", issuedBook.ReturnDate.Value.ToString("yyyy-MM-dd"));
                }
                else
                {
                    command.Parameters.AddWithValue("@return_date", null);
                }

                command.Parameters.AddWithValue("@expected_return_date", issuedBook.ExpectedReturnDate.ToString("yyyy-MM-dd"));

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
                command.Parameters.AddWithValue("@issue_date", issuedBook.IssueDate.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@return_date", issuedBook.ReturnDate.HasValue ? issuedBook.ReturnDate.Value.ToString("yyyy-MM-dd") : null);
                command.Parameters.AddWithValue("@expected_return_date", issuedBook.ExpectedReturnDate.ToString("yyyy-MM-dd"));
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

        public List<IssuedBook> SearchIssuedBooks(string searchText)
        {
            List<IssuedBook> issuedBooks = new List<IssuedBook>();

            if (connection.IsConnect())
            {
                string query = "SELECT i.id, i.reader_id, i.book_id, i.issue_date, i.return_date, i.expected_return_date " +
                    "FROM issued_books i " +
                    "LEFT JOIN book b ON i.book_id = b.id " +
                    "LEFT JOIN reader r ON i.reader_id = r.id " +
                    "WHERE r.first_name LIKE @searchText OR " +
                    "r.last_name LIKE @searchText OR " +
                    "b.title LIKE @searchText OR " +
                    "i.issue_date LIKE @searchText OR " +
                    "i.return_date LIKE @searchText OR " +
                    "i.expected_return_date LIKE @searchText";

                MySqlCommand command = new MySqlCommand(query, connection.Connection);
                command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

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

        /// <summary>
        /// Возвращает количество выданных экземпляров книги с заданным идентификатором. 
        /// </summary>
        /// <param name="bookId">Идентификатор книги</param>
        /// <returns>Количество выданных экземпляров</returns>
        public int GetIssuedBookQuantity(int bookId)
        {
            int quantity = 0;

            if (connection.IsConnect())
            {
                string query = "SELECT COUNT(*) FROM issued_books WHERE book_id = @bookId AND return_date = null";
                MySqlCommand command = new MySqlCommand(query, connection.Connection);
                command.Parameters.AddWithValue("@bookId", bookId);
                quantity = Convert.ToInt32(command.ExecuteScalar());
            }

            return quantity;
        }

        public List<IssuedBook> GetUreturnedBooks()
        {
            List<IssuedBook> issuedBooks = new List<IssuedBook>();

            if (connection.IsConnect())
            {
                string query = "SELECT id, reader_id, book_id, issue_date, return_date, expected_return_date " +
                    "FROM issued_books WHERE return_date IS NULL";
                MySqlCommand command = new MySqlCommand(query, connection.Connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        IssuedBook issuedBook = new IssuedBook()
                        {
                            Id = reader.GetInt32("id"),
                            ReaderId = reader.GetInt32("reader_id"),
                            BookId = reader.GetInt32("book_id"),
                            IssueDate = DateOnly.FromDateTime(reader.GetDateTime("issue_date")),
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
