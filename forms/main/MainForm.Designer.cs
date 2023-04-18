namespace Bookful.forms.main
{
    partial class MainForm
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
            quickActionsBox = new GroupBox();
            tabControl = new TabControl();
            issuedBooksTab = new TabPage();
            booksListTab = new TabPage();
            bookListLayout = new TableLayoutPanel();
            booksDataGrid = new DataGridView();
            booksToolBar = new MenuStrip();
            addBookButton = new ToolStripMenuItem();
            refreshBooksButton = new ToolStripMenuItem();
            searchBooksLayout = new TableLayoutPanel();
            searchBooksInput = new TextBox();
            searchBooksButton = new Button();
            authorsListTab = new TabPage();
            readingRoomsListTab = new TabPage();
            readingRoomsTableLayout = new TableLayoutPanel();
            readingRoomsDataGrid = new DataGridView();
            readingRoomsToolBar = new MenuStrip();
            addReadingRoomButton = new ToolStripMenuItem();
            refreshReadingRoomsButton = new ToolStripMenuItem();
            searchReadingRoomsLayout = new TableLayoutPanel();
            searchReadingRoomsButton = new Button();
            searchReadingRoomsInput = new TextBox();
            tabControl.SuspendLayout();
            booksListTab.SuspendLayout();
            bookListLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)booksDataGrid).BeginInit();
            booksToolBar.SuspendLayout();
            searchBooksLayout.SuspendLayout();
            readingRoomsListTab.SuspendLayout();
            readingRoomsTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)readingRoomsDataGrid).BeginInit();
            readingRoomsToolBar.SuspendLayout();
            searchReadingRoomsLayout.SuspendLayout();
            SuspendLayout();
            // 
            // quickActionsBox
            // 
            quickActionsBox.Dock = DockStyle.Left;
            quickActionsBox.Location = new Point(0, 0);
            quickActionsBox.Name = "quickActionsBox";
            quickActionsBox.Size = new Size(161, 450);
            quickActionsBox.TabIndex = 0;
            quickActionsBox.TabStop = false;
            quickActionsBox.Text = "Быстрые действия";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(issuedBooksTab);
            tabControl.Controls.Add(booksListTab);
            tabControl.Controls.Add(authorsListTab);
            tabControl.Controls.Add(readingRoomsListTab);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(161, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(639, 450);
            tabControl.TabIndex = 1;
            // 
            // issuedBooksTab
            // 
            issuedBooksTab.Location = new Point(4, 29);
            issuedBooksTab.Name = "issuedBooksTab";
            issuedBooksTab.Padding = new Padding(3);
            issuedBooksTab.Size = new Size(631, 417);
            issuedBooksTab.TabIndex = 0;
            issuedBooksTab.Text = "Выданные книги";
            issuedBooksTab.UseVisualStyleBackColor = true;
            // 
            // booksListTab
            // 
            booksListTab.Controls.Add(bookListLayout);
            booksListTab.Location = new Point(4, 29);
            booksListTab.Name = "booksListTab";
            booksListTab.Padding = new Padding(3);
            booksListTab.Size = new Size(631, 417);
            booksListTab.TabIndex = 1;
            booksListTab.Text = "Список книг";
            booksListTab.UseVisualStyleBackColor = true;
            // 
            // bookListLayout
            // 
            bookListLayout.ColumnCount = 1;
            bookListLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            bookListLayout.Controls.Add(booksDataGrid, 0, 2);
            bookListLayout.Controls.Add(booksToolBar, 0, 1);
            bookListLayout.Controls.Add(searchBooksLayout, 0, 0);
            bookListLayout.Dock = DockStyle.Fill;
            bookListLayout.Location = new Point(3, 3);
            bookListLayout.Name = "bookListLayout";
            bookListLayout.RowCount = 2;
            bookListLayout.RowStyles.Add(new RowStyle());
            bookListLayout.RowStyles.Add(new RowStyle());
            bookListLayout.RowStyles.Add(new RowStyle());
            bookListLayout.Size = new Size(625, 411);
            bookListLayout.TabIndex = 0;
            // 
            // booksDataGrid
            // 
            booksDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            booksDataGrid.BackgroundColor = SystemColors.Control;
            booksDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            booksDataGrid.Dock = DockStyle.Fill;
            booksDataGrid.Location = new Point(3, 81);
            booksDataGrid.Name = "booksDataGrid";
            booksDataGrid.RowHeadersWidth = 51;
            booksDataGrid.RowTemplate.Height = 29;
            booksDataGrid.Size = new Size(619, 342);
            booksDataGrid.TabIndex = 0;
            // 
            // booksToolBar
            // 
            booksToolBar.ImageScalingSize = new Size(20, 20);
            booksToolBar.Items.AddRange(new ToolStripItem[] { addBookButton, refreshBooksButton });
            booksToolBar.Location = new Point(0, 50);
            booksToolBar.Name = "booksToolBar";
            booksToolBar.Size = new Size(625, 28);
            booksToolBar.TabIndex = 1;
            booksToolBar.Text = "menuStrip1";
            // 
            // addBookButton
            // 
            addBookButton.Name = "addBookButton";
            addBookButton.Size = new Size(90, 24);
            addBookButton.Text = "Добавить";
            addBookButton.Click += addBookButton_Click;
            // 
            // refreshBooksButton
            // 
            refreshBooksButton.Name = "refreshBooksButton";
            refreshBooksButton.Size = new Size(144, 24);
            refreshBooksButton.Text = "Обновить список";
            refreshBooksButton.Click += refreshBooksButton_Click;
            // 
            // searchBooksLayout
            // 
            searchBooksLayout.ColumnCount = 2;
            searchBooksLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            searchBooksLayout.ColumnStyles.Add(new ColumnStyle());
            searchBooksLayout.Controls.Add(searchBooksInput, 0, 0);
            searchBooksLayout.Controls.Add(searchBooksButton, 1, 0);
            searchBooksLayout.Dock = DockStyle.Fill;
            searchBooksLayout.Location = new Point(3, 3);
            searchBooksLayout.Name = "searchBooksLayout";
            searchBooksLayout.RowCount = 1;
            searchBooksLayout.RowStyles.Add(new RowStyle());
            searchBooksLayout.Size = new Size(619, 44);
            searchBooksLayout.TabIndex = 2;
            // 
            // searchBooksInput
            // 
            searchBooksInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            searchBooksInput.Location = new Point(3, 3);
            searchBooksInput.Name = "searchBooksInput";
            searchBooksInput.Size = new Size(507, 27);
            searchBooksInput.TabIndex = 0;
            searchBooksInput.KeyDown += searchBooksInput_KeyDown;
            // 
            // searchBooksButton
            // 
            searchBooksButton.AutoSize = true;
            searchBooksButton.Dock = DockStyle.Fill;
            searchBooksButton.Location = new Point(516, 3);
            searchBooksButton.Name = "searchBooksButton";
            searchBooksButton.Size = new Size(100, 38);
            searchBooksButton.TabIndex = 1;
            searchBooksButton.Text = "Поиск";
            searchBooksButton.UseVisualStyleBackColor = true;
            searchBooksButton.Click += searchBooksButton_Click;
            // 
            // authorsListTab
            // 
            authorsListTab.Location = new Point(4, 29);
            authorsListTab.Name = "authorsListTab";
            authorsListTab.Padding = new Padding(3);
            authorsListTab.Size = new Size(631, 417);
            authorsListTab.TabIndex = 2;
            authorsListTab.Text = "Авторы";
            authorsListTab.UseVisualStyleBackColor = true;
            // 
            // readingRoomsListTab
            // 
            readingRoomsListTab.Controls.Add(readingRoomsTableLayout);
            readingRoomsListTab.Location = new Point(4, 29);
            readingRoomsListTab.Name = "readingRoomsListTab";
            readingRoomsListTab.Size = new Size(631, 417);
            readingRoomsListTab.TabIndex = 3;
            readingRoomsListTab.Text = "Читальные залы";
            readingRoomsListTab.UseVisualStyleBackColor = true;
            // 
            // readingRoomsTableLayout
            // 
            readingRoomsTableLayout.AutoSize = true;
            readingRoomsTableLayout.ColumnCount = 1;
            readingRoomsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            readingRoomsTableLayout.Controls.Add(readingRoomsDataGrid, 0, 2);
            readingRoomsTableLayout.Controls.Add(readingRoomsToolBar, 0, 1);
            readingRoomsTableLayout.Controls.Add(searchReadingRoomsLayout, 0, 0);
            readingRoomsTableLayout.Dock = DockStyle.Fill;
            readingRoomsTableLayout.Location = new Point(0, 0);
            readingRoomsTableLayout.Name = "readingRoomsTableLayout";
            readingRoomsTableLayout.RowCount = 3;
            readingRoomsTableLayout.RowStyles.Add(new RowStyle());
            readingRoomsTableLayout.RowStyles.Add(new RowStyle());
            readingRoomsTableLayout.RowStyles.Add(new RowStyle());
            readingRoomsTableLayout.Size = new Size(631, 417);
            readingRoomsTableLayout.TabIndex = 0;
            // 
            // readingRoomsDataGrid
            // 
            readingRoomsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            readingRoomsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            readingRoomsDataGrid.Dock = DockStyle.Fill;
            readingRoomsDataGrid.Location = new Point(3, 81);
            readingRoomsDataGrid.Name = "readingRoomsDataGrid";
            readingRoomsDataGrid.ReadOnly = true;
            readingRoomsDataGrid.RowHeadersWidth = 51;
            readingRoomsDataGrid.RowTemplate.Height = 29;
            readingRoomsDataGrid.Size = new Size(625, 363);
            readingRoomsDataGrid.TabIndex = 0;
            readingRoomsDataGrid.CellContentClick += readingRoomsDataGrid_CellContentClick;
            readingRoomsDataGrid.DataBindingComplete += readingRoomsDataGrid_DataBindingComplete;
            // 
            // readingRoomsToolBar
            // 
            readingRoomsToolBar.Dock = DockStyle.Fill;
            readingRoomsToolBar.ImageScalingSize = new Size(20, 20);
            readingRoomsToolBar.Items.AddRange(new ToolStripItem[] { addReadingRoomButton, refreshReadingRoomsButton });
            readingRoomsToolBar.Location = new Point(0, 50);
            readingRoomsToolBar.Name = "readingRoomsToolBar";
            readingRoomsToolBar.Size = new Size(631, 28);
            readingRoomsToolBar.TabIndex = 1;
            readingRoomsToolBar.Text = "menuStrip1";
            // 
            // addReadingRoomButton
            // 
            addReadingRoomButton.Name = "addReadingRoomButton";
            addReadingRoomButton.Size = new Size(90, 24);
            addReadingRoomButton.Text = "Добавить";
            addReadingRoomButton.Click += addReadingRoomButton_Click;
            // 
            // refreshReadingRoomsButton
            // 
            refreshReadingRoomsButton.Name = "refreshReadingRoomsButton";
            refreshReadingRoomsButton.Size = new Size(144, 24);
            refreshReadingRoomsButton.Text = "Обновить список";
            refreshReadingRoomsButton.Click += refreshReadingRoomsButton_Click;
            // 
            // searchReadingRoomsLayout
            // 
            searchReadingRoomsLayout.AutoSize = true;
            searchReadingRoomsLayout.ColumnCount = 2;
            searchReadingRoomsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            searchReadingRoomsLayout.ColumnStyles.Add(new ColumnStyle());
            searchReadingRoomsLayout.Controls.Add(searchReadingRoomsButton, 1, 0);
            searchReadingRoomsLayout.Controls.Add(searchReadingRoomsInput, 0, 0);
            searchReadingRoomsLayout.Dock = DockStyle.Fill;
            searchReadingRoomsLayout.Location = new Point(3, 3);
            searchReadingRoomsLayout.Name = "searchReadingRoomsLayout";
            searchReadingRoomsLayout.RowCount = 1;
            searchReadingRoomsLayout.RowStyles.Add(new RowStyle());
            searchReadingRoomsLayout.Size = new Size(625, 44);
            searchReadingRoomsLayout.TabIndex = 2;
            // 
            // searchReadingRoomsButton
            // 
            searchReadingRoomsButton.AutoSize = true;
            searchReadingRoomsButton.Dock = DockStyle.Fill;
            searchReadingRoomsButton.Location = new Point(522, 3);
            searchReadingRoomsButton.Name = "searchReadingRoomsButton";
            searchReadingRoomsButton.Size = new Size(100, 38);
            searchReadingRoomsButton.TabIndex = 0;
            searchReadingRoomsButton.Text = "Поиск";
            searchReadingRoomsButton.UseVisualStyleBackColor = true;
            // 
            // searchReadingRoomsInput
            // 
            searchReadingRoomsInput.Dock = DockStyle.Fill;
            searchReadingRoomsInput.Location = new Point(3, 3);
            searchReadingRoomsInput.Name = "searchReadingRoomsInput";
            searchReadingRoomsInput.Size = new Size(513, 27);
            searchReadingRoomsInput.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl);
            Controls.Add(quickActionsBox);
            MainMenuStrip = booksToolBar;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += MainForm_Load;
            tabControl.ResumeLayout(false);
            booksListTab.ResumeLayout(false);
            bookListLayout.ResumeLayout(false);
            bookListLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)booksDataGrid).EndInit();
            booksToolBar.ResumeLayout(false);
            booksToolBar.PerformLayout();
            searchBooksLayout.ResumeLayout(false);
            searchBooksLayout.PerformLayout();
            readingRoomsListTab.ResumeLayout(false);
            readingRoomsListTab.PerformLayout();
            readingRoomsTableLayout.ResumeLayout(false);
            readingRoomsTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)readingRoomsDataGrid).EndInit();
            readingRoomsToolBar.ResumeLayout(false);
            readingRoomsToolBar.PerformLayout();
            searchReadingRoomsLayout.ResumeLayout(false);
            searchReadingRoomsLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox quickActionsBox;
        private TabControl tabControl;
        private TabPage issuedBooksTab;
        private TabPage booksListTab;
        private TabPage authorsListTab;
        private TableLayoutPanel bookListLayout;
        private DataGridView booksDataGrid;
        private MenuStrip booksToolBar;
        private ToolStripMenuItem addBookButton;
        private ToolStripMenuItem refreshBooksButton;
        private TableLayoutPanel searchBooksLayout;
        private TextBox searchBooksInput;
        private Button searchBooksButton;
        private TabPage readingRoomsListTab;
        private TableLayoutPanel readingRoomsTableLayout;
        private DataGridView readingRoomsDataGrid;
        private MenuStrip readingRoomsToolBar;
        private ToolStripMenuItem addReadingRoomButton;
        private ToolStripMenuItem refreshReadingRoomsButton;
        private TableLayoutPanel searchReadingRoomsLayout;
        private Button searchReadingRoomsButton;
        private TextBox searchReadingRoomsInput;
    }
}