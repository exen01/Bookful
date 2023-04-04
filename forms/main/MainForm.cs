using Bookful.domain.dto;
using Bookful.forms.edit;
using Bookful.service.book;
using Bookful.util.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookful.forms.main
{
    public partial class MainForm : Form
    {
        private IBookService bookService;
        private DataGridView booksDataGrid;

        public MainForm()
        {
            InitializeComponent();

            bookService = new BookServiceImpl(DBConnection.Instance());

            // боковое меню
            var groupBox = new GroupBox()
            {
                Text = "Быстрые действия",
                Dock = DockStyle.Fill,
            };

            var button = new Button()
            {
                Text = "Create new user",
                Dock = DockStyle.Top,
                AutoSize = true,
            };

            var button1 = new Button()
            {
                Text = "asdasdasd",
                Dock = DockStyle.Top,
                AutoSize = true,
            };

            groupBox.Controls.AddRange(new Control[] { button, button1 });

            // основные вкладки
            var tabControl = new TabControl()
            {
                Dock = DockStyle.Fill,
            };

            // вкладка каталога книг
            var bookCatalog = new TabPage()
            {
                Text = "Каталог книг"
            };

            var bookCatalogLayout = new TableLayoutPanel()
            {
                Dock = DockStyle.Fill,
            };

            var booksToolBar = new MenuStrip()
            {
                //Dock = DockStyle.Fill,
                Stretch = true,
            };

            var booksAddButton = new ToolStripMenuItem()
            {
                Text = "Add",
            };

            var booksRefreshButton = new ToolStripMenuItem()
            {
                Text = "Обновить",
            };
            booksRefreshButton.Click += BooksRefreshButton_Click;

            booksToolBar.Items.AddRange(new ToolStripItem[] { booksAddButton, booksRefreshButton });

            booksDataGrid = new DataGridView()
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true,
            };

            var books = bookService.GetAllBooks();
            booksDataGrid.DataSource = books;
            booksDataGrid.CellContentClick += BooksDataGrid_CellContentClick;

            bookCatalogLayout.Controls.Add(booksToolBar, 0, 0);
            bookCatalogLayout.Controls.Add(booksDataGrid, 0, 1);

            bookCatalog.Controls.Add(bookCatalogLayout);

            // вкладка читателей
            var readers = new TabPage()
            {
                Text = "Читатели"
            };

            // вкладка выданных книг
            var issuedBooks = new TabPage()
            {
                Text = "Выданные книги"
            };

            tabControl.Controls.AddRange(new Control[] { bookCatalog, readers, issuedBooks });

            var tableLayout = new TableLayoutPanel();
            tableLayout.RowStyles.Clear();

            tableLayout.Controls.Add(groupBox, 0, 0);
            tableLayout.Controls.Add(tabControl, 1, 0);

            tableLayout.Dock = DockStyle.Fill;
            Controls.Add(tableLayout);
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
                EditBookForm editBookForm = new EditBookForm(book);

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

        private void BooksRefreshButton_Click(object? sender, EventArgs e)
        {
            var books = bookService.GetAllBooks();
            booksDataGrid.DataSource = books;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            booksDataGrid.Columns["Id"].HeaderText = "ID книги";
            booksDataGrid.Columns["Title"].HeaderText = "Название";
            booksDataGrid.Columns["Author"].HeaderText = "Автор";
            booksDataGrid.Columns["Description"].HeaderText = "Описание";
            booksDataGrid.Columns["PublishingHouse"].HeaderText = "Издательство";
            booksDataGrid.Columns["PublicationDate"].HeaderText = "Дата публикации";

            // Создаем колонку с кнопками удаления
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Удалить";
            deleteButtonColumn.Name = "DeleteButton";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            deleteButtonColumn.Text = "Удалить";

            // Добавляем колонку в DataGridView
            booksDataGrid.Columns.Add(deleteButtonColumn);

            // Создаем колонку с кнопками редактирования
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.HeaderText = "Изменить";
            editButtonColumn.Name = "EditButton";
            editButtonColumn.UseColumnTextForButtonValue = true;
            editButtonColumn.Text = "Изменить";

            // Добавляем колонку в DataGridView
            booksDataGrid.Columns.Add(editButtonColumn);


        }
    }
}
