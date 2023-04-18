using Bookful.domain.dto;

namespace Bookful.forms.edit
{
    public partial class EditReadingRoomForm : Form
    {
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
                this.readingRoom = readingRoom;
                InitializeForm();
            }
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
