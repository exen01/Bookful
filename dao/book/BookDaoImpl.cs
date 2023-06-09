﻿using Bookful.domain.dto;
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
            if (connection.IsConnect())
            {
                string query = "INSERT INTO book(title, author, description, publishing_house, publication_date, quantity) " +
                "VALUES (@title, @author, @description, @publishingHouse, @publicationDate, @quantity)";
                var command = new MySqlCommand(query, connection.Connection);

                command.Parameters.AddWithValue("@title", book.Title);
                command.Parameters.AddWithValue("@author", book.Author);
                command.Parameters.AddWithValue("@description", book.Description);
                command.Parameters.AddWithValue("@publishingHouse", book.PublishingHouse);
                command.Parameters.AddWithValue("@publicationDate", book.PublicationDate.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@quantity", book.Quantity);

                command.ExecuteNonQuery();
            }
        }

        public void DecrementBookCount(int bookId)
        {
            if (connection.IsConnect())
            {
                string query = "UPDATE book SET quantity = quantity - 1 WHERE id = @bookId";
                var command = new MySqlCommand(query, connection.Connection);
                command.Parameters.AddWithValue("@bookId", bookId);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteBook(int id)
        {
            if (connection.IsConnect())
            {
                string query = "DELETE FROM book WHERE id = @id";
                var cmd = new MySqlCommand(query, connection.Connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public List<string> GetAllAuthors()
        {
            List<string> result = new List<string>();
            if (connection.IsConnect())
            {
                string query = "SELECT DISTINCT author FROM book";
                var command = new MySqlCommand(query, connection.Connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(reader.GetString(0));
                    }
                }
            }

            return result;
        }

        public List<Book> GetAllBooks()
        {
            List<Book> list = new List<Book>();

            if (connection.IsConnect())
            {
                string query = string.Format("SELECT id, title, author, description, publishing_house, publication_date, quantity FROM book;");
                var cmd = new MySqlCommand(query, connection.Connection);

                using (var reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        var book = new Book()
                        {
                            Id = reader.GetInt32("id"),
                            Title = reader.GetString("title"),
                            Author = reader.GetString("author"),
                            Description = reader.GetString("description"),
                            PublishingHouse = reader.GetString("publishing_house"),
                            PublicationDate = DateOnly.FromDateTime(reader.GetDateTime("publication_date")),
                            Quantity = reader.GetInt32("quantity")
                        };

                        list.Add(book);
                    }

                }
            }

            return list;
        }

        public List<string> GetAllPublishingHouses()
        {
            List<string> result = new List<string>();
            if (connection.IsConnect())
            {
                string query = "SELECT DISTINCT publishing_house FROM book";
                var command = new MySqlCommand(query, connection.Connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(reader.GetString(0));
                    }
                }
            }

            return result;
        }

        public Book? GetBookById(int id)
        {
            if (connection.IsConnect())
            {
                string query = string.Format("SELECT id, title, author, description, publishing_house, publication_date, quantity " +
                    "FROM book WHERE id = @id;");
                var cmd = new MySqlCommand(query, connection.Connection);
                cmd.Parameters.AddWithValue("@id", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var book = new Book()
                        {
                            Id = reader.GetInt32("id"),
                            Title = reader.GetString("title"),
                            Author = reader.GetString("author"),
                            Description = reader.GetString("description"),
                            PublishingHouse = reader.GetString("publishing_house"),
                            PublicationDate = DateOnly.FromDateTime(reader.GetDateTime("publication_date")),
                            Quantity = reader.GetInt32("quantity")
                        };

                        return book;
                    }
                }
            }

            return null;
        }

        public Book? GetBookByTitleAndYear(string title, int year)
        {
            if (connection.IsConnect())
            {
                string query = "SELECT id, title, author, description, publishing_house, publication_date, quantity " +
                    "FROM book WHERE title LIKE @title AND publication_date LIKE @year";
                MySqlCommand command = new MySqlCommand(query, connection.Connection);

                command.Parameters.AddWithValue("@title", "%" + title + "%");
                command.Parameters.AddWithValue("@year", "%" + year + "%");

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var book = new Book()
                        {
                            Id = reader.GetInt32("id"),
                            Title = reader.GetString("title"),
                            Author = reader.GetString("author"),
                            Description = reader.GetString("description"),
                            PublishingHouse = reader.GetString("publishing_house"),
                            PublicationDate = DateOnly.FromDateTime(reader.GetDateTime("publication_date")),
                            Quantity = reader.GetInt32("quantity")
                        };

                        return book;
                    }
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

        public void IncreaseBookCount(int bookId)
        {
            if (connection.IsConnect())
            {
                string query = "UPDATE book SET quantity = quantity + 1 WHERE id = @bookId";
                MySqlCommand command = new MySqlCommand(query, connection.Connection);
                command.Parameters.AddWithValue("@bookId", bookId);
                command.ExecuteNonQuery();
            }
        }

        public List<Book> SearchBooks(string searchText)
        {
            List<Book> books = new List<Book>();
            if (connection.IsConnect())
            {
                string query = "SELECT id, title, author, description, publishing_house, publication_date, quantity FROM book WHERE " +
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
                            PublicationDate = DateOnly.FromDateTime(reader.GetDateTime("publication_date")),
                            Quantity = reader.GetInt32("quantity")
                        };

                        books.Add(book);
                    }
                }
            }

            return books;
        }

        public void UpdateBook(Book book)
        {
            if (connection.IsConnect())
            {
                string query = "UPDATE book SET title = @title, author = @author, description = @description, " +
                "publishing_house = @publishingHouse, publication_date = @publicationDate, quantity = @quantity " +
                "WHERE id = @id;";
                var cmd = new MySqlCommand(query, connection.Connection);

                cmd.Parameters.AddWithValue("@title", book.Title);
                cmd.Parameters.AddWithValue("@author", book.Author);
                cmd.Parameters.AddWithValue("@description", book.Description);
                cmd.Parameters.AddWithValue("@publishingHouse", book.PublishingHouse);
                cmd.Parameters.AddWithValue("@publicationDate", book.PublicationDate.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@quantity", book.Quantity);
                cmd.Parameters.AddWithValue("@id", book.Id);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
