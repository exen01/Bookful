using Bookful.dao.book;
using Bookful.dao.issuedBook;
using Bookful.dao.reader;
using Bookful.dao.readingRoom;
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
using System.Data;
using System.Windows.Forms;

namespace Bookful.forms.main
{
    public partial class MainForm : MaterialForm
    {
        private IBookService bookService;
        private IReadingRoomService readingRoomService;
        private IReaderService readerService;
        private IIssuedBookService issuedBookService;
        private DBConnection connection;
        private MaterialSkinManager materialSkinManager;

        public MainForm()
        {
            InitializeComponent();
            connection = DBConnection.Instance();

            var bookDao = new BookDaoImpl(connection);
            var issuedBookDao = new IssuedBookDaoImpl(connection);
            var readingRoomDao = new ReadingRoomDaoImpl(connection);
            var readerDao = new ReaderDaoImpl(connection);

            bookService = new BookServiceImpl(bookDao, issuedBookDao);
            readingRoomService = new ReadingRoomServiceImpl(readingRoomDao, readerDao);
            readerService = new ReaderServiceImpl(readerDao, issuedBookDao);
            issuedBookService = new IssuedBookServiceImpl(issuedBookDao, bookDao);

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

            List<IssuedBook> issuedBooks = issuedBookService.GetAll();
            issuedBooksDataGrid.DataSource = issuedBooks;

            /*var books = bookService.GetAllBooks();
            booksDataGrid.DataSource = books;*/

            /*var readers = readerService.GetAllReaders();
            readersDataGrid.DataSource = readers;*/

            /*var readingRooms = readingRoomService.GetAllReadingRooms();
            readingRoomsDataGrid.DataSource = readingRooms;*/
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            var readers = readerService.GetAllReaders();
            foreach (var reader in readers)
            {
                issuedBookReaderFilterBox.Items.Add(reader.DisplayFullNameCardNumber);
            }

            var books = bookService.GetAllBooks();
            foreach (var book in books)
            {
                issuedBookBookFilterBox.Items.Add(book.DisplayTitleYear);
            }
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
            EditBookForm editBookForm = new EditBookForm(book, true, bookService);
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

            EditReaderForm editReaderForm = new EditReaderForm(reader, true, readingRoomService, readerService);
            if (editReaderForm.ShowDialog() == DialogResult.OK)
            {
                readerService.AddReader(reader);

                readersDataGrid.DataSource = readerService.GetAllReaders();
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

        private void booksDataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
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
            booksDataGrid.Columns["Quantity"].HeaderText = "Количество";
        }

        private void refreshIssueBooksButton_Click(object sender, EventArgs e)
        {
            List<IssuedBook> issuedBooks = issuedBookService.GetAll();
            issuedBooksDataGrid.DataSource = issuedBooks;

            var readers = readerService.GetAllReaders();
            issuedBookReaderFilterBox.Items.Clear();
            foreach (var reader in readers)
            {
                issuedBookReaderFilterBox.Items.Add(reader.DisplayFullNameCardNumber);
            }

            var books = bookService.GetAllBooks();
            issuedBookBookFilterBox.Items.Clear();
            foreach (var book in books)
            {
                issuedBookBookFilterBox.Items.Add(book.DisplayTitleYear);
            }
        }

        private void searchReadersButton_Click(object sender, EventArgs e)
        {
            string searchText = searchReadersInput.Text;
            List<Reader> readers = readerService.SearchReaders(searchText);
            readersDataGrid.DataSource = readers;
        }

        private void searchReadersInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Вызываем метод поиска при нажатии клавиши Enter
                searchReadersButton_Click(sender, e);
            }
        }

        private void searchIssueBooksButton_Click(object sender, EventArgs e)
        {
            string searchText = searchIssueBooksInput.Text;
            List<IssuedBook> issuedBooks = issuedBookService.SearchIssuedBooks(searchText);
            issuedBooksDataGrid.DataSource = issuedBooks;
        }

