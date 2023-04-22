using Bookful.dao.user;
using Bookful.domain.exception;
using Bookful.service.user;
using Bookful.util;
using Bookful.util.db;

namespace Bookful
{
    public partial class RegistrationForm : Form
    {
        private UserService userService;
        private TextBox loginInput;
        private TextBox passwordInput;

        public RegistrationForm()
        {
            InitializeComponent();

            var userDao = new UserDaoImpl(DBConnection.Instance());
            userService = new UserService(userDao);

            var loginLabel = new Label()
            {
                Text = "Login",
                Dock = DockStyle.Left,
            };

            loginInput = new TextBox()
            {
                Dock = DockStyle.Fill,
            };

            var passwordLabel = new Label()
            {
                Text = "Password",
                Dock = DockStyle.Fill,
            };

            passwordInput = new TextBox()
            {
                Dock = DockStyle.Fill,
                UseSystemPasswordChar = true
            };

            var registrationButton = new Button()
            {
                Text = "Зарегистрироваться",
                Dock = DockStyle.Fill
            };
            registrationButton.Click += Registration;

            var showPassword = new CheckBox()
            {
                Dock = DockStyle.Fill,
                Text = "Show Password",
            };
            showPassword.CheckedChanged += (object sender, EventArgs args) =>
            {
                if (showPassword.Checked)
                {
                    passwordInput.UseSystemPasswordChar = false;
                }
                else
                {
                    passwordInput.UseSystemPasswordChar = true;
                }
            };

            var tableLayout = new TableLayoutPanel();
            tableLayout.RowStyles.Clear();

            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50)); // 1 строка пустая панель
            tableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize, 15)); // 2 строка логин лейбл
            tableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize, 25)); // 3 строка логин инпут
            tableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize, 15)); // 4 строка пароль лейбл
            tableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize, 25)); // 5 строка пароль инпут
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 60)); // 6 строка кнопка
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50)); // 7 строка пустая панель

            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50)); // 1 колонка
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50)); // 2 колонка
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50)); // 3 колонка

            tableLayout.Controls.Add(new Panel(), 0, 0);
            tableLayout.Controls.Add(loginLabel, 1, 1);
            tableLayout.Controls.Add(loginInput, 1, 2);
            tableLayout.Controls.Add(passwordLabel, 1, 3);
            tableLayout.Controls.Add(passwordInput, 1, 4);
            tableLayout.Controls.Add(showPassword, 2, 4);
            tableLayout.Controls.Add(registrationButton, 1, 5);
            tableLayout.Controls.Add(new Panel(), 2, 6);

            tableLayout.Dock = DockStyle.Fill;
            Controls.Add(tableLayout);

        }

        private void Registration(object sender, EventArgs args)
        {
            try
            {
                if (ValidationUtils.ValidateLogin(loginInput.Text) & ValidationUtils.ValidatePassword(passwordInput.Text))
                {
                    userService.Registration(loginInput.Text, passwordInput.Text);
                }
            }
            catch (CommonException ex)
            {
                MessageBox.Show(ex.UserMessage);
            }

        }
    }
}