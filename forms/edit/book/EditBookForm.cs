using Bookful.domain.dto;
using Bookful.domain.exception;
using Bookful.service.book;
using Bookful.util;
using MaterialSkin;
using MaterialSkin.Controls;
using System;

namespace Bookful.forms.edit
{
    public partial class EditBookForm : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;
        private Book book;
        private IBookService bookService;
        private List<string> authorsList;
        private List<string> publishingHousesList;

        public EditBookForm(Book book, bool isNewBook, IBookService bookService)
        {
            InitializeComponent();

            this.bookService = bookService;

            if (isNewBook)
            {
                this.book = book;
                Text = "Добавить книгу";
                saveButton.Text = "Добавить";
                InitializeLists();
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

        private void InitializeLists()
        {
            authorsList = bookService.GetAllAuthors();
            authorsList.Add("Добавить нового автора...");

            authorInput.DataSource = authorsList;

            publishingHousesList = bookService.GetAllPublishingHouses();
            publishingHousesList.Add("Добавить новое издательство...");

            publishingHouseInput.DataSource = publishingHousesList;

            SetDropDownWidth(authorInput);
            SetDropDownWidth(publishingHouseInput);
        }

        private void InitializeForm()
        {
            // Заполнение полей формы данными о книге
            titleInput.Text = book.Title;
            InitializeLists();
            authorInput.SelectedItem = book.Author;
            descriptionInput.Text = book.Description;
            publishingHouseInput.SelectedItem = book.PublishingHouse;
            publicationDateInput.Value = DateTime.Parse(book.PublicationDate.ToString());
            quantityInput.Value = book.Quantity;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Сохранение изменений в книге
            book.Title = titleInput.Text;
            book.Author = authorInput.Text;
            book.Description = descriptionInput.Text;
            book.PublishingHouse = publishingHouseInput.Text;
            book.PublicationDate = DateOnly.FromDateTime(publicationDateInput.Value);
            book.Quantity = (int)quantityInput.Value;

            if (ValidateBook(book))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void authorInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (authorInput.SelectedIndex == authorInput.Items.Count - 1)
            {
                string author = Microsoft.VisualBasic.Interaction.InputBox("Введите имя автора:", "Добавить автора");
                if (!string.IsNullOrEmpty(author))
                {
                    authorsList.Remove("Добавить нового автора...");
                    authorsList.Add(author);
                    authorsList.Add("Добавить нового автора...");
                    authorInput.DataSource = null;
                    authorInput.DataSource = authorsList;
                    authorInput.SelectedItem = author;
                }
                else
                {
                    authorInput.SelectedItem = authorInput.Items[0];
                }
            }
        }

        // Установка ширины выпадающего списка ComboBox на основе самого широкого элемента
        private void SetDropDownWidth(MaterialComboBox comboBox)
        {
            int maxWidth = 0;
            foreach (var item in comboBox.Items)
            {
                int itemWidth = TextRenderer.MeasureText(comboBox.GetItemText(item), comboBox.Font).Width;
                maxWidth = Math.Max(maxWidth, itemWidth);
            }
            comboBox.DropDownWidth = maxWidth + SystemInformation.VerticalScrollBarWidth;
        }

        private void publishingHouseInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (publishingHouseInput.SelectedIndex == publishingHouseInput.Items.Count - 1)
            {
                string publishingHouse = Microsoft.VisualBasic.Interaction.InputBox("Введите название издательства:", "Добавить издательство");
                if (!string.IsNullOrEmpty(publishingHouse))
                {
                    publishingHousesList.Remove("Добавить новое издательство...");
                    publishingHousesList.Add(publishingHouse);
                    publishingHousesList.Add("Добавить новое издательство...");
                    publishingHouseInput.DataSource = null;
                    publishingHouseInput.DataSource = publishingHousesList;
                    publishingHouseInput.SelectedItem = publishingHouse;
                }
                else
                {
                    publishingHouseInput.SelectedItem = publishingHouseInput.Items[0];
                }
            }
        }

        private bool ValidateBook(Book book)
        {
            bool result = false;
            try
            {
                result = ValidationUtils.ValidateBookTitle(book.Title) &&
                ValidationUtils.ValidateBookAuthor(book.Author) &&
                ValidationUtils.ValidateBookPublicationHouse(book.PublishingHouse);
            }
            catch (CommonException exception)
            {
                MaterialMessageBox.Show(exception.UserMessage, "Ошибка", false);
            }

            return result;
        }
    }
}
