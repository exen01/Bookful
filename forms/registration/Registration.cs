namespace Bookful
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();

            var loginLabel = new Label()
            {
                Text = "Login",
                Dock = DockStyle.Left,
            };

            var loginInput = new TextBox()
            {
                Dock = DockStyle.Fill,
            };

            var passwordLabel = new Label()
            {
                Text = "Password",
                Dock = DockStyle.Fill,
            };

            var passwordInput = new TextBox()
            {
                Dock = DockStyle.Fill
            };

            var registrationButton = new Button()
            {
                Text = "������������������",
                Dock = DockStyle.Fill
            };

            var tableLayout = new TableLayoutPanel();
            tableLayout.RowStyles.Clear();

            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50)); // 1 ������ ������ ������
            tableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize, 15)); // 2 ������ ����� �����
            tableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize, 25)); // 3 ������ ����� �����
            tableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize, 15)); // 4 ������ ������ �����
            tableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize, 25)); // 5 ������ ������ �����
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 60)); // 6 ������ ������
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50)); // 7 ������ ������ ������

            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50)); // 1 �������
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50)); // 2 �������
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50)); // 3 �������

            tableLayout.Controls.Add(new Panel(), 0, 0);
            tableLayout.Controls.Add(loginLabel, 1, 1);
            tableLayout.Controls.Add(loginInput, 1, 2);
            tableLayout.Controls.Add(passwordLabel, 1, 3);
            tableLayout.Controls.Add(passwordInput, 1, 4);
            tableLayout.Controls.Add(registrationButton, 1, 5);
            tableLayout.Controls.Add(new Panel(), 2, 6);

            tableLayout.Dock = DockStyle.Fill;
            Controls.Add(tableLayout);

        }

    }
}