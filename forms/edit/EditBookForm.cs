using Bookful.domain.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookful.forms.edit
{
    public partial class EditBookForm : Form
    {
        private Book book;

        private TextBox titleInput;
        private TextBox authorInput;
        private TextBox descriptionInput;
        private TextBox publishingHouseInput;
        private DateTimePicker publicationDateInput;

        public EditBookForm(Book book)
        {
            InitializeComponent();

            var titleLabel = new Label()
            {
                Text = "Название",
                Dock = DockStyle.Left,
            };

            titleInput = new TextBox()
            {
                Dock = DockStyle.Fill,
            };

            var authorLabel = new Label()
            {
                Text = "Автор",
                Dock = DockStyle.Left
            };

            authorInput = new TextBox()
            {
                Dock = DockStyle.Fill
            };

            var descriptionLabel = new Label()
            {
                Text = "Описание",
                Dock = DockStyle.Left,
            };

            descriptionInput = new TextBox()
            {
                Dock = DockStyle.Fill,
            };

            var publishingHouseLabel = new Label()
            {
                Text = "Издательство",
                Dock = DockStyle.Left
            };

            publishingHouseInput = new TextBox()
            {
                Dock = DockStyle.Fill
            };

            var publicationDateLabel = new Label()
            {
                Text = "Дата публикации",
                Dock = DockStyle.Left,
            };

            publicationDateInput = new DateTimePicker()
            {
                Dock = DockStyle.Fill
            };



            var tableLayout = new TableLayoutPanel();
            tableLayout.RowStyles.Clear();

            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50)); // 1 строка пустая панель
            tableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // 2 строка название лейбл
            tableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // 3 строка название инпут
            tableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // 4 строка автор лейбл
            tableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // 5 строка автор инпут
            tableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // 4 строка описание лейбл
            tableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // 5 строка описание инпут
            tableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // 4 строка издательство лейбл
            tableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // 5 строка издательство инпут
            tableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // 4 строка дата публикации лейбл
            tableLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // 5 строка дата публикации инпут
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50));

            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50)); // 1 колонка
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50)); // 2 колонка
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50)); // 3 колонка

            tableLayout.Controls.Add(new Panel(), 0, 0);
            tableLayout.Controls.Add(titleLabel, 1, 1);
            tableLayout.Controls.Add(titleInput, 1, 2);
            tableLayout.Controls.Add(authorLabel, 1, 3);
            tableLayout.Controls.Add(authorInput, 1, 4);
            tableLayout.Controls.Add(descriptionLabel, 1, 5);
            tableLayout.Controls.Add(descriptionInput, 1, 6);
            tableLayout.Controls.Add(publishingHouseLabel, 1, 7);
            tableLayout.Controls.Add(publishingHouseInput, 1, 8);
            tableLayout.Controls.Add(publicationDateLabel, 1, 9);
            tableLayout.Controls.Add(publicationDateInput, 1, 10);
            tableLayout.Controls.Add(new Panel(), 2, 11);

            tableLayout.Dock = DockStyle.Fill;
            Controls.Add(tableLayout);

            this.book = book;
            InitializeForm();
        }

        private void InitializeForm()
        {
            // Заполнение полей формы данными о книге
            titleInput.Text = book.Title;
            authorInput.Text = book.Author;
            descriptionInput.Text = book.Description;
            publishingHouseInput.Text = book.PublishingHouse;
            publicationDateInput.Value = DateTime.Parse(book.PublicationDate);
        }
    }
}
