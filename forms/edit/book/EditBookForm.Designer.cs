﻿using MaterialSkin.Controls;

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
            titleLabel = new MaterialLabel();
            titleInput = new MaterialTextBox();
            authorInput = new MaterialTextBox();
            authorLabel = new MaterialLabel();
            descriptionLabel = new MaterialLabel();
            descriptionInput = new MaterialMultiLineTextBox();
            publishingHouseLabel = new MaterialLabel();
            publishingHouseInput = new MaterialTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            publicationDateInput = new DateTimePicker();
            publicationDateLabel = new MaterialLabel();
            saveButton = new MaterialButton();
            cancelButton = new MaterialButton();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Depth = 0;
            titleLabel.Dock = DockStyle.Fill;
            titleLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            titleLabel.Location = new Point(221, 38);
            titleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(136, 56);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Название:";
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // titleInput
            // 
            titleInput.AnimateReadOnly = false;
            titleInput.BorderStyle = BorderStyle.None;
            titleInput.Depth = 0;
            titleInput.Dock = DockStyle.Fill;
            titleInput.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            titleInput.LeadingIcon = null;
            titleInput.Location = new Point(363, 41);
            titleInput.MaxLength = 50;
            titleInput.MouseState = MaterialSkin.MouseState.OUT;
            titleInput.Multiline = false;
            titleInput.Name = "titleInput";
            titleInput.Size = new Size(210, 50);
            titleInput.TabIndex = 1;
            titleInput.Text = "";
            titleInput.TrailingIcon = null;
            // 
            // authorInput
            // 
            authorInput.AnimateReadOnly = false;
            authorInput.BorderStyle = BorderStyle.None;
            authorInput.Depth = 0;
            authorInput.Dock = DockStyle.Fill;
            authorInput.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            authorInput.LeadingIcon = null;
            authorInput.Location = new Point(363, 97);
            authorInput.MaxLength = 50;
            authorInput.MouseState = MaterialSkin.MouseState.OUT;
            authorInput.Multiline = false;
            authorInput.Name = "authorInput";
            authorInput.Size = new Size(210, 50);
            authorInput.TabIndex = 3;
            authorInput.Text = "";
            authorInput.TrailingIcon = null;
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Depth = 0;
            authorLabel.Dock = DockStyle.Fill;
            authorLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            authorLabel.Location = new Point(221, 94);
            authorLabel.MouseState = MaterialSkin.MouseState.HOVER;
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new Size(136, 56);
            authorLabel.TabIndex = 2;
            authorLabel.Text = "Автор:";
            authorLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Depth = 0;
            descriptionLabel.Dock = DockStyle.Fill;
            descriptionLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            descriptionLabel.Location = new Point(221, 150);
            descriptionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(136, 161);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "Описание:";
            descriptionLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // descriptionInput
            // 
            descriptionInput.BackColor = Color.FromArgb(255, 255, 255);
            descriptionInput.BorderStyle = BorderStyle.None;
            descriptionInput.Depth = 0;
            descriptionInput.Dock = DockStyle.Fill;
            descriptionInput.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            descriptionInput.ForeColor = Color.FromArgb(222, 0, 0, 0);
            descriptionInput.Location = new Point(363, 153);
            descriptionInput.MouseState = MaterialSkin.MouseState.HOVER;
            descriptionInput.Name = "descriptionInput";
            descriptionInput.Size = new Size(210, 155);
            descriptionInput.TabIndex = 5;
            descriptionInput.Text = "";
            // 
            // publishingHouseLabel
            // 
            publishingHouseLabel.AutoSize = true;
            publishingHouseLabel.Depth = 0;
            publishingHouseLabel.Dock = DockStyle.Fill;
            publishingHouseLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            publishingHouseLabel.Location = new Point(221, 311);
            publishingHouseLabel.MouseState = MaterialSkin.MouseState.HOVER;
            publishingHouseLabel.Name = "publishingHouseLabel";
            publishingHouseLabel.Size = new Size(136, 56);
            publishingHouseLabel.TabIndex = 6;
            publishingHouseLabel.Text = "Издательство:";
            publishingHouseLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // publishingHouseInput
            // 
            publishingHouseInput.AnimateReadOnly = false;
            publishingHouseInput.BorderStyle = BorderStyle.None;
            publishingHouseInput.Depth = 0;
            publishingHouseInput.Dock = DockStyle.Fill;
            publishingHouseInput.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            publishingHouseInput.LeadingIcon = null;
            publishingHouseInput.Location = new Point(363, 314);
            publishingHouseInput.MaxLength = 50;
            publishingHouseInput.MouseState = MaterialSkin.MouseState.OUT;
            publishingHouseInput.Multiline = false;
            publishingHouseInput.Name = "publishingHouseInput";
            publishingHouseInput.Size = new Size(210, 50);
            publishingHouseInput.TabIndex = 7;
            publishingHouseInput.Text = "";
            publishingHouseInput.TrailingIcon = null;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(publicationDateInput, 2, 5);
            tableLayoutPanel1.Controls.Add(publicationDateLabel, 1, 5);
            tableLayoutPanel1.Controls.Add(authorLabel, 1, 2);
            tableLayoutPanel1.Controls.Add(publishingHouseInput, 2, 4);
            tableLayoutPanel1.Controls.Add(authorInput, 2, 2);
            tableLayoutPanel1.Controls.Add(publishingHouseLabel, 1, 4);
            tableLayoutPanel1.Controls.Add(descriptionLabel, 1, 3);
            tableLayoutPanel1.Controls.Add(descriptionInput, 2, 3);
            tableLayoutPanel1.Controls.Add(titleInput, 2, 1);
            tableLayoutPanel1.Controls.Add(titleLabel, 1, 1);
            tableLayoutPanel1.Controls.Add(saveButton, 1, 6);
            tableLayoutPanel1.Controls.Add(cancelButton, 2, 6);
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
            tableLayoutPanel1.Size = new Size(794, 486);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // publicationDateInput
            // 
            publicationDateInput.CustomFormat = "dd.MM.yyyy";
            publicationDateInput.Dock = DockStyle.Fill;
            publicationDateInput.Format = DateTimePickerFormat.Custom;
            publicationDateInput.Location = new Point(363, 370);
            publicationDateInput.Name = "publicationDateInput";
            publicationDateInput.Size = new Size(210, 27);
            publicationDateInput.TabIndex = 9;
            // 
            // publicationDateLabel
            // 
            publicationDateLabel.AutoSize = true;
            publicationDateLabel.Depth = 0;
            publicationDateLabel.Dock = DockStyle.Fill;
            publicationDateLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            publicationDateLabel.Location = new Point(221, 367);
            publicationDateLabel.MouseState = MaterialSkin.MouseState.HOVER;
            publicationDateLabel.Name = "publicationDateLabel";
            publicationDateLabel.Size = new Size(136, 33);
            publicationDateLabel.TabIndex = 8;
            publicationDateLabel.Text = "Дата публикации:";
            publicationDateLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            saveButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            saveButton.Density = MaterialButton.MaterialButtonDensity.Default;
            saveButton.Depth = 0;
            saveButton.HighEmphasis = true;
            saveButton.Icon = null;
            saveButton.Location = new Point(222, 406);
            saveButton.Margin = new Padding(4, 6, 4, 6);
            saveButton.MouseState = MaterialSkin.MouseState.HOVER;
            saveButton.Name = "saveButton";
            saveButton.NoAccentTextColor = Color.Empty;
            saveButton.Size = new Size(134, 36);
            saveButton.TabIndex = 10;
            saveButton.Text = "Сохранить";
            saveButton.Type = MaterialButton.MaterialButtonType.Contained;
            saveButton.UseAccentColor = false;
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cancelButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cancelButton.Density = MaterialButton.MaterialButtonDensity.Default;
            cancelButton.Depth = 0;
            cancelButton.HighEmphasis = true;
            cancelButton.Icon = null;
            cancelButton.Location = new Point(364, 406);
            cancelButton.Margin = new Padding(4, 6, 4, 6);
            cancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            cancelButton.Name = "cancelButton";
            cancelButton.NoAccentTextColor = Color.Empty;
            cancelButton.Size = new Size(208, 36);
            cancelButton.TabIndex = 11;
            cancelButton.Text = "Отмена";
            cancelButton.Type = MaterialButton.MaterialButtonType.Contained;
            cancelButton.UseAccentColor = false;
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += button1_Click;
            // 
            // EditBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 553);
            Controls.Add(tableLayoutPanel1);
            Name = "EditBookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Редактировать книгу";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialLabel titleLabel;
        private MaterialTextBox titleInput;
        private MaterialTextBox authorInput;
        private MaterialLabel authorLabel;
        private MaterialLabel descriptionLabel;
        private MaterialMultiLineTextBox descriptionInput;
        private MaterialLabel publishingHouseLabel;
        private MaterialTextBox publishingHouseInput;
        private TableLayoutPanel tableLayoutPanel1;
        private DateTimePicker publicationDateInput;
        private MaterialLabel publicationDateLabel;
        private MaterialButton saveButton;
        private MaterialButton cancelButton;
    }
}