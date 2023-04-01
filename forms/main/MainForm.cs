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
        public MainForm()
        {
            InitializeComponent();

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
            var booksUpdateButton = new ToolStripMenuItem()
            {
                Text = "Update",
            };
            booksToolBar.Items.AddRange(new ToolStripItem[] { booksAddButton, booksUpdateButton });

            var booksDataGrid = new DataGridView()
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                
            };
            booksDataGrid.Columns.Add("Book title", "Book title");
            booksDataGrid.Columns.Add("Book title", "Book title");
            booksDataGrid.Columns.Add("Book title", "Book title");

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
    }
}
