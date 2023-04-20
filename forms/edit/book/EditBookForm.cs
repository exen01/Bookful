using Bookful.domain.dto;
using Bookful.service.book;

namespace Bookful.forms.edit
{
    public partial class EditBookForm : Form
    {
        private Book book;
        private IBookService bookService;

        public EditBookForm(Book book, bool isNewBook)
        {
            InitializeComponent();

            if (isNewBook)
            {
                this.book = book;
                Text = "Добавить книгу";
                saveButton.Text = "Добавить";
            }
            else
            {
                this.book = book;
                InitializeForm();
            }
        }

        private void InitializeForm()
        {
            // Заполнение полей формы данными о книге
            titleInput.Text = book.Title;
            authorInput.Text = book.Author;
            descriptionInput.Text = book.Description;
            publishingHouseInput.Text = book.PublishingHouse;
            publicationDateInput.Value = DateTime.Parse(book.PublicationDate);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Сохранение изменений в книге
            book.Title = titleInput.Text;
            book.Author = authorInput.Text;
            book.Description = descriptionInput.Text;
            book.PublishingHouse = publishingHouseInput.Text;
            book.PublicationDate = publicationDateInput.Value.ToString("yyyy-MM-dd");

            DialogResult = DialogResult.OK;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
