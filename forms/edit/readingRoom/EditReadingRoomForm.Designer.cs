using MaterialSkin.Controls;

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
            roomNumberLabel = new MaterialLabel();
            roomNumberInput = new NumericUpDown();
            specializationLabel = new MaterialLabel();
            specializationInput = new MaterialTextBox();
            numberOfSeatsLabel = new MaterialLabel();
            numberOfSeatsInput = new NumericUpDown();
            saveButton = new MaterialButton();
            cancelButton = new MaterialButton();
            tableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roomNumberInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberOfSeatsInput).BeginInit();
            SuspendLayout();
            // 
            // tableLayout
            // 
            tableLayout.ColumnCount = 4;
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayout.ColumnStyles.Add(new ColumnStyle());
            tableLayout.ColumnStyles.Add(new ColumnStyle());
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayout.Controls.Add(roomNumberLabel, 1, 1);
            tableLayout.Controls.Add(roomNumberInput, 2, 1);
            tableLayout.Controls.Add(specializationLabel, 1, 2);
            tableLayout.Controls.Add(specializationInput, 2, 2);
            tableLayout.Controls.Add(numberOfSeatsLabel, 1, 3);
            tableLayout.Controls.Add(numberOfSeatsInput, 2, 3);
            tableLayout.Controls.Add(saveButton, 1, 4);
            tableLayout.Controls.Add(cancelButton, 2, 4);
            tableLayout.Dock = DockStyle.Fill;
            tableLayout.Location = new Point(3, 64);
            tableLayout.Name = "tableLayout";
            tableLayout.RowCount = 6;
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayout.RowStyles.Add(new RowStyle());
            tableLayout.RowStyles.Add(new RowStyle());
            tableLayout.RowStyles.Add(new RowStyle());
            tableLayout.RowStyles.Add(new RowStyle());
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayout.Size = new Size(794, 383);
            tableLayout.TabIndex = 0;
            // 
            // roomNumberLabel
            // 
            roomNumberLabel.AutoSize = true;
            roomNumberLabel.Depth = 0;
            roomNumberLabel.Dock = DockStyle.Fill;
            roomNumberLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            roomNumberLabel.Location = new Point(230, 106);
            roomNumberLabel.MouseState = MaterialSkin.MouseState.HOVER;
            roomNumberLabel.Name = "roomNumberLabel";
            roomNumberLabel.Size = new Size(133, 33);
            roomNumberLabel.TabIndex = 0;
            roomNumberLabel.Text = "Номер зала:";
            roomNumberLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // roomNumberInput
            // 
            roomNumberInput.Dock = DockStyle.Fill;
            roomNumberInput.Location = new Point(369, 109);
            roomNumberInput.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            roomNumberInput.Name = "roomNumberInput";
            roomNumberInput.Size = new Size(194, 27);
            roomNumberInput.TabIndex = 1;
            // 
            // specializationLabel
            // 
            specializationLabel.AutoSize = true;
            specializationLabel.Depth = 0;
            specializationLabel.Dock = DockStyle.Fill;
            specializationLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            specializationLabel.Location = new Point(230, 139);
            specializationLabel.MouseState = MaterialSkin.MouseState.HOVER;
            specializationLabel.Name = "specializationLabel";
            specializationLabel.Size = new Size(133, 56);
            specializationLabel.TabIndex = 2;
            specializationLabel.Text = "Специализация:";
            specializationLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // specializationInput
            // 
            specializationInput.AnimateReadOnly = false;
            specializationInput.BorderStyle = BorderStyle.None;
            specializationInput.Depth = 0;
            specializationInput.Dock = DockStyle.Fill;
            specializationInput.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            specializationInput.LeadingIcon = null;
            specializationInput.Location = new Point(369, 142);
            specializationInput.MaxLength = 50;
            specializationInput.MouseState = MaterialSkin.MouseState.OUT;
            specializationInput.Multiline = false;
            specializationInput.Name = "specializationInput";
            specializationInput.Size = new Size(194, 50);
            specializationInput.TabIndex = 3;
            specializationInput.Text = "";
            specializationInput.TrailingIcon = null;
            // 
            // numberOfSeatsLabel
            // 
            numberOfSeatsLabel.AutoSize = true;
            numberOfSeatsLabel.Depth = 0;
            numberOfSeatsLabel.Dock = DockStyle.Fill;
            numberOfSeatsLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            numberOfSeatsLabel.Location = new Point(230, 195);
            numberOfSeatsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            numberOfSeatsLabel.Name = "numberOfSeatsLabel";
            numberOfSeatsLabel.Size = new Size(133, 33);
            numberOfSeatsLabel.TabIndex = 4;
            numberOfSeatsLabel.Text = "Количество мест:";
            numberOfSeatsLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numberOfSeatsInput
            // 
            numberOfSeatsInput.Dock = DockStyle.Fill;
            numberOfSeatsInput.Location = new Point(369, 198);
            numberOfSeatsInput.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numberOfSeatsInput.Name = "numberOfSeatsInput";
            numberOfSeatsInput.Size = new Size(194, 27);
            numberOfSeatsInput.TabIndex = 5;
            // 
            // saveButton
            // 
            saveButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            saveButton.Density = MaterialButton.MaterialButtonDensity.Default;
            saveButton.Depth = 0;
            saveButton.Dock = DockStyle.Fill;
            saveButton.HighEmphasis = true;
            saveButton.Icon = null;
            saveButton.Location = new Point(231, 234);
            saveButton.Margin = new Padding(4, 6, 4, 6);
            saveButton.MouseState = MaterialSkin.MouseState.HOVER;
            saveButton.Name = "saveButton";
            saveButton.NoAccentTextColor = Color.Empty;
            saveButton.Size = new Size(131, 36);
            saveButton.TabIndex = 6;
            saveButton.Text = "Сохранить";
            saveButton.Type = MaterialButton.MaterialButtonType.Contained;
            saveButton.UseAccentColor = false;
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cancelButton.Density = MaterialButton.MaterialButtonDensity.Default;
            cancelButton.Depth = 0;
            cancelButton.Dock = DockStyle.Fill;
            cancelButton.HighEmphasis = true;
            cancelButton.Icon = null;
            cancelButton.Location = new Point(370, 234);
            cancelButton.Margin = new Padding(4, 6, 4, 6);
            cancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            cancelButton.Name = "cancelButton";
            cancelButton.NoAccentTextColor = Color.Empty;
            cancelButton.Size = new Size(192, 36);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Отмена";
            cancelButton.Type = MaterialButton.MaterialButtonType.Contained;
            cancelButton.UseAccentColor = false;
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditReadingRoomForm";
            tableLayout.ResumeLayout(false);
            tableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roomNumberInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberOfSeatsInput).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayout;
        private MaterialLabel roomNumberLabel;
        private NumericUpDown roomNumberInput;
        private MaterialLabel specializationLabel;
        private MaterialTextBox specializationInput;
        private MaterialLabel numberOfSeatsLabel;
        private NumericUpDown numberOfSeatsInput;
        private MaterialButton saveButton;
        private MaterialButton cancelButton;
    }
}