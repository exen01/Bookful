using Bookful.domain.dto;
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

        public EditReaderForm(Reader reader, bool isNewReader, IReadingRoomService readingRoomService)
        {
            InitializeComponent();

            this.readingRoomService = readingRoomService;
            this.rooms = readingRoomService.GetAllReadingRooms();

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
            readingRoomInput.SelectedItem = readingRoomService.GetReadingRoomNumberById(reader.ReadingRoomId);
            registrationDateInput.Value = DateTime.Parse(reader.RegistrationDate.ToString());
        }

        private void InitializeReadingRoomsList()
        {
            foreach (var room in rooms)
            {
                readingRoomInput.Items.Add(room.Number);
            }
            readingRoomInput.SelectedItem = readingRoomInput.Items[0];
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            reader.FirstName = nameInput.Text;
            reader.LastName = lastNameInput.Text;
            reader.LibraryCardNumber = (int)libraryCardNumberInput.Value;
            reader.ReadingRoomId = rooms.Find(r => r.Number == int.Parse(readingRoomInput.SelectedItem.ToString())).Id;
            reader.RegistrationDate = DateOnly.FromDateTime(registrationDateInput.Value);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
