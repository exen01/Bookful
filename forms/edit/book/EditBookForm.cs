using Bookful.domain.dto;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Bookful.forms.edit
{
    public partial class EditBookForm : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;
        private Book book;

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
                Text = String.Format("Редактирование книги {0}", book.Title);

                this.book = book;
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
            // Заполнение полей формы данными о книге
            titleInput.Text = book.Title;
            authorInput.Text = book.Author;
            descriptionInput.Text = book.Description;
            publishingHouseInput.Text = book.PublishingHouse;
            publicationDateInput.Value = DateTime.Parse(book.PublicationDate.ToString());
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Сохранение изменений в книге
            book.Title = titleInput.Text;
            book.Author = authorInput.Text;
            book.Description = descriptionInput.Text;
            book.PublishingHouse = publishingHouseInput.Text;
            book.PublicationDate = DateOnly.FromDateTime(publicationDateInput.Value);

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