        private void searchIssueBooksInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Вызываем метод поиска при нажатии клавиши Enter
                searchIssueBooksButton_Click(sender, e);
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                UpdateDataGridView();
            }
            if (e.KeyCode == Keys.Insert)
            {
                InsertEntity(sender, e);
            }
            if (e.KeyCode == Keys.Delete)
            {
                DeleteEntity(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.E)
            {
                EditEntity(sender, e);
            }
        }

        private void EditEntity(object sender, KeyEventArgs e)
        {
            switch (tabControl.SelectedIndex) // получаем индекс активной вкладки
            {
                case 0:
                    editIssuedBookButton_Click(sender, e);
                    break;
                case 1:
                    editBookButton_Click(sender, e);
                    break;
                case 2:
                    editReaderButton_Click(sender, e);
                    break;
                case 3:
                    editReadingRoomButton_Click(sender, e);
                    break;
            }
        }

        private void DeleteEntity(object sender, KeyEventArgs e)
        {
            switch (tabControl.SelectedIndex) // получаем индекс активной вкладки
            {
                case 0:
                    deleteIssuedBookButton_Click(sender, e);
                    break;
                case 1:
                    deleteBookButton_Click(sender, e);
                    break;
                case 2:
                    deleteReaderButton_Click(sender, e);
                    break;
                case 3:
                    deleteReadingRoomButton_Click(sender, e);
                    break;
            }
        }

        private void InsertEntity(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex) // получаем индекс активной вкладки
            {
                case 0:
                    addIssueBookButton_Click(sender, e);
                    break;
                case 1:
                    addBookButton_Click(sender, e);
                    break;
                case 2:
                    addReaderButton_Click(sender, e);
                    break;
                case 3:
                    addReadingRoomButton_Click(sender, e);
                    break;
            }
        }

        private void UpdateDataGridView()
        {
            switch (tabControl.SelectedIndex) // получаем индекс активной вкладки
            {
                case 0:
                    issuedBooksDataGrid.DataSource = issuedBookService.GetAll();
                    break;
                case 1:
                    booksDataGrid.DataSource = bookService.GetAllBooks();
                    break;
                case 2:
                    readersDataGrid.DataSource = readerService.GetAllReaders();
                    break;
                case 3:
                    readingRoomsDataGrid.DataSource = readingRoomService.GetAllReadingRooms();
                    break;
            }
        }

        private void tabControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                int index = e.KeyCode - Keys.D0;
                if (index == 0) index = 10; // переключение на последнюю вкладку
                if (index <= tabControl.TabCount)
                {
                    tabControl.SelectedIndex = index - 1;
                }
            }
        }

        private void editIssuedBookButton_Click(object sender, EventArgs e)
        {
            if (issuedBooksDataGrid.SelectedRows.Count > 0)
            {
                int issuedBookId = (int)issuedBooksDataGrid.SelectedRows[0].Cells["Id"].Value;

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

        private void deleteIssuedBookButton_Click(object sender, EventArgs e)
        {
            if (issuedBooksDataGrid.SelectedRows.Count > 0)
            {
                List<int> idToDelete = new List<int>();

                foreach (DataGridViewRow row in issuedBooksDataGrid.SelectedRows)
                {
                    int id = (int)row.Cells["Id"].Value;
                    idToDelete.Add(id);
                }

                if (idToDelete.Count > 1)
                {
                    DialogResult result = MaterialMessageBox.Show(this, "Вы действительно хотите удалить записи?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, false);
                    if (result == DialogResult.Yes)
                    {
                        foreach (var id in idToDelete)
                        {
                            bool deleteResult = issuedBookService.DeleteIssueBookById(id);
                        }
                        issuedBooksDataGrid.DataSource = issuedBookService.GetAll();
                    }
                }
                else
                {
                    DialogResult result = MaterialMessageBox.Show(this, "Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, false);
                    if (result == DialogResult.Yes)
                    {
                        bool deleteResult = issuedBookService.DeleteIssueBookById(idToDelete[0]);
                        issuedBooksDataGrid.DataSource = issuedBookService.GetAll();
                    }
                }
            }
        }

        private void editBookButton_Click(object sender, EventArgs e)
        {
            if (booksDataGrid.SelectedRows.Count > 0)
            {
                int bookId = (int)booksDataGrid.SelectedRows[0].Cells["Id"].Value;

                Book book = bookService.GetBookById(bookId);

                EditBookForm editBookForm = new EditBookForm(book, false, bookService);

                // Если пользователь нажал "Сохранить"
                if (editBookForm.ShowDialog() == DialogResult.OK)
                {
                    bookService.UpdateBook(book);
                    booksDataGrid.DataSource = bookService.GetAllBooks();
                }
            }
        }

        private void deleteBookButton_Click(object sender, EventArgs e)
        {
            if (booksDataGrid.SelectedRows.Count > 0)
            {
                List<int> idToDelete = new List<int>();

                foreach (DataGridViewRow row in booksDataGrid.SelectedRows)
                {
                    int id = (int)row.Cells["Id"].Value;
                    idToDelete.Add(id);
                }

                if (idToDelete.Count > 1)
                {
                    DialogResult result = MaterialMessageBox.Show(this, "Вы действительно хотите удалить записи?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, false);
                    if (result == DialogResult.Yes)
                    {
                        foreach (var id in idToDelete)
                        {
                            bookService.DeleteBook(id);
                        }
                        booksDataGrid.DataSource = bookService.GetAllBooks();
                    }
                }
                else
                {
                    DialogResult result = MaterialMessageBox.Show(this, "Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, false);
                    if (result == DialogResult.Yes)
                    {
                        bookService.DeleteBook(idToDelete[0]);
                        booksDataGrid.DataSource = bookService.GetAllBooks();
                    }
                }
            }
        }

        private void editReaderButton_Click(object sender, EventArgs e)
        {
            if (readersDataGrid.SelectedRows.Count > 0)
            {
                int readerId = (int)readersDataGrid.SelectedRows[0].Cells["Id"].Value;

                Reader reader = readerService.GetReaderById(readerId);

                EditReaderForm editReaderForm = new EditReaderForm(reader, false, readingRoomService, readerService);

                // Если пользователь нажал "Сохранить"
                if (editReaderForm.ShowDialog() == DialogResult.OK)
                {
                    readerService.UpdateReader(reader);
                    readersDataGrid.DataSource = readerService.GetAllReaders();
                }
            }
        }

        private void deleteReaderButton_Click(object sender, EventArgs e)
        {
            if (readersDataGrid.SelectedRows.Count > 0)
            {
                List<int> idToDelete = new List<int>();

                foreach (DataGridViewRow row in readersDataGrid.SelectedRows)
                {
                    int id = (int)row.Cells["Id"].Value;
                    idToDelete.Add(id);
                }

                if (idToDelete.Count > 1)
                {
                    DialogResult result = MaterialMessageBox.Show(this, "Вы действительно хотите удалить записи?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, false);
                    if (result == DialogResult.Yes)
                    {
                        foreach (var id in idToDelete)
                        {
                            readerService.DeleteReaderById(id);
                        }
                        readersDataGrid.DataSource = readerService.GetAllReaders();
                    }
                }
                else
                {
                    DialogResult result = MaterialMessageBox.Show(this, "Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, false);
                    if (result == DialogResult.Yes)
                    {
                        readerService.DeleteReaderById(idToDelete[0]);
                        readersDataGrid.DataSource = readerService.GetAllReaders();
                    }
                }
            }
        }

        private void editReadingRoomButton_Click(object sender, EventArgs e)
        {
            if (readingRoomsDataGrid.SelectedRows.Count > 0)
            {
                int readingRoomId = (int)readingRoomsDataGrid.SelectedRows[0].Cells["Id"].Value;

                ReadingRoom readingRoom = readingRoomService.GetReadingRoomById(readingRoomId);

                EditReadingRoomForm editReadingRoomForm = new EditReadingRoomForm(readingRoom, false);

                // Если пользователь нажал "Сохранить"
                if (editReadingRoomForm.ShowDialog() == DialogResult.OK)
                {
                    readingRoomService.UpdateReadingRoom(readingRoom);
                    readingRoomsDataGrid.DataSource = readingRoomService.GetAllReadingRooms();
                }
            }
        }

        private void deleteReadingRoomButton_Click(object sender, EventArgs e)
        {
            if (readingRoomsDataGrid.SelectedRows.Count > 0)
            {
                List<int> idToDelete = new List<int>();

                foreach (DataGridViewRow row in readingRoomsDataGrid.SelectedRows)
                {
                    int id = (int)row.Cells["Id"].Value;
                    idToDelete.Add(id);
                }

                if (idToDelete.Count > 1)
                {
                    DialogResult result = MaterialMessageBox.Show(this, "Вы действительно хотите удалить записи?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, false);
                    if (result == DialogResult.Yes)
                    {
                        foreach (var id in idToDelete)
                        {
                            readingRoomService.DeleteReadingRoomById(id);
                        }
                        readingRoomsDataGrid.DataSource = readingRoomService.GetAllReadingRooms();
                    }
                }
                else
                {
                    DialogResult result = MaterialMessageBox.Show(this, "Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, false);
                    if (result == DialogResult.Yes)
                    {
                        readingRoomService.DeleteReadingRoomById(idToDelete[0]);
                        readingRoomsDataGrid.DataSource = readingRoomService.GetAllReadingRooms();
                    }
                }
            }
        }

        private void issuedBookFilterApplyButton_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection checkedReaders = issuedBookReaderFilterBox.CheckedItems;
            CheckedListBox.CheckedItemCollection checkedBooks = issuedBookBookFilterBox.CheckedItems;

            List<int> readersId = new List<int>();
            List<int> booksId = new List<int>();
            List<int> unreturnedBooksId = new List<int>();

            if (checkedReaders.Count > 0)
            {
                foreach (var item in checkedReaders)
                {
                    int readerCardNumber = int.Parse(item.ToString().Split(' ').Last());
                    readersId.Add(readerService.GetReaderByLibraryCardNumber(readerCardNumber).Id);
                }
            }

            if (checkedBooks.Count > 0)
            {
                foreach (var item in checkedBooks)
                {
                    string[] titleAndYear = item.ToString().Split(" (");
                    string bookTitle = titleAndYear[0];
                    int bookYear = int.Parse(titleAndYear[1].Replace(")", ""));
                    booksId.Add(bookService.GetBookByTitleAndYear(bookTitle, bookYear).Id);
                }
            }

            if (issuedBookUnreturnedBookFilter.Checked)
            {
                foreach (var item in issuedBookService.GetUreturnedBooks())
                {
                    unreturnedBooksId.Add(item.BookId);
                }
            }

            if (booksId.Count > 0 && unreturnedBooksId.Count > 0)
            {
                var intersectionBooksId = unreturnedBooksId.Intersect(booksId).ToList();

                ApplyFilters(readersId, intersectionBooksId);
            }
            else if (booksId.Count > 0)
            {
                ApplyFilters(readersId, booksId);
            }
            else
            {
                ApplyFilters(readersId, unreturnedBooksId);
            }


        }

        private void ApplyFilters(List<int> readersId, List<int> booksId)
        {
            List<IssuedBook> dataList = issuedBookService.GetAll();
            List<IssuedBook> filteredList;

            if (!readersId.Any() && !booksId.Any())
            {
                filteredList = new List<IssuedBook>();
            }
            else if (readersId.Any() && booksId.Any())
            {
                filteredList = dataList.Where(item =>
                    readersId.Contains(item.ReaderId) &&
                    booksId.Contains(item.BookId)
                   ).ToList();
            }
            else if (readersId.Any())
            {
                filteredList = dataList.Where(item => readersId.Contains(item.ReaderId)).ToList();
            }
            else
            {
                filteredList = dataList.Where(item => booksId.Contains(item.BookId)).ToList();
            }

            issuedBooksDataGrid.DataSource = filteredList;
        }

        private void issuedBookReadersFilterSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = issuedBookReadersFilterSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                for (int i = 0; i < issuedBookReaderFilterBox.Items.Count; i++)
                {
                    issuedBookReaderFilterBox.SetItemChecked(i, false);
                }
            }
            else
            {
                // Фильтруем элементы в соответствии с текстом поиска
                for (int i = 0; i < issuedBookReaderFilterBox.Items.Count; i++)
                {
                    string itemText = issuedBookReaderFilterBox.GetItemText(issuedBookReaderFilterBox.Items[i]);
                    bool isVisible = itemText.Contains(searchText, StringComparison.OrdinalIgnoreCase);
                    issuedBookReaderFilterBox.SetItemChecked(i, isVisible);
                }
            }
        }

        private void issuedBookSelectAllReadersFilter_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < issuedBookReaderFilterBox.Items.Count; i++)
            {
                issuedBookReaderFilterBox.SetItemChecked(i, issuedBookSelectAllReadersFilter.Checked);
            }
        }

        private void issuedBookBooksFilterSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = issuedBookBooksFilterSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                for (int i = 0; i < issuedBookBookFilterBox.Items.Count; i++)
                {
                    issuedBookBookFilterBox.SetItemChecked(i, false);
                }
            }
            else
            {
                // Фильтруем элементы в соответствии с текстом поиска
                for (int i = 0; i < issuedBookBookFilterBox.Items.Count; i++)
                {
                    string itemText = issuedBookBookFilterBox.GetItemText(issuedBookBookFilterBox.Items[i]);
                    bool isVisible = itemText.Contains(searchText, StringComparison.OrdinalIgnoreCase);
                    issuedBookBookFilterBox.SetItemChecked(i, isVisible);
                }
            }
        }

        private void issuedBookSelectAllBooksFilter_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < issuedBookBookFilterBox.Items.Count; i++)
            {
                issuedBookBookFilterBox.SetItemChecked(i, issuedBookSelectAllBooksFilter.Checked);
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < issuedBookReaderFilterBox.Items.Count; i++)
            {
                issuedBookReaderFilterBox.SetItemChecked(i, false);
            }

            for (int i = 0; i < issuedBookBookFilterBox.Items.Count; i++)
            {
                issuedBookBookFilterBox.SetItemChecked(i, false);
            }

            issuedBookUnreturnedBookFilter.Checked = false;
            issuedBookSelectAllBooksFilter.Checked = false;
            issuedBookSelectAllReadersFilter.Checked = false;

            issuedBookReadersFilterSearch.Text = string.Empty;
            issuedBookBooksFilterSearch.Text = string.Empty;

            issuedBooksDataGrid.DataSource = issuedBookService.GetAll();
        }
    }
}
