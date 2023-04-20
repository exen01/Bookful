namespace Bookful.forms.edit
{
    partial class EditReadingRoomForm
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
            tableLayout = new TableLayoutPanel();
            roomNumberLabel = new Label();
            roomNumberInput = new NumericUpDown();
            specializationLabel = new Label();
            specializationInput = new TextBox();
            numberOfSeatsLabel = new Label();
            numberOfSeatsInput = new NumericUpDown();
            saveButton = new Button();
            cancelButton = new Button();
            tableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roomNumberInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberOfSeatsInput).BeginInit();
            SuspendLayout();
            // 
            // tableLayout
            // 
            tableLayout.ColumnCount = 4;
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayout.Controls.Add(roomNumberLabel, 1, 1);
            tableLayout.Controls.Add(roomNumberInput, 2, 1);
            tableLayout.Controls.Add(specializationLabel, 1, 2);
            tableLayout.Controls.Add(specializationInput, 2, 2);
            tableLayout.Controls.Add(numberOfSeatsLabel, 1, 3);
            tableLayout.Controls.Add(numberOfSeatsInput, 2, 3);
            tableLayout.Controls.Add(saveButton, 1, 4);
            tableLayout.Controls.Add(cancelButton, 2, 4);
            tableLayout.Dock = DockStyle.Fill;
            tableLayout.Location = new Point(0, 0);
            tableLayout.Name = "tableLayout";
            tableLayout.RowCount = 6;
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayout.RowStyles.Add(new RowStyle());
            tableLayout.RowStyles.Add(new RowStyle());
            tableLayout.RowStyles.Add(new RowStyle());
            tableLayout.RowStyles.Add(new RowStyle());
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayout.Size = new Size(800, 450);
            tableLayout.TabIndex = 0;
            // 
            // roomNumberLabel
            // 
            roomNumberLabel.AutoSize = true;
            roomNumberLabel.Dock = DockStyle.Fill;
            roomNumberLabel.Location = new Point(203, 158);
            roomNumberLabel.Name = "roomNumberLabel";
            roomNumberLabel.Size = new Size(194, 33);
            roomNumberLabel.TabIndex = 0;
            roomNumberLabel.Text = "Номер зала:";
            // 
            // roomNumberInput
            // 
            roomNumberInput.Dock = DockStyle.Fill;
            roomNumberInput.Location = new Point(403, 161);
            roomNumberInput.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            roomNumberInput.Name = "roomNumberInput";
            roomNumberInput.Size = new Size(194, 27);
            roomNumberInput.TabIndex = 1;
            // 
            // specializationLabel
            // 
            specializationLabel.AutoSize = true;
            specializationLabel.Dock = DockStyle.Fill;
            specializationLabel.Location = new Point(203, 191);
            specializationLabel.Name = "specializationLabel";
            specializationLabel.Size = new Size(194, 33);
            specializationLabel.TabIndex = 2;
            specializationLabel.Text = "Специализация:";
            // 
            // specializationInput
            // 
            specializationInput.Dock = DockStyle.Fill;
            specializationInput.Location = new Point(403, 194);
            specializationInput.Name = "specializationInput";
            specializationInput.Size = new Size(194, 27);
            specializationInput.TabIndex = 3;
            // 
            // numberOfSeatsLabel
            // 
            numberOfSeatsLabel.AutoSize = true;
            numberOfSeatsLabel.Dock = DockStyle.Fill;
            numberOfSeatsLabel.Location = new Point(203, 224);
            numberOfSeatsLabel.Name = "numberOfSeatsLabel";
            numberOfSeatsLabel.Size = new Size(194, 33);
            numberOfSeatsLabel.TabIndex = 4;
            numberOfSeatsLabel.Text = "Количество мест:";
            // 
            // numberOfSeatsInput
            // 
            numberOfSeatsInput.Dock = DockStyle.Fill;
            numberOfSeatsInput.Location = new Point(403, 227);
            numberOfSeatsInput.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numberOfSeatsInput.Name = "numberOfSeatsInput";
            numberOfSeatsInput.Size = new Size(194, 27);
            numberOfSeatsInput.TabIndex = 5;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(203, 260);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 29);
            saveButton.TabIndex = 6;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(403, 260);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // EditReadingRoomForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayout);
            Name = "EditReadingRoomForm";
            Text = "EditReadingRoomForm";
            tableLayout.ResumeLayout(false);
            tableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roomNumberInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberOfSeatsInput).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayout;
        private Label roomNumberLabel;
        private NumericUpDown roomNumberInput;
        private Label specializationLabel;
        private TextBox specializationInput;
        private Label numberOfSeatsLabel;
        private NumericUpDown numberOfSeatsInput;
        private Button saveButton;
        private Button cancelButton;
    }
}