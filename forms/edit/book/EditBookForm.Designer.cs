namespace Bookful.forms.edit
{
    partial class EditBookForm
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
            label1 = new Label();
            titleInput = new TextBox();
            authorInput = new TextBox();
            label2 = new Label();
            label3 = new Label();
            descriptionInput = new RichTextBox();
            label4 = new Label();
            publishingHouseInput = new TextBox();
            label5 = new Label();
            publicationDateInput = new DateTimePicker();
            tableLayoutPanel1 = new TableLayoutPanel();
            saveButton = new Button();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(219, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 33);
            label1.TabIndex = 0;
            label1.Text = "Название:";
            // 
            // titleInput
            // 
            titleInput.Dock = DockStyle.Fill;
            titleInput.Location = new Point(369, 3);
            titleInput.Name = "titleInput";
            titleInput.Size = new Size(210, 27);
            titleInput.TabIndex = 1;
            // 
            // authorInput
            // 
            authorInput.Dock = DockStyle.Fill;
            authorInput.Location = new Point(369, 36);
            authorInput.Name = "authorInput";
            authorInput.Size = new Size(210, 27);
            authorInput.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(219, 33);
            label2.Name = "label2";
            label2.Size = new Size(144, 33);
            label2.TabIndex = 2;
            label2.Text = "Автор:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(219, 66);
            label3.Name = "label3";
            label3.Size = new Size(144, 161);
            label3.TabIndex = 4;
            label3.Text = "Описание:";
            // 
            // descriptionInput
            // 
            descriptionInput.Dock = DockStyle.Fill;
            descriptionInput.Location = new Point(369, 69);
            descriptionInput.Name = "descriptionInput";
            descriptionInput.Size = new Size(210, 155);
            descriptionInput.TabIndex = 5;
            descriptionInput.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(219, 227);
            label4.Name = "label4";
            label4.Size = new Size(144, 33);
            label4.TabIndex = 6;
            label4.Text = "Издательство:";
            // 
            // publishingHouseInput
            // 
            publishingHouseInput.Dock = DockStyle.Fill;
            publishingHouseInput.Location = new Point(369, 230);
            publishingHouseInput.Name = "publishingHouseInput";
            publishingHouseInput.Size = new Size(210, 27);
            publishingHouseInput.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(219, 260);
            label5.Name = "label5";
            label5.Size = new Size(144, 33);
            label5.TabIndex = 8;
            label5.Text = "Дата публикации:";
            // 
            // publicationDateInput
            // 
            publicationDateInput.Dock = DockStyle.Fill;
            publicationDateInput.Location = new Point(369, 263);
            publicationDateInput.Name = "publicationDateInput";
            publicationDateInput.Size = new Size(210, 27);
            publicationDateInput.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(publicationDateInput, 2, 4);
            tableLayoutPanel1.Controls.Add(label5, 1, 4);
            tableLayoutPanel1.Controls.Add(label2, 1, 1);
            tableLayoutPanel1.Controls.Add(publishingHouseInput, 2, 3);
            tableLayoutPanel1.Controls.Add(authorInput, 2, 1);
            tableLayoutPanel1.Controls.Add(label4, 1, 3);
            tableLayoutPanel1.Controls.Add(label3, 1, 2);
            tableLayoutPanel1.Controls.Add(descriptionInput, 2, 2);
            tableLayoutPanel1.Controls.Add(titleInput, 2, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(saveButton, 1, 5);
            tableLayoutPanel1.Controls.Add(button1, 2, 5);
            tableLayoutPanel1.Location = new Point(0, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(800, 445);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            saveButton.Location = new Point(219, 296);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(144, 29);
            saveButton.TabIndex = 10;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(369, 296);
            button1.Name = "button1";
            button1.Size = new Size(210, 29);
            button1.TabIndex = 11;
            button1.Text = "Отменить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EditBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "EditBookForm";
            Text = "Редактировать книгу";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox titleInput;
        private TextBox authorInput;
        private Label label2;
        private Label label3;
        private RichTextBox descriptionInput;
        private Label label4;
        private TextBox publishingHouseInput;
        private Label label5;
        private DateTimePicker publicationDateInput;
        private TableLayoutPanel tableLayoutPanel1;
        private Button saveButton;
        private Button button1;
    }
}