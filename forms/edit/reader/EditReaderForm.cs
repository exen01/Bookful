using Bookful.domain.dto;
using Bookful.service.reader;
using Bookful.service.readingRoom;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Bookful.forms.edit.reader
{
    public partial class EditReaderForm : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;
        private Reader reader;
        private IReadingRoomService readingRoomService;
        private List<ReadingRoom> rooms;
        private IReaderService readerService;

        public EditReaderForm(Reader reader, bool isNewReader, IReadingRoomService readingRoomService, IReaderService readerService)
        {
            InitializeComponent();

            this.readingRoomService = readingRoomService;
            this.readerService = readerService;
            
            rooms = readingRoomService.GetAllReadingRooms();

            if (isNewReader)
            {
                this.reader = reader;
                Text = "Добавить читателя";
                saveButton.Text = "Добавить";
                InitializeReadingRoomsList();
            }
            else
            {
                this.reader = reader;

                Text = String.Format("Редактирование читателя {0} {1}", reader.FirstName, reader.LastName);

                InitializeReadingRoomsList();
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
            nameInput.Text = reader.FirstName;
            lastNameInput.Text = reader.LastName;
            libraryCardNumberInput.Value = reader.LibraryCardNumber;
            readingRoomInput.SelectedValue = reader.ReadingRoomId;
            registrationDateInput.Value = DateTime.Parse(reader.RegistrationDate.ToString());
        }

        private void InitializeReadingRoomsList()
        {
            readingRoomInput.DataSource = rooms;
            readingRoomInput.ValueMember = "Id";
            readingRoomInput.DisplayMember = "Number";
            readingRoomInput.SelectedItem = readingRoomInput.Items[0];
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            reader.FirstName = nameInput.Text;
            reader.LastName = lastNameInput.Text;
            reader.LibraryCardNumber = (int)libraryCardNumberInput.Value;
            reader.ReadingRoomId = int.Parse(readingRoomInput.SelectedValue.ToString());
            reader.RegistrationDate = DateOnly.FromDateTime(registrationDateInput.Value);

            if(readerService.GetReaderByLibraryCardNumber(reader.LibraryCardNumber).FirstName == null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MaterialMessageBox.Show("Читатель с таким номером читательского билета уже существует", "Ошибка", false);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
