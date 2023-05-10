using Bookful.domain.dto;
using Bookful.domain.exception;
using Bookful.util;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Bookful.forms.edit
{
    public partial class EditReadingRoomForm : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;
        private ReadingRoom readingRoom;

        public EditReadingRoomForm(ReadingRoom readingRoom, bool isNewReadingRoom)
        {
            InitializeComponent();

            if (isNewReadingRoom)
            {
                this.readingRoom = readingRoom;
                Text = "Добавить читальный зал";
                saveButton.Text = "Добавить";
            }
            else
            {
                Text = String.Format("Редактирование читального зала {0}", readingRoom.Number);

                this.readingRoom = readingRoom;
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
            roomNumberInput.Value = readingRoom.Number;
            specializationInput.Text = readingRoom.Specialization;
            numberOfSeatsInput.Value = readingRoom.SeatsCount;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            readingRoom.Number = (int)roomNumberInput.Value;
            readingRoom.Specialization = specializationInput.Text;
            readingRoom.SeatsCount = (int)numberOfSeatsInput.Value;

            try
            {
                ValidationUtils.ValidateSpecialization(readingRoom.Specialization);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (CommonException exception)
            {
                MaterialMessageBox.Show(exception.UserMessage, "Ошибка", false);
            }


        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
