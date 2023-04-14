using Bookful.domain.dto;
using Bookful.forms.edit;
using Bookful.service.book;
using Bookful.util.db;

namespace Bookful.forms.main
{
    public partial class MainForm : Form
    {
        private IBookService bookService;

        public MainForm()
        {
            InitializeComponent();

            bookService = new BookServiceImpl(DBConnection.Instance());

            var books = bookService.GetAllBooks();
            booksDataGrid.DataSource = books;
            booksDataGrid.CellContentClick += BooksDataGrid_CellContentClick;
        }

        private void BooksDataGrid_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            // Проверяем, что нажата кнопка в колонке "Удалить"
            if (e.ColumnIndex == booksDataGrid.Columns["DeleteButton"].Index && e.RowIndex >= 0)
            {
                // Получаем id книги из выделенной строки
                int bookId = (int)booksDataGrid.Rows[e.RowIndex].Cells["Id"].Value;

                // Удаляем книгу из источника данных
                bookService.DeleteBook(bookId);

                // Обновляем отображение списка книг в DataGridView
                booksDataGrid.DataSource = bookService.GetAllBooks();
            }

            // Проверяем, что нажата кнопка в колонке "Изменить"
            if (e.ColumnIndex == booksDataGrid.Columns["EditButton"].Index && e.RowIndex >= 0)
            {
                // Получаем id книги из выделенной строки
                int bookId = (int)booksDataGrid.Rows[e.RowIndex].Cells["Id"].Value;

                // Получаем книгу из источника данных
                Book book = bookService.GetBookById(bookId);

                // Открываем форму для изменения книги
                EditBookForm editBookForm = new EditBookForm(book, false);

                // Если пользователь нажал "Сохранить"
                if (editBookForm.ShowDialog() == DialogResult.OK)
                {
                    // Обновляем книгу в источнике данных
                    bookService.UpdateBook(book);

                    // Обновляем отображение списка книг в DataGridView
                    booksDataGrid.DataSource = bookService.GetAllBooks();
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            booksDataGrid.Columns["Id"].HeaderText = "ID книги";
            booksDataGrid.Columns["Title"].HeaderText = "Название";
            booksDataGrid.Columns["Author"].HeaderText = "Автор";
            booksDataGrid.Columns["Description"].HeaderText = "Описание";
            booksDataGrid.Columns["PublishingHouse"].HeaderText = "Издательство";
            booksDataGrid.Columns["PublicationDate"].HeaderText = "Дата публикации";

            // Создаем колонку с кнопками редактирования
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.HeaderText = "Изменить";
            editButtonColumn.Name = "EditButton";
            editButtonColumn.UseColumnTextForButtonValue = true;
            editButtonColumn.Text = "Изменить";

            // Добавляем колонку в DataGridView
            booksDataGrid.Columns.Add(editButtonColumn);

            // Создаем колонку с кнопками удаления
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Удалить";
            deleteButtonColumn.Name = "DeleteButton";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            deleteButtonColumn.Text = "Удалить";

            // Добавляем колонку в DataGridView
            booksDataGrid.Columns.Add(deleteButtonColumn);
        }

        private void refreshBooksButton_Click(object sender, EventArgs e)
        {
            var books = bookService.GetAllBooks();
            booksDataGrid.DataSource = books;
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            // Открываем форму для создания книги
            EditBookForm editBookForm = new EditBookForm(book, true);
            // Если пользователь нажал "Добавить"
            if (editBookForm.ShowDialog() == DialogResult.OK)
            {
                // Добавляем книгу в источнике данных
                bookService.AddBook(book);

                // Обновляем отображение списка книг в DataGridView
                booksDataGrid.DataSource = bookService.GetAllBooks();
            }
        }

        private void searchBooksButton_Click(object sender, EventArgs e)
        {
            string searchText = searchBooksInput.Text;
            List<Book> books = bookService.SearchBooks(searchText);
            booksDataGrid.DataSource = books;
        }

        private void searchBooksInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Вызываем метод поиска при нажатии клавиши Enter
                searchBooksButton_Click(sender, e);
            }
        }
    }
}
