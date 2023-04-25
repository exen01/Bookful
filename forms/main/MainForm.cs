using Bookful.dao.issuedBook;
using Bookful.domain.dto;
using Bookful.forms.edit;
using Bookful.forms.edit.issuedBook;
using Bookful.forms.edit.reader;
using Bookful.service.book;
using Bookful.service.issuedBook;
using Bookful.service.reader;
using Bookful.service.readingRoom;
using Bookful.util.db;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Bookful.forms.main
{
    public partial class MainForm : MaterialForm
    {
        private IBookService bookService;
        private IReadingRoomService readingRoomService;
        private IReaderService readerService;
        private IIssuedBookService issuedBookService;
        private DBConnection connection = DBConnection.Instance();
        private MaterialSkinManager materialSkinManager;

        public MainForm()
        {
            InitializeComponent();

            bookService = new BookServiceImpl(connection);
            readingRoomService = new ReadingRoomServiceImpl(connection);
            readerService = new ReaderServiceImpl(connection);
            issuedBookService = new IssuedBookServiceImpl(new IssuedBookDaoImpl(connection));

            var books = bookService.GetAllBooks();
            booksDataGrid.DataSource = books;
            booksDataGrid.CellContentClick += BooksDataGrid_CellContentClick;

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, // Основной цвет (Primary)
                Primary.BlueGrey900, // Основной цвет (Primary) в активном состоянии
                Primary.BlueGrey500, // Основной цвет (Primary) в подсвеченном состоянии
                Accent.LightBlue200, // Акцентный цвет (Accent)
                TextShade.WHITE // Цвет текста (TextShade)
            );

            var issuedBooks = issuedBookService.GetAll();
            issuedBooksDataGrid.DataSource = issuedBooks;

            /*var readers = readerService.GetAllReaders();
            readersDataGrid.DataSource = readers;*/

            /*var readingRooms = readingRoomService.GetAllReadingRooms();
            readingRoomsDataGrid.DataSource = readingRooms;*/
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
            var idColumn = booksDataGrid.Columns["Id"];
            var fullTitleColumn = booksDataGrid.Columns["DisplayTitleYear"];
            if (idColumn != null && fullTitleColumn != null)
            {
                idColumn.Visible = false;
                fullTitleColumn.Visible = false;
            }

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
            editButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            // Добавляем колонку в DataGridView
            booksDataGrid.Columns.Add(editButtonColumn);

            // Создаем колонку с кнопками удаления
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Удалить";
            deleteButtonColumn.Name = "DeleteButton";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            deleteButtonColumn.Text = "Удалить";
            deleteButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

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

        private void searchReadingRoomsButton_Click(object sender, EventArgs e)
        {
            string searchText = searchReadingRoomsInput.Text;
            List<ReadingRoom> readingRooms = readingRoomService.SearchReadingRooms(searchText);
            readingRoomsDataGrid.DataSource = readingRooms;
        }

        private void searchReadingRoomsInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchReadingRoomsButton_Click(sender, e);
            }
        }

        private void refreshReadingRoomsButton_Click(object sender, EventArgs e)
        {
            var readingRooms = readingRoomService.GetAllReadingRooms();
            readingRoomsDataGrid.DataSource = readingRooms;
        }

        private void addReadingRoomButton_Click(object sender, EventArgs e)
        {
            ReadingRoom readingRoom = new ReadingRoom();
            EditReadingRoomForm editReadingRoomForm = new EditReadingRoomForm(readingRoom, true);
            if (editReadingRoomForm.ShowDialog() == DialogResult.OK)
            {
                readingRoomService.AddReadingRoom(readingRoom);

                readingRoomsDataGrid.DataSource = readingRoomService.GetAllReadingRooms();
            }
        }

        private void readingRoomsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Проверяем, что нажата кнопка в колонке "Удалить"
            if (e.ColumnIndex == readingRoomsDataGrid.Columns["DeleteButton"].Index && e.RowIndex >= 0)
            {
                int readingRoomId = (int)readingRoomsDataGrid.Rows[e.RowIndex].Cells["Id"].Value;
                bool result = readingRoomService.DeleteReadingRoomById(readingRoomId);

                if (result)
                {
                    //MessageBox.Show("Читальный зал удален успешно.", "Успешное удаление");
                    readingRoomsDataGrid.DataSource = readingRoomService.GetAllReadingRooms();
                }
                else
                {
                    MessageBox.Show("Ошибка при удалении читального зала.", "Ошибка удаления");
                    // Вывести сообщение об ошибке или выполнить другие действия
                }
            }

            // Проверяем, что нажата кнопка в колонке "Изменить"
            if (e.ColumnIndex == readingRoomsDataGrid.Columns["EditButton"].Index && e.RowIndex >= 0)
            {
                int readingRoomId = (int)readingRoomsDataGrid.Rows[e.RowIndex].Cells["Id"].Value;

                ReadingRoom readingRoom = readingRoomService.GetReadingRoomById(readingRoomId);

                EditReadingRoomForm editReadingRoomForm = new EditReadingRoomForm(readingRoom, false);

                // Если пользователь нажал "Сохранить"
                if (editReadingRoomForm.ShowDialog() == DialogResult.OK)
                {
                    bool result = readingRoomService.UpdateReadingRoom(readingRoom);

                    if (result)
                    {
                        //MessageBox.Show("Читальный зал обновлен успешно.", "Успешное обновление");
                        readingRoomsDataGrid.DataSource = readingRoomService.GetAllReadingRooms();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при обновлении читального зала.", "Ошибка обновления");
                        // Вывести сообщение об ошибке или выполнить другие действия
                    }

                }
            }
        }

        private void readingRoomsDataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var idColumn = readingRoomsDataGrid.Columns["Id"];
            if (idColumn != null)
            {
                idColumn.Visible = false;
            }

            readingRoomsDataGrid.Columns["Number"].HeaderText = "Номер";
            readingRoomsDataGrid.Columns["Specialization"].HeaderText = "Специализация";
            readingRoomsDataGrid.Columns["SeatsCount"].HeaderText = "Кол-во мест";

            if (!readingRoomsDataGrid.Columns.Contains("EditButton"))
            {
                // Создаем колонку с кнопками редактирования
                DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
                editButtonColumn.HeaderText = "Изменить";
                editButtonColumn.Name = "EditButton";
                editButtonColumn.UseColumnTextForButtonValue = true;
                editButtonColumn.Text = "Изменить";
                editButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Добавляем колонку в DataGridView
                readingRoomsDataGrid.Columns.Add(editButtonColumn);
            }

            if (!readingRoomsDataGrid.Columns.Contains("DeleteButton"))
            {
                // Создаем колонку с кнопками удаления
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                deleteButtonColumn.HeaderText = "Удалить";
                deleteButtonColumn.Name = "DeleteButton";
                deleteButtonColumn.UseColumnTextForButtonValue = true;
                deleteButtonColumn.Text = "Удалить";
                deleteButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Добавляем колонку в DataGridView
                readingRoomsDataGrid.Columns.Add(deleteButtonColumn);
            }
        }

        private void refreshReadersButton_Click(object sender, EventArgs e)
        {
            var readers = readerService.GetAllReaders();
            readersDataGrid.DataSource = readers;
        }

        private void readersDataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var idColumn = readersDataGrid.Columns["Id"];
            var fullNameColumn = readersDataGrid.Columns["DisplayFullNameCardNumber"];
            if (idColumn != null && fullNameColumn != null)
            {
                idColumn.Visible = false;
                fullNameColumn.Visible = false;
            }

            readersDataGrid.Columns["FirstName"].HeaderText = "Имя";
            readersDataGrid.Columns["LastName"].HeaderText = "Фамилия";
            readersDataGrid.Columns["LibraryCardNumber"].HeaderText = "Номер читательского билета";
            readersDataGrid.Columns["ReadingRoomId"].HeaderText = "Номер читального зала";
            readersDataGrid.Columns["RegistrationDate"].HeaderText = "Дата регистрации";

            if (!readersDataGrid.Columns.Contains("EditButton"))
            {
                // Создаем колонку с кнопками редактирования
                DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
                editButtonColumn.HeaderText = "Изменить";
                editButtonColumn.Name = "EditButton";
                editButtonColumn.UseColumnTextForButtonValue = true;
                editButtonColumn.Text = "Изменить";
                editButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Добавляем колонку в DataGridView
                readersDataGrid.Columns.Add(editButtonColumn);
            }

            if (!readersDataGrid.Columns.Contains("DeleteButton"))
            {
                // Создаем колонку с кнопками удаления
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                deleteButtonColumn.HeaderText = "Удалить";
                deleteButtonColumn.Name = "DeleteButton";
                deleteButtonColumn.UseColumnTextForButtonValue = true;
                deleteButtonColumn.Text = "Удалить";
                deleteButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Добавляем колонку в DataGridView
                readersDataGrid.Columns.Add(deleteButtonColumn);
            }
        }

        private void readersDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (readersDataGrid.Columns[e.ColumnIndex].Name == "ReadingRoomId")
            {
                int readingRoomId = Convert.ToInt32(e.Value);
                e.Value = readingRoomService.GetReadingRoomNumberById(readingRoomId);
            }
        }

        private void addReaderButton_Click(object sender, EventArgs e)
        {
            Reader reader = new Reader();

            EditReaderForm editReaderForm = new EditReaderForm(reader, true, readingRoomService);
            if (editReaderForm.ShowDialog() == DialogResult.OK)
            {
                readerService.AddReader(reader);

                readersDataGrid.DataSource = readerService.GetAllReaders();
            }
        }

        private void readersDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Проверяем, что нажата кнопка в колонке "Удалить"
            if (e.ColumnIndex == readersDataGrid.Columns["DeleteButton"].Index && e.RowIndex >= 0)
            {
                int readerId = (int)readersDataGrid.Rows[e.RowIndex].Cells["Id"].Value;
                bool result = readerService.DeleteReaderById(readerId);

                if (result)
                {
                    readersDataGrid.DataSource = readerService.GetAllReaders();
                }
                else
                {
                    MessageBox.Show("Ошибка при удалении читателя.", "Ошибка удаления");
                    // Вывести сообщение об ошибке или выполнить другие действия
                }
            }

            // Проверяем, что нажата кнопка в колонке "Изменить"
            if (e.ColumnIndex == readersDataGrid.Columns["EditButton"].Index && e.RowIndex >= 0)
            {
                int readerId = (int)readersDataGrid.Rows[e.RowIndex].Cells["Id"].Value;

                Reader reader = readerService.GetReaderById(readerId);

                EditReaderForm editReaderForm = new EditReaderForm(reader, false, readingRoomService);

                // Если пользователь нажал "Сохранить"
                if (editReaderForm.ShowDialog() == DialogResult.OK)
                {
                    bool result = readerService.UpdateReader(reader);

                    if (result)
                    {
                        readersDataGrid.DataSource = readerService.GetAllReaders();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при обновлении читального зала.", "Ошибка обновления");
                        // Вывести сообщение об ошибке или выполнить другие действия
                    }

                }
            }
        }

        private void issuedBooksDataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var idColumn = issuedBooksDataGrid.Columns["Id"];
            if (idColumn != null)
            {
                idColumn.Visible = false;
            }

            issuedBooksDataGrid.Columns["ReaderId"].HeaderText = "Читатель";
            issuedBooksDataGrid.Columns["BookId"].HeaderText = "Книга";
            issuedBooksDataGrid.Columns["IssueDate"].HeaderText = "Дата выдачи книги";
            issuedBooksDataGrid.Columns["ReturnDate"].HeaderText = "Дата возврата книги";
            issuedBooksDataGrid.Columns["ExpectedReturnDate"].HeaderText = "Ожидаемая дата возврата книги";

            if (!issuedBooksDataGrid.Columns.Contains("EditButton"))
            {
                // Создаем колонку с кнопками редактирования
                DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
                editButtonColumn.HeaderText = "Изменить";
                editButtonColumn.Name = "EditButton";
                editButtonColumn.UseColumnTextForButtonValue = true;
                editButtonColumn.Text = "Изменить";
                editButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Добавляем колонку в DataGridView
                issuedBooksDataGrid.Columns.Add(editButtonColumn);
            }

            if (!issuedBooksDataGrid.Columns.Contains("DeleteButton"))
            {
                // Создаем колонку с кнопками удаления
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                deleteButtonColumn.HeaderText = "Удалить";
                deleteButtonColumn.Name = "DeleteButton";
                deleteButtonColumn.UseColumnTextForButtonValue = true;
                deleteButtonColumn.Text = "Удалить";
                deleteButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Добавляем колонку в DataGridView
                issuedBooksDataGrid.Columns.Add(deleteButtonColumn);
            }
        }

        private void issuedBooksDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (issuedBooksDataGrid.Columns[e.ColumnIndex].Name == "ReaderId")
            {
                int readerId = Convert.ToInt32(e.Value);
                e.Value = readerService.GetReaderFullNameById(readerId);
            }

            if (issuedBooksDataGrid.Columns[e.ColumnIndex].Name == "BookId")
            {
                int bookId = Convert.ToInt32(e.Value);
                e.Value = bookService.GetBookNameAndYearById(bookId);
            }

            if (issuedBooksDataGrid.Columns[e.ColumnIndex].Name == "ReturnDate")
            {
                if (e.Value == null)
                {
                    e.Value = "Книга ещё не возвращена.";
                }
            }
        }

        private void issuedBooksDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Проверяем, что нажата кнопка в колонке "Удалить"
            if (e.ColumnIndex == issuedBooksDataGrid.Columns["DeleteButton"].Index && e.RowIndex >= 0)
            {
                int issuedBookId = (int)issuedBooksDataGrid.Rows[e.RowIndex].Cells["Id"].Value;
                bool result = issuedBookService.DeleteIssueBookById(issuedBookId);

                if (result)
                {
                    issuedBooksDataGrid.DataSource = issuedBookService.GetAll();
                }
                else
                {
                    MessageBox.Show("Ошибка при удалении выданной книги.", "Ошибка удаления");
                    // Вывести сообщение об ошибке или выполнить другие действия
                }
            }

            // Проверяем, что нажата кнопка в колонке "Изменить"
            if (e.ColumnIndex == issuedBooksDataGrid.Columns["EditButton"].Index && e.RowIndex >= 0)
            {
                int issuedBookId = (int)issuedBooksDataGrid.Rows[e.RowIndex].Cells["Id"].Value;

                IssuedBook issuedBook = issuedBookService.GetById(issuedBookId);

                EditIssuedBookForm editIssuedBookForm = new EditIssuedBookForm(issuedBook, false, bookService, readerService);

                // Если пользователь нажал "Сохранить"
                if (editIssuedBookForm.ShowDialog() == DialogResult.OK)
                {
                    bool result = issuedBookService.UpdateIssueBook(issuedBook);

                    if (result)
                    {
                        issuedBooksDataGrid.DataSource = issuedBookService.GetAll();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при обновлении выданной книги.", "Ошибка обновления");
                        // Вывести сообщение об ошибке или выполнить другие действия
                    }

                }
            }
        }

        private void addIssueBookButton_Click(object sender, EventArgs e)
        {
            IssuedBook issuedBook = new IssuedBook();

            EditIssuedBookForm editIssuedBookForm = new EditIssuedBookForm(issuedBook, true, bookService, readerService);
            if (editIssuedBookForm.ShowDialog() == DialogResult.OK)
            {
                issuedBookService.AddIssueBook(issuedBook);

                issuedBooksDataGrid.DataSource = issuedBookService.GetAll();
            }
        }
    }
}
