namespace Bookful.forms.edit.reader
{
    partial class EditReaderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            nameInput = new MaterialSkin.Controls.MaterialTextBox();
            lastNameInput = new MaterialSkin.Controls.MaterialTextBox();
            libraryCardNumberInput = new NumericUpDown();
            registrationDateInput = new DateTimePicker();
            saveButton = new MaterialSkin.Controls.MaterialButton();
            cancelButton = new MaterialSkin.Controls.MaterialButton();
            readingRoomInput = new MaterialSkin.Controls.MaterialComboBox();
            firstNameLabel = new MaterialSkin.Controls.MaterialLabel();
            lastNameLabel = new MaterialSkin.Controls.MaterialLabel();
            libraryCardNumberLabel = new MaterialSkin.Controls.MaterialLabel();
            readingRoomLabel = new MaterialSkin.Controls.MaterialLabel();
            registrationDateLabel = new MaterialSkin.Controls.MaterialLabel();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)libraryCardNumberInput).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(nameInput, 2, 1);
            tableLayoutPanel1.Controls.Add(lastNameInput, 2, 2);
            tableLayoutPanel1.Controls.Add(libraryCardNumberInput, 2, 3);
            tableLayoutPanel1.Controls.Add(registrationDateInput, 2, 5);
            tableLayoutPanel1.Controls.Add(saveButton, 1, 6);
            tableLayoutPanel1.Controls.Add(cancelButton, 2, 6);
            tableLayoutPanel1.Controls.Add(readingRoomInput, 2, 4);
            tableLayoutPanel1.Controls.Add(firstNameLabel, 1, 1);
            tableLayoutPanel1.Controls.Add(lastNameLabel, 1, 2);
            tableLayoutPanel1.Controls.Add(libraryCardNumberLabel, 1, 3);
            tableLayoutPanel1.Controls.Add(readingRoomLabel, 1, 4);
            tableLayoutPanel1.Controls.Add(registrationDateLabel, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 64);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(794, 383);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // nameInput
            // 
            nameInput.AnimateReadOnly = false;
            nameInput.BorderStyle = BorderStyle.None;
            nameInput.Depth = 0;
            nameInput.Dock = DockStyle.Fill;
            nameInput.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            nameInput.LeadingIcon = null;
            nameInput.Location = new Point(416, 54);
            nameInput.MaxLength = 50;
            nameInput.MouseState = MaterialSkin.MouseState.OUT;
            nameInput.Multiline = false;
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(192, 50);
            nameInput.TabIndex = 0;
            nameInput.Text = "";
            nameInput.TrailingIcon = null;
            // 
            // lastNameInput
            // 
            lastNameInput.AnimateReadOnly = false;
            lastNameInput.BorderStyle = BorderStyle.None;
            lastNameInput.Depth = 0;
            lastNameInput.Dock = DockStyle.Fill;
            lastNameInput.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lastNameInput.LeadingIcon = null;
            lastNameInput.Location = new Point(416, 110);
            lastNameInput.MaxLength = 50;
            lastNameInput.MouseState = MaterialSkin.MouseState.OUT;
            lastNameInput.Multiline = false;
            lastNameInput.Name = "lastNameInput";
            lastNameInput.Size = new Size(192, 50);
            lastNameInput.TabIndex = 1;
            lastNameInput.Text = "";
            lastNameInput.TrailingIcon = null;
            // 
            // libraryCardNumberInput
            // 
            libraryCardNumberInput.AutoSize = true;
            libraryCardNumberInput.Dock = DockStyle.Fill;
            libraryCardNumberInput.Location = new Point(416, 166);
            libraryCardNumberInput.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            libraryCardNumberInput.Name = "libraryCardNumberInput";
            libraryCardNumberInput.Size = new Size(192, 27);
            libraryCardNumberInput.TabIndex = 2;
            // 
            // registrationDateInput
            // 
            registrationDateInput.CustomFormat = "dd.MM.yyyy";
            registrationDateInput.Dock = DockStyle.Fill;
            registrationDateInput.Format = DateTimePickerFormat.Custom;
            registrationDateInput.Location = new Point(416, 254);
            registrationDateInput.Name = "registrationDateInput";
            registrationDateInput.Size = new Size(192, 27);
            registrationDateInput.TabIndex = 4;
            // 
            // saveButton
            // 
            saveButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            saveButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            saveButton.Depth = 0;
            saveButton.Dock = DockStyle.Fill;
            saveButton.HighEmphasis = true;
            saveButton.Icon = null;
            saveButton.Location = new Point(186, 290);
            saveButton.Margin = new Padding(4, 6, 4, 6);
            saveButton.MouseState = MaterialSkin.MouseState.HOVER;
            saveButton.Name = "saveButton";
            saveButton.NoAccentTextColor = Color.Empty;
            saveButton.Size = new Size(223, 36);
            saveButton.TabIndex = 5;
            saveButton.Text = "Сохранить";
            saveButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            saveButton.UseAccentColor = false;
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cancelButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            cancelButton.Depth = 0;
            cancelButton.Dock = DockStyle.Fill;
            cancelButton.HighEmphasis = true;
            cancelButton.Icon = null;
            cancelButton.Location = new Point(417, 290);
            cancelButton.Margin = new Padding(4, 6, 4, 6);
            cancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            cancelButton.Name = "cancelButton";
            cancelButton.NoAccentTextColor = Color.Empty;
            cancelButton.Size = new Size(190, 36);
            cancelButton.TabIndex = 6;
            cancelButton.Text = "Отмена";
            cancelButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            cancelButton.UseAccentColor = false;
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // readingRoomInput
            // 
            readingRoomInput.AutoResize = false;
            readingRoomInput.BackColor = Color.FromArgb(255, 255, 255);
            readingRoomInput.Depth = 0;
            readingRoomInput.Dock = DockStyle.Fill;
            readingRoomInput.DrawMode = DrawMode.OwnerDrawVariable;
            readingRoomInput.DropDownHeight = 174;
            readingRoomInput.DropDownStyle = ComboBoxStyle.DropDownList;
            readingRoomInput.DropDownWidth = 121;
            readingRoomInput.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            readingRoomInput.ForeColor = Color.FromArgb(222, 0, 0, 0);
            readingRoomInput.FormattingEnabled = true;
            readingRoomInput.IntegralHeight = false;
            readingRoomInput.ItemHeight = 43;
            readingRoomInput.Location = new Point(416, 199);
            readingRoomInput.MaxDropDownItems = 4;
            readingRoomInput.MouseState = MaterialSkin.MouseState.OUT;
            readingRoomInput.Name = "readingRoomInput";
            readingRoomInput.Size = new Size(192, 49);
            readingRoomInput.StartIndex = 0;
            readingRoomInput.TabIndex = 7;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Depth = 0;
            firstNameLabel.Dock = DockStyle.Fill;
            firstNameLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            firstNameLabel.Location = new Point(185, 51);
            firstNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(225, 56);
            firstNameLabel.TabIndex = 8;
            firstNameLabel.Text = "Имя:";
            firstNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Depth = 0;
            lastNameLabel.Dock = DockStyle.Fill;
            lastNameLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lastNameLabel.Location = new Point(185, 107);
            lastNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(225, 56);
            lastNameLabel.TabIndex = 9;
            lastNameLabel.Text = "Фамилия:";
            lastNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // libraryCardNumberLabel
            // 
            libraryCardNumberLabel.AutoSize = true;
            libraryCardNumberLabel.Depth = 0;
            libraryCardNumberLabel.Dock = DockStyle.Fill;
            libraryCardNumberLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            libraryCardNumberLabel.Location = new Point(185, 163);
            libraryCardNumberLabel.MouseState = MaterialSkin.MouseState.HOVER;
            libraryCardNumberLabel.Name = "libraryCardNumberLabel";
            libraryCardNumberLabel.Size = new Size(225, 33);
            libraryCardNumberLabel.TabIndex = 10;
            libraryCardNumberLabel.Text = "Номер читательского билета:";
            libraryCardNumberLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // readingRoomLabel
            // 
            readingRoomLabel.AutoSize = true;
            readingRoomLabel.Depth = 0;
            readingRoomLabel.Dock = DockStyle.Fill;
            readingRoomLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            readingRoomLabel.Location = new Point(185, 196);
            readingRoomLabel.MouseState = MaterialSkin.MouseState.HOVER;
            readingRoomLabel.Name = "readingRoomLabel";
            readingRoomLabel.Size = new Size(225, 55);
            readingRoomLabel.TabIndex = 11;
            readingRoomLabel.Text = "Номер читального зала:";
            readingRoomLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // registrationDateLabel
            // 
            registrationDateLabel.AutoSize = true;
            registrationDateLabel.Depth = 0;
            registrationDateLabel.Dock = DockStyle.Fill;
            registrationDateLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            registrationDateLabel.Location = new Point(185, 251);
            registrationDateLabel.MouseState = MaterialSkin.MouseState.HOVER;
            registrationDateLabel.Name = "registrationDateLabel";
            registrationDateLabel.Size = new Size(225, 33);
            registrationDateLabel.TabIndex = 12;
            registrationDateLabel.Text = "Дата регистрации:";
            registrationDateLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // EditReaderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "EditReaderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditReaderForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)libraryCardNumberInput).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialTextBox nameInput;
        private MaterialSkin.Controls.MaterialTextBox lastNameInput;
        private NumericUpDown libraryCardNumberInput;
        private DateTimePicker registrationDateInput;
        private MaterialSkin.Controls.MaterialButton saveButton;
        private MaterialSkin.Controls.MaterialButton cancelButton;
        private MaterialSkin.Controls.MaterialComboBox readingRoomInput;
        private MaterialSkin.Controls.MaterialLabel firstNameLabel;
        private MaterialSkin.Controls.MaterialLabel lastNameLabel;
        private MaterialSkin.Controls.MaterialLabel libraryCardNumberLabel;
        private MaterialSkin.Controls.MaterialLabel readingRoomLabel;
        private MaterialSkin.Controls.MaterialLabel registrationDateLabel;
    }
}