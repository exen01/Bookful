namespace Bookful.forms.edit.issuedBook
{
    partial class EditIssuedBookForm
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
            IssuedBookTableLayout = new TableLayoutPanel();
            readerInputLabel = new MaterialSkin.Controls.MaterialLabel();
            readerInput = new MaterialSkin.Controls.MaterialComboBox();
            bookLabel = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            returnDateLabel = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            saveButton = new MaterialSkin.Controls.MaterialButton();
            cancelButton = new MaterialSkin.Controls.MaterialButton();
            bookInput = new MaterialSkin.Controls.MaterialComboBox();
            issueDateInput = new DateTimePicker();
            returnDateInput = new DateTimePicker();
            expectedReturnDateInput = new DateTimePicker();
            isBookReturned = new MaterialSkin.Controls.MaterialCheckbox();
            IssuedBookTableLayout.SuspendLayout();
            SuspendLayout();
            // 
            // IssuedBookTableLayout
            // 
            IssuedBookTableLayout.ColumnCount = 5;
            IssuedBookTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            IssuedBookTableLayout.ColumnStyles.Add(new ColumnStyle());
            IssuedBookTableLayout.ColumnStyles.Add(new ColumnStyle());
            IssuedBookTableLayout.ColumnStyles.Add(new ColumnStyle());
            IssuedBookTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            IssuedBookTableLayout.Controls.Add(readerInputLabel, 1, 1);
            IssuedBookTableLayout.Controls.Add(readerInput, 2, 1);
            IssuedBookTableLayout.Controls.Add(bookLabel, 1, 2);
            IssuedBookTableLayout.Controls.Add(materialLabel2, 1, 3);
            IssuedBookTableLayout.Controls.Add(returnDateLabel, 1, 4);
            IssuedBookTableLayout.Controls.Add(materialLabel4, 1, 5);
            IssuedBookTableLayout.Controls.Add(saveButton, 1, 6);
            IssuedBookTableLayout.Controls.Add(cancelButton, 2, 6);
            IssuedBookTableLayout.Controls.Add(bookInput, 2, 2);
            IssuedBookTableLayout.Controls.Add(issueDateInput, 2, 3);
            IssuedBookTableLayout.Controls.Add(returnDateInput, 2, 4);
            IssuedBookTableLayout.Controls.Add(expectedReturnDateInput, 2, 5);
            IssuedBookTableLayout.Controls.Add(isBookReturned, 3, 4);
            IssuedBookTableLayout.Dock = DockStyle.Fill;
            IssuedBookTableLayout.Location = new Point(3, 64);
            IssuedBookTableLayout.Name = "IssuedBookTableLayout";
            IssuedBookTableLayout.RowCount = 8;
            IssuedBookTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            IssuedBookTableLayout.RowStyles.Add(new RowStyle());
            IssuedBookTableLayout.RowStyles.Add(new RowStyle());
            IssuedBookTableLayout.RowStyles.Add(new RowStyle());
            IssuedBookTableLayout.RowStyles.Add(new RowStyle());
            IssuedBookTableLayout.RowStyles.Add(new RowStyle());
            IssuedBookTableLayout.RowStyles.Add(new RowStyle());
            IssuedBookTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            IssuedBookTableLayout.Size = new Size(856, 440);
            IssuedBookTableLayout.TabIndex = 0;
            // 
            // readerInputLabel
            // 
            readerInputLabel.AutoSize = true;
            readerInputLabel.Depth = 0;
            readerInputLabel.Dock = DockStyle.Fill;
            readerInputLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            readerInputLabel.Location = new Point(22, 89);
            readerInputLabel.MouseState = MaterialSkin.MouseState.HOVER;
            readerInputLabel.Name = "readerInputLabel";
            readerInputLabel.Size = new Size(255, 55);
            readerInputLabel.TabIndex = 0;
            readerInputLabel.Text = "Читатель:";
            readerInputLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // readerInput
            // 
            readerInput.AutoResize = false;
            readerInput.BackColor = Color.FromArgb(255, 255, 255);
            readerInput.Depth = 0;
            readerInput.Dock = DockStyle.Fill;
            readerInput.DrawMode = DrawMode.OwnerDrawVariable;
            readerInput.DropDownHeight = 174;
            readerInput.DropDownStyle = ComboBoxStyle.DropDownList;
            readerInput.DropDownWidth = 121;
            readerInput.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            readerInput.ForeColor = Color.FromArgb(222, 0, 0, 0);
            readerInput.FormattingEnabled = true;
            readerInput.IntegralHeight = false;
            readerInput.ItemHeight = 43;
            readerInput.Location = new Point(283, 92);
            readerInput.MaxDropDownItems = 4;
            readerInput.MouseState = MaterialSkin.MouseState.OUT;
            readerInput.Name = "readerInput";
            readerInput.Size = new Size(387, 49);
            readerInput.StartIndex = 0;
            readerInput.TabIndex = 1;
            // 
            // bookLabel
            // 
            bookLabel.AutoSize = true;
            bookLabel.Depth = 0;
            bookLabel.Dock = DockStyle.Fill;
            bookLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            bookLabel.Location = new Point(22, 144);
            bookLabel.MouseState = MaterialSkin.MouseState.HOVER;
            bookLabel.Name = "bookLabel";
            bookLabel.Size = new Size(255, 55);
            bookLabel.TabIndex = 2;
            bookLabel.Text = "Книга:";
            bookLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Dock = DockStyle.Fill;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(22, 199);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(255, 33);
            materialLabel2.TabIndex = 3;
            materialLabel2.Text = "Дата выдачи книги:";
            materialLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // returnDateLabel
            // 
            returnDateLabel.AutoSize = true;
            returnDateLabel.Depth = 0;
            returnDateLabel.Dock = DockStyle.Fill;
            returnDateLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            returnDateLabel.Location = new Point(22, 232);
            returnDateLabel.MouseState = MaterialSkin.MouseState.HOVER;
            returnDateLabel.Name = "returnDateLabel";
            returnDateLabel.Size = new Size(255, 37);
            returnDateLabel.TabIndex = 4;
            returnDateLabel.Text = "Дата возврата книги:";
            returnDateLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Dock = DockStyle.Fill;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(22, 269);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(255, 33);
            materialLabel4.TabIndex = 5;
            materialLabel4.Text = "Ожидаемая дата возврата книги:";
            materialLabel4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // saveButton
            // 
            saveButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            saveButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            saveButton.Depth = 0;
            saveButton.Dock = DockStyle.Fill;
            saveButton.HighEmphasis = true;
            saveButton.Icon = null;
            saveButton.Location = new Point(23, 308);
            saveButton.Margin = new Padding(4, 6, 4, 6);
            saveButton.MouseState = MaterialSkin.MouseState.HOVER;
            saveButton.Name = "saveButton";
            saveButton.NoAccentTextColor = Color.Empty;
            saveButton.Size = new Size(253, 36);
            saveButton.TabIndex = 6;
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
            cancelButton.Location = new Point(284, 308);
            cancelButton.Margin = new Padding(4, 6, 4, 6);
            cancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            cancelButton.Name = "cancelButton";
            cancelButton.NoAccentTextColor = Color.Empty;
            cancelButton.Size = new Size(385, 36);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Отмена";
            cancelButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            cancelButton.UseAccentColor = false;
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // bookInput
            // 
            bookInput.AutoResize = false;
            bookInput.BackColor = Color.FromArgb(255, 255, 255);
            bookInput.Depth = 0;
            bookInput.Dock = DockStyle.Fill;
            bookInput.DrawMode = DrawMode.OwnerDrawVariable;
            bookInput.DropDownHeight = 174;
            bookInput.DropDownStyle = ComboBoxStyle.DropDownList;
            bookInput.DropDownWidth = 121;
            bookInput.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            bookInput.ForeColor = Color.FromArgb(222, 0, 0, 0);
            bookInput.FormattingEnabled = true;
            bookInput.IntegralHeight = false;
            bookInput.ItemHeight = 43;
            bookInput.Location = new Point(283, 147);
            bookInput.MaxDropDownItems = 4;
            bookInput.MouseState = MaterialSkin.MouseState.OUT;
            bookInput.Name = "bookInput";
            bookInput.Size = new Size(387, 49);
            bookInput.StartIndex = 0;
            bookInput.TabIndex = 8;
            // 
            // issueDateInput
            // 
            issueDateInput.CustomFormat = "dd.MM.yyyy";
            issueDateInput.Dock = DockStyle.Fill;
            issueDateInput.Format = DateTimePickerFormat.Custom;
            issueDateInput.Location = new Point(283, 202);
            issueDateInput.Name = "issueDateInput";
            issueDateInput.Size = new Size(387, 27);
            issueDateInput.TabIndex = 9;
            // 
            // returnDateInput
            // 
            returnDateInput.CustomFormat = "dd.MM.yyyy";
            returnDateInput.Dock = DockStyle.Fill;
            returnDateInput.Format = DateTimePickerFormat.Custom;
            returnDateInput.Location = new Point(283, 235);
            returnDateInput.Name = "returnDateInput";
            returnDateInput.Size = new Size(387, 27);
            returnDateInput.TabIndex = 10;
            // 
            // expectedReturnDateInput
            // 
            expectedReturnDateInput.CustomFormat = "dd.MM.yyyy";
            expectedReturnDateInput.Dock = DockStyle.Fill;
            expectedReturnDateInput.Format = DateTimePickerFormat.Custom;
            expectedReturnDateInput.Location = new Point(283, 272);
            expectedReturnDateInput.Name = "expectedReturnDateInput";
            expectedReturnDateInput.Size = new Size(387, 27);
            expectedReturnDateInput.TabIndex = 11;
            // 
            // isBookReturned
            // 
            isBookReturned.AutoSize = true;
            isBookReturned.Depth = 0;
            isBookReturned.Dock = DockStyle.Fill;
            isBookReturned.Location = new Point(673, 232);
            isBookReturned.Margin = new Padding(0);
            isBookReturned.MouseLocation = new Point(-1, -1);
            isBookReturned.MouseState = MaterialSkin.MouseState.HOVER;
            isBookReturned.Name = "isBookReturned";
            isBookReturned.ReadOnly = false;
            isBookReturned.Ripple = true;
            isBookReturned.Size = new Size(164, 37);
            isBookReturned.TabIndex = 13;
            isBookReturned.Text = "Книга у читателя";
            isBookReturned.UseVisualStyleBackColor = true;
            isBookReturned.CheckedChanged += isBookReturned_CheckedChanged;
            // 
            // EditIssuedBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 507);
            Controls.Add(IssuedBookTableLayout);
            Name = "EditIssuedBookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditIssuedBookForm";
            IssuedBookTableLayout.ResumeLayout(false);
            IssuedBookTableLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel IssuedBookTableLayout;
        private MaterialSkin.Controls.MaterialLabel readerInputLabel;
        private MaterialSkin.Controls.MaterialComboBox readerInput;
        private MaterialSkin.Controls.MaterialLabel bookLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel returnDateLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton saveButton;
        private MaterialSkin.Controls.MaterialButton cancelButton;
        private MaterialSkin.Controls.MaterialComboBox bookInput;
        private DateTimePicker issueDateInput;
        private DateTimePicker returnDateInput;
        private DateTimePicker expectedReturnDateInput;
        private MaterialSkin.Controls.MaterialCheckbox isBookReturned;
    }
}