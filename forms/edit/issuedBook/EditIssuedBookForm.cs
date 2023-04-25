using Bookful.domain.dto;
using Bookful.service.book;
using Bookful.service.reader;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Bookful.forms.edit.issuedBook
{
    public partial class EditIssuedBookForm : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;
        private IssuedBook issuedBook;
        private IBookService bookService;
        private IReaderService readerService;
        private List<Book> books;
        private List<Reader> readers;

        public EditIssuedBookForm(IssuedBook issuedBook, bool isNewIssueBook, IBookService bookService, IReaderService readerService)
        {
            InitializeComponent();

            this.bookService = bookService;
            this.readerService = readerService;
            this.issuedBook = issuedBook;

            books = bookService.GetAllBooks();
            readers = readerService.GetAllReaders();

            InitializeReadersList();
            InitializeBooksList();

            if (isNewIssueBook)
            {
                Text = "Добавить выданную книгу";
                saveButton.Text = "Добавить";
            }
            else
            {
                Text = string.Format("Редактирование выданной книги");
                InitializeForm();
            }

            // Создаем и настраиваем менеджер оформления MaterialSkin
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        private void InitializeForm()
        {
            var returnDate = issuedBook.ReturnDate;
            if (returnDate == null)
            {
                isBookReturned.Checked = true;
                returnDateInput.Enabled = false;
            }
            else
            {
                returnDateInput.Value = DateTime.Parse(returnDate.ToString());
            }

            readerInput.SelectedValue = issuedBook.ReaderId;
            bookInput.SelectedValue = issuedBook.BookId;
            issueDateInput.Value = DateTime.Parse(issuedBook.IssueDate.ToString());
            expectedReturnDateInput.Value = DateTime.Parse(issuedBook.ExpectedReturnDate.ToString());
        }

        private void InitializeBooksList()
        {
            bookInput.DataSource = books;
            bookInput.DisplayMember = "DisplayTitleYear";
            bookInput.ValueMember = "Id";
        }

        private void InitializeReadersList()
        {
            readerInput.DataSource = readers;
            readerInput.DisplayMember = "DisplayFullNameCardNumber";
            readerInput.ValueMember = "Id";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!isBookReturned.Checked)
            {
                issuedBook.ReturnDate = DateOnly.FromDateTime(returnDateInput.Value);
            }
            else
            {
                issuedBook.ReturnDate = null;
            }

            issuedBook.ReaderId = int.Parse(readerInput.SelectedValue.ToString());
            issuedBook.BookId = int.Parse(bookInput.SelectedValue.ToString());
            issuedBook.IssueDate = DateOnly.FromDateTime(issueDateInput.Value);
            issuedBook.ExpectedReturnDate = DateOnly.FromDateTime(expectedReturnDateInput.Value);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void isBookReturned_CheckedChanged(object sender, EventArgs e)
        {
            returnDateInput.Enabled = !returnDateInput.Enabled;
        }
    }
}
