using MaterialSkin.Controls;
using System.Windows.Forms;

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
            readingRoomsListTab = new TabPage();
            readingRoomsTableLayout = new TableLayoutPanel();
            readingRoomsDataGrid = new DataGridView();
            readingRoomsToolBar = new MenuStrip();
            addReadingRoomButton = new ToolStripMenuItem();
            refreshReadingRoomsButton = new ToolStripMenuItem();
            searchReadingRoomsLayout = new TableLayoutPanel();
            searchReadingRoomsButton = new MaterialButton();
            searchReadingRoomsInput = new MaterialTextBox();
            miniToolStrip = new MenuStrip();
            readersListTab = new TabPage();
            readersTableLayout = new TableLayoutPanel();
            readersDataGrid = new DataGridView();
            readersToolBar = new MenuStrip();
            addReaderButton = new MaterialToolStripMenuItem();
            refreshReadersButton = new MaterialToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            searchReadersButton = new MaterialButton();
            searchReadersInput = new MaterialTextBox();
            booksListTab = new TabPage();
            bookListLayout = new TableLayoutPanel();
            booksDataGrid = new DataGridView();
            booksToolBar = new MenuStrip();
            addBookButton = new ToolStripMenuItem();
            refreshBooksButton = new ToolStripMenuItem();
            searchBooksLayout = new TableLayoutPanel();
            searchBooksInput = new MaterialTextBox();
            searchBooksButton = new MaterialButton();
            issuedBooksTab = new TabPage();
            issuedBooksTableLayout = new TableLayoutPanel();
            issuedBooksDataGrid = new DataGridView();
            issuedBooksToolBar = new MenuStrip();
            addIssueBookButton = new ToolStripMenuItem();
            refreshIssueBooksButton = new ToolStripMenuItem();
            searchIssueBooksTableLayout = new TableLayoutPanel();
            searchIssueBooksInput = new MaterialTextBox();
            searchIssueBooksButton = new MaterialButton();
            tabControl = new TabControl();
            quickActionsBox = new GroupBox();
            readingRoomsListTab.SuspendLayout();
            readingRoomsTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)readingRoomsDataGrid).BeginInit();
            readingRoomsToolBar.SuspendLayout();
            searchReadingRoomsLayout.SuspendLayout();
            readersListTab.SuspendLayout();
            readersTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)readersDataGrid).BeginInit();
            readersToolBar.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            booksListTab.SuspendLayout();
            bookListLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)booksDataGrid).BeginInit();
            booksToolBar.SuspendLayout();
            searchBooksLayout.SuspendLayout();
            issuedBooksTab.SuspendLayout();
            issuedBooksTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)issuedBooksDataGrid).BeginInit();
            issuedBooksToolBar.SuspendLayout();
            searchIssueBooksTableLayout.SuspendLayout();
            tabControl.SuspendLayout();
            SuspendLayout();
            // 
            // readingRoomsListTab
            // 
            readingRoomsListTab.Controls.Add(readingRoomsTableLayout);
            readingRoomsListTab.Location = new Point(4, 29);
            readingRoomsListTab.Name = "readingRoomsListTab";
            readingRoomsListTab.Size = new Size(625, 350);
            readingRoomsListTab.TabIndex = 3;
            readingRoomsListTab.Text = "Читальные залы";
            readingRoomsListTab.UseVisualStyleBackColor = true;
            // 
            // readingRoomsTableLayout
            // 
            readingRoomsTableLayout.AutoSize = true;
            readingRoomsTableLayout.ColumnCount = 1;
            readingRoomsTableLayout.ColumnStyles.Add(new ColumnStyle());
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
            readingRoomsTableLayout.Size = new Size(625, 350);
            readingRoomsTableLayout.TabIndex = 0;
            // 
            // readingRoomsDataGrid
            // 
            readingRoomsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            readingRoomsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            readingRoomsDataGrid.Dock = DockStyle.Fill;
            readingRoomsDataGrid.Location = new Point(3, 93);
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
            readingRoomsToolBar.Location = new Point(0, 62);
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
            searchReadingRoomsLayout.Size = new Size(625, 56);
            searchReadingRoomsLayout.TabIndex = 2;
            // 
            // searchReadingRoomsButton
            // 
            searchReadingRoomsButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            searchReadingRoomsButton.Density = MaterialButton.MaterialButtonDensity.Default;
            searchReadingRoomsButton.Depth = 0;
            searchReadingRoomsButton.Dock = DockStyle.Fill;
            searchReadingRoomsButton.HighEmphasis = true;
            searchReadingRoomsButton.Icon = null;
            searchReadingRoomsButton.Location = new Point(549, 6);
            searchReadingRoomsButton.Margin = new Padding(4, 6, 4, 6);
            searchReadingRoomsButton.MouseState = MaterialSkin.MouseState.HOVER;
            searchReadingRoomsButton.Name = "searchReadingRoomsButton";
            searchReadingRoomsButton.NoAccentTextColor = Color.Empty;
            searchReadingRoomsButton.Size = new Size(72, 44);
            searchReadingRoomsButton.TabIndex = 0;
            searchReadingRoomsButton.Text = "Поиск";
            searchReadingRoomsButton.Type = MaterialButton.MaterialButtonType.Contained;
            searchReadingRoomsButton.UseAccentColor = false;
            searchReadingRoomsButton.UseVisualStyleBackColor = true;
            searchReadingRoomsButton.Click += searchReadingRoomsButton_Click;
            // 
            // searchReadingRoomsInput
            // 
            searchReadingRoomsInput.AnimateReadOnly = false;
            searchReadingRoomsInput.BorderStyle = BorderStyle.None;
            searchReadingRoomsInput.Depth = 0;
            searchReadingRoomsInput.Dock = DockStyle.Fill;
            searchReadingRoomsInput.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            searchReadingRoomsInput.LeadingIcon = null;
            searchReadingRoomsInput.Location = new Point(3, 3);
            searchReadingRoomsInput.MaxLength = 50;
            searchReadingRoomsInput.MouseState = MaterialSkin.MouseState.OUT;
            searchReadingRoomsInput.Multiline = false;
            searchReadingRoomsInput.Name = "searchReadingRoomsInput";
            searchReadingRoomsInput.Size = new Size(539, 50);
            searchReadingRoomsInput.TabIndex = 1;
            searchReadingRoomsInput.Text = "";
            searchReadingRoomsInput.TrailingIcon = null;
            searchReadingRoomsInput.KeyDown += searchReadingRoomsInput_KeyDown;
            // 
            // miniToolStrip
            // 
            miniToolStrip.AccessibleName = "New item selection";
            miniToolStrip.AccessibleRole = AccessibleRole.ComboBox;
            miniToolStrip.AutoSize = false;
            miniToolStrip.Dock = DockStyle.None;
            miniToolStrip.ImageScalingSize = new Size(20, 20);
            miniToolStrip.Location = new Point(240, 2);
            miniToolStrip.Name = "miniToolStrip";
            miniToolStrip.Size = new Size(631, 28);
            miniToolStrip.TabIndex = 1;
            // 
            // readersListTab
            // 
            readersListTab.Controls.Add(readersTableLayout);
            readersListTab.Location = new Point(4, 29);
            readersListTab.Name = "readersListTab";
            readersListTab.Padding = new Padding(3);
            readersListTab.Size = new Size(625, 350);
            readersListTab.TabIndex = 2;
            readersListTab.Text = "Читатели";
            readersListTab.UseVisualStyleBackColor = true;
            // 
            // readersTableLayout
            // 
            readersTableLayout.AutoSize = true;
            readersTableLayout.ColumnCount = 1;
            readersTableLayout.ColumnStyles.Add(new ColumnStyle());
            readersTableLayout.Controls.Add(readersDataGrid, 0, 2);
            readersTableLayout.Controls.Add(readersToolBar, 0, 1);
            readersTableLayout.Controls.Add(tableLayoutPanel1, 0, 0);
            readersTableLayout.Dock = DockStyle.Fill;
            readersTableLayout.Location = new Point(3, 3);
            readersTableLayout.Name = "readersTableLayout";
            readersTableLayout.RowCount = 3;
            readersTableLayout.RowStyles.Add(new RowStyle());
            readersTableLayout.RowStyles.Add(new RowStyle());
            readersTableLayout.RowStyles.Add(new RowStyle());
            readersTableLayout.Size = new Size(619, 344);
            readersTableLayout.TabIndex = 0;
            // 
            // readersDataGrid
            // 
            readersDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            readersDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            readersDataGrid.Dock = DockStyle.Fill;
            readersDataGrid.Location = new Point(3, 93);
            readersDataGrid.Name = "readersDataGrid";
            readersDataGrid.ReadOnly = true;
            readersDataGrid.RowHeadersWidth = 51;
            readersDataGrid.RowTemplate.Height = 29;
            readersDataGrid.Size = new Size(619, 327);
            readersDataGrid.TabIndex = 1;
            readersDataGrid.CellContentClick += readersDataGrid_CellContentClick;
            readersDataGrid.CellFormatting += readersDataGrid_CellFormatting;
            readersDataGrid.DataBindingComplete += readersDataGrid_DataBindingComplete;
            // 
            // readersToolBar
            // 
            readersToolBar.Dock = DockStyle.Fill;
            readersToolBar.ImageScalingSize = new Size(20, 20);
            readersToolBar.Items.AddRange(new ToolStripItem[] { addReaderButton, refreshReadersButton });
            readersToolBar.Location = new Point(0, 62);
            readersToolBar.Name = "readersToolBar";
            readersToolBar.Size = new Size(625, 28);
            readersToolBar.TabIndex = 2;
            readersToolBar.Text = "readersToolBar";
            // 
            // addReaderButton
            // 
            addReaderButton.AutoSize = false;
            addReaderButton.Name = "addReaderButton";
            addReaderButton.Size = new Size(90, 24);
            addReaderButton.Text = "Добавить";
            addReaderButton.Click += addReaderButton_Click;
            // 
            // refreshReadersButton
            // 
            refreshReadersButton.AutoSize = false;
            refreshReadersButton.Name = "refreshReadersButton";
            refreshReadersButton.Size = new Size(144, 24);
            refreshReadersButton.Text = "Обновить список";
            refreshReadersButton.Click += refreshReadersButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(searchReadersButton, 1, 0);
            tableLayoutPanel1.Controls.Add(searchReadersInput, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(619, 56);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // searchReadersButton
            // 
            searchReadersButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            searchReadersButton.Density = MaterialButton.MaterialButtonDensity.Default;
            searchReadersButton.Depth = 0;
            searchReadersButton.Dock = DockStyle.Fill;
            searchReadersButton.HighEmphasis = true;
            searchReadersButton.Icon = null;
            searchReadersButton.Location = new Point(543, 6);
            searchReadersButton.Margin = new Padding(4, 6, 4, 6);
            searchReadersButton.MouseState = MaterialSkin.MouseState.HOVER;
            searchReadersButton.Name = "searchReadersButton";
            searchReadersButton.NoAccentTextColor = Color.Empty;
            searchReadersButton.Size = new Size(72, 44);
            searchReadersButton.TabIndex = 0;
            searchReadersButton.Text = "Поиск";
            searchReadersButton.Type = MaterialButton.MaterialButtonType.Contained;
            searchReadersButton.UseAccentColor = false;
            searchReadersButton.UseVisualStyleBackColor = true;
            // 
            // searchReadersInput
            // 
            searchReadersInput.AnimateReadOnly = false;
            searchReadersInput.BorderStyle = BorderStyle.None;
            searchReadersInput.Depth = 0;
            searchReadersInput.Dock = DockStyle.Fill;
            searchReadersInput.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            searchReadersInput.LeadingIcon = null;
            searchReadersInput.Location = new Point(3, 3);
            searchReadersInput.MaxLength = 50;
            searchReadersInput.MouseState = MaterialSkin.MouseState.OUT;
            searchReadersInput.Multiline = false;
            searchReadersInput.Name = "searchReadersInput";
            searchReadersInput.Size = new Size(533, 50);
            searchReadersInput.TabIndex = 1;
            searchReadersInput.Text = "";
            searchReadersInput.TrailingIcon = null;
            // 
            // booksListTab
            // 
            booksListTab.Controls.Add(bookListLayout);
            booksListTab.Location = new Point(4, 29);
            booksListTab.Name = "booksListTab";
            booksListTab.Padding = new Padding(3);
            booksListTab.Size = new Size(625, 350);
            booksListTab.TabIndex = 1;
            booksListTab.Text = "Список книг";
            booksListTab.UseVisualStyleBackColor = true;
            // 
            // bookListLayout
            // 
            bookListLayout.AutoSize = true;
            bookListLayout.ColumnCount = 1;
            bookListLayout.ColumnStyles.Add(new ColumnStyle());
            bookListLayout.Controls.Add(booksDataGrid, 0, 2);
            bookListLayout.Controls.Add(booksToolBar, 0, 1);
            bookListLayout.Controls.Add(searchBooksLayout, 0, 0);
            bookListLayout.Dock = DockStyle.Fill;
            bookListLayout.Location = new Point(3, 3);
            bookListLayout.Name = "bookListLayout";
            bookListLayout.RowCount = 3;
            bookListLayout.RowStyles.Add(new RowStyle());
            bookListLayout.RowStyles.Add(new RowStyle());
            bookListLayout.RowStyles.Add(new RowStyle());
            bookListLayout.Size = new Size(619, 344);
            bookListLayout.TabIndex = 0;
            // 
            // booksDataGrid
            // 
            booksDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            booksDataGrid.BackgroundColor = SystemColors.ActiveBorder;
            booksDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            booksDataGrid.Dock = DockStyle.Fill;
            booksDataGrid.Location = new Point(3, 93);
            booksDataGrid.Name = "booksDataGrid";
            booksDataGrid.RowHeadersWidth = 51;
            booksDataGrid.RowTemplate.Height = 29;
            booksDataGrid.Size = new Size(613, 342);
            booksDataGrid.TabIndex = 0;
            booksDataGrid.CellContentClick += BooksDataGrid_CellContentClick;
            booksDataGrid.DataBindingComplete += booksDataGrid_DataBindingComplete;
            // 
            // booksToolBar
            // 
            booksToolBar.Dock = DockStyle.Fill;
            booksToolBar.ImageScalingSize = new Size(20, 20);
            booksToolBar.Items.AddRange(new ToolStripItem[] { addBookButton, refreshBooksButton });
            booksToolBar.Location = new Point(0, 62);
            booksToolBar.Name = "booksToolBar";
            booksToolBar.Size = new Size(619, 28);
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
            searchBooksLayout.AutoSize = true;
            searchBooksLayout.ColumnCount = 2;
            searchBooksLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            searchBooksLayout.ColumnStyles.Add(new ColumnStyle());
            searchBooksLayout.Controls.Add(searchBooksInput, 0, 0);
            searchBooksLayout.Controls.Add(searchBooksButton, 1, 0);
            searchBooksLayout.Dock = DockStyle.Fill;
            searchBooksLayout.Location = new Point(3, 3);
            searchBooksLayout.Name = "searchBooksLayout";
            searchBooksLayout.RowCount = 1;
            searchBooksLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            searchBooksLayout.Size = new Size(613, 56);
            searchBooksLayout.TabIndex = 2;
            // 
            // searchBooksInput
            // 
            searchBooksInput.AnimateReadOnly = false;
            searchBooksInput.BorderStyle = BorderStyle.None;
            searchBooksInput.Depth = 0;
            searchBooksInput.Dock = DockStyle.Fill;
            searchBooksInput.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            searchBooksInput.LeadingIcon = null;
            searchBooksInput.Location = new Point(3, 3);
            searchBooksInput.MaxLength = 50;
            searchBooksInput.MouseState = MaterialSkin.MouseState.OUT;
            searchBooksInput.Multiline = false;
            searchBooksInput.Name = "searchBooksInput";
            searchBooksInput.Size = new Size(527, 50);
            searchBooksInput.TabIndex = 0;
            searchBooksInput.Text = "";
            searchBooksInput.TrailingIcon = null;
            searchBooksInput.KeyDown += searchBooksInput_KeyDown;
            // 
            // searchBooksButton
            // 
            searchBooksButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            searchBooksButton.Density = MaterialButton.MaterialButtonDensity.Default;
            searchBooksButton.Depth = 0;
            searchBooksButton.Dock = DockStyle.Fill;
            searchBooksButton.HighEmphasis = true;
            searchBooksButton.Icon = null;
            searchBooksButton.Location = new Point(537, 6);
            searchBooksButton.Margin = new Padding(4, 6, 4, 6);
            searchBooksButton.MouseState = MaterialSkin.MouseState.HOVER;
            searchBooksButton.Name = "searchBooksButton";
            searchBooksButton.NoAccentTextColor = Color.Empty;
            searchBooksButton.Size = new Size(72, 44);
            searchBooksButton.TabIndex = 1;
            searchBooksButton.Text = "Поиск";
            searchBooksButton.Type = MaterialButton.MaterialButtonType.Contained;
            searchBooksButton.UseAccentColor = false;
            searchBooksButton.UseVisualStyleBackColor = true;
            searchBooksButton.Click += searchBooksButton_Click;
            // 
            // issuedBooksTab
            // 
            issuedBooksTab.Controls.Add(issuedBooksTableLayout);
            issuedBooksTab.Location = new Point(4, 29);
            issuedBooksTab.Name = "issuedBooksTab";
            issuedBooksTab.Padding = new Padding(3);
            issuedBooksTab.Size = new Size(625, 350);
            issuedBooksTab.TabIndex = 0;
            issuedBooksTab.Text = "Выданные книги";
            issuedBooksTab.UseVisualStyleBackColor = true;
            // 
            // issuedBooksTableLayout
            // 
            issuedBooksTableLayout.AutoSize = true;
            issuedBooksTableLayout.ColumnCount = 1;
            issuedBooksTableLayout.ColumnStyles.Add(new ColumnStyle());
            issuedBooksTableLayout.Controls.Add(issuedBooksDataGrid, 0, 2);
            issuedBooksTableLayout.Controls.Add(issuedBooksToolBar, 0, 1);
            issuedBooksTableLayout.Controls.Add(searchIssueBooksTableLayout, 0, 0);
            issuedBooksTableLayout.Dock = DockStyle.Fill;
            issuedBooksTableLayout.Location = new Point(3, 3);
            issuedBooksTableLayout.Name = "issuedBooksTableLayout";
            issuedBooksTableLayout.RowCount = 3;
            issuedBooksTableLayout.RowStyles.Add(new RowStyle());
            issuedBooksTableLayout.RowStyles.Add(new RowStyle());
            issuedBooksTableLayout.RowStyles.Add(new RowStyle());
            issuedBooksTableLayout.Size = new Size(619, 344);
            issuedBooksTableLayout.TabIndex = 0;
            // 
            // issuedBooksDataGrid
            // 
            issuedBooksDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            issuedBooksDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            issuedBooksDataGrid.Dock = DockStyle.Fill;
            issuedBooksDataGrid.Location = new Point(3, 93);
            issuedBooksDataGrid.Name = "issuedBooksDataGrid";
            issuedBooksDataGrid.ReadOnly = true;
            issuedBooksDataGrid.RowHeadersWidth = 51;
            issuedBooksDataGrid.RowTemplate.Height = 29;
            issuedBooksDataGrid.Size = new Size(613, 248);
            issuedBooksDataGrid.TabIndex = 0;
            issuedBooksDataGrid.CellContentClick += issuedBooksDataGrid_CellContentClick;
            issuedBooksDataGrid.CellFormatting += issuedBooksDataGrid_CellFormatting;
            issuedBooksDataGrid.DataBindingComplete += issuedBooksDataGrid_DataBindingComplete;
            // 
            // issuedBooksToolBar
            // 
            issuedBooksToolBar.ImageScalingSize = new Size(20, 20);
            issuedBooksToolBar.Items.AddRange(new ToolStripItem[] { addIssueBookButton, refreshIssueBooksButton });
            issuedBooksToolBar.Location = new Point(0, 62);
            issuedBooksToolBar.Name = "issuedBooksToolBar";
            issuedBooksToolBar.Size = new Size(619, 28);
            issuedBooksToolBar.TabIndex = 1;
            issuedBooksToolBar.Text = "menuStrip1";
            // 
            // addIssueBookButton
            // 
            addIssueBookButton.Name = "addIssueBookButton";
            addIssueBookButton.Size = new Size(90, 24);
            addIssueBookButton.Text = "Добавить";
            addIssueBookButton.Click += addIssueBookButton_Click;
            // 
            // refreshIssueBooksButton
            // 
            refreshIssueBooksButton.Name = "refreshIssueBooksButton";
            refreshIssueBooksButton.Size = new Size(144, 24);
            refreshIssueBooksButton.Text = "Обновить список";
            refreshIssueBooksButton.Click += refreshIssueBooksButton_Click;
            // 
            // searchIssueBooksTableLayout
            // 
            searchIssueBooksTableLayout.AutoScroll = true;
            searchIssueBooksTableLayout.AutoSize = true;
            searchIssueBooksTableLayout.ColumnCount = 2;
            searchIssueBooksTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            searchIssueBooksTableLayout.ColumnStyles.Add(new ColumnStyle());
            searchIssueBooksTableLayout.Controls.Add(searchIssueBooksInput, 0, 0);
            searchIssueBooksTableLayout.Controls.Add(searchIssueBooksButton, 1, 0);
            searchIssueBooksTableLayout.Dock = DockStyle.Fill;
            searchIssueBooksTableLayout.Location = new Point(3, 3);
            searchIssueBooksTableLayout.Name = "searchIssueBooksTableLayout";
            searchIssueBooksTableLayout.RowCount = 1;
            searchIssueBooksTableLayout.RowStyles.Add(new RowStyle());
            searchIssueBooksTableLayout.Size = new Size(613, 56);
            searchIssueBooksTableLayout.TabIndex = 2;
            // 
            // searchIssueBooksInput
            // 
            searchIssueBooksInput.AnimateReadOnly = false;
            searchIssueBooksInput.BorderStyle = BorderStyle.None;
            searchIssueBooksInput.Depth = 0;
            searchIssueBooksInput.Dock = DockStyle.Fill;
            searchIssueBooksInput.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            searchIssueBooksInput.LeadingIcon = null;
            searchIssueBooksInput.Location = new Point(3, 3);
            searchIssueBooksInput.MaxLength = 50;
            searchIssueBooksInput.MouseState = MaterialSkin.MouseState.OUT;
            searchIssueBooksInput.Multiline = false;
            searchIssueBooksInput.Name = "searchIssueBooksInput";
            searchIssueBooksInput.Size = new Size(527, 50);
            searchIssueBooksInput.TabIndex = 0;
            searchIssueBooksInput.Text = "";
            searchIssueBooksInput.TrailingIcon = null;
            // 
            // searchIssueBooksButton
            // 
            searchIssueBooksButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            searchIssueBooksButton.Density = MaterialButton.MaterialButtonDensity.Default;
            searchIssueBooksButton.Depth = 0;
            searchIssueBooksButton.Dock = DockStyle.Fill;
            searchIssueBooksButton.HighEmphasis = true;
            searchIssueBooksButton.Icon = null;
            searchIssueBooksButton.Location = new Point(537, 6);
            searchIssueBooksButton.Margin = new Padding(4, 6, 4, 6);
            searchIssueBooksButton.MouseState = MaterialSkin.MouseState.HOVER;
            searchIssueBooksButton.Name = "searchIssueBooksButton";
            searchIssueBooksButton.NoAccentTextColor = Color.Empty;
            searchIssueBooksButton.Size = new Size(72, 44);
            searchIssueBooksButton.TabIndex = 1;
            searchIssueBooksButton.Text = "Поиск";
            searchIssueBooksButton.Type = MaterialButton.MaterialButtonType.Contained;
            searchIssueBooksButton.UseAccentColor = false;
            searchIssueBooksButton.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(issuedBooksTab);
            tabControl.Controls.Add(booksListTab);
            tabControl.Controls.Add(readersListTab);
            tabControl.Controls.Add(readingRoomsListTab);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(164, 64);
            tabControl.Multiline = true;
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(633, 383);
            tabControl.SizeMode = TabSizeMode.FillToRight;
            tabControl.TabIndex = 1;
            // 
            // quickActionsBox
            // 
            quickActionsBox.Dock = DockStyle.Left;
            quickActionsBox.Location = new Point(3, 64);
            quickActionsBox.Name = "quickActionsBox";
            quickActionsBox.Size = new Size(161, 383);
            quickActionsBox.TabIndex = 0;
            quickActionsBox.TabStop = false;
            quickActionsBox.Text = "Быстрые действия";
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
            Text = "Bookful";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            readingRoomsListTab.ResumeLayout(false);
            readingRoomsListTab.PerformLayout();
            readingRoomsTableLayout.ResumeLayout(false);
            readingRoomsTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)readingRoomsDataGrid).EndInit();
            readingRoomsToolBar.ResumeLayout(false);
            readingRoomsToolBar.PerformLayout();
            searchReadingRoomsLayout.ResumeLayout(false);
            searchReadingRoomsLayout.PerformLayout();
            readersListTab.ResumeLayout(false);
            readersListTab.PerformLayout();
            readersTableLayout.ResumeLayout(false);
            readersTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)readersDataGrid).EndInit();
            readersToolBar.ResumeLayout(false);
            readersToolBar.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            booksListTab.ResumeLayout(false);
            booksListTab.PerformLayout();
            bookListLayout.ResumeLayout(false);
            bookListLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)booksDataGrid).EndInit();
            booksToolBar.ResumeLayout(false);
            booksToolBar.PerformLayout();
            searchBooksLayout.ResumeLayout(false);
            searchBooksLayout.PerformLayout();
            issuedBooksTab.ResumeLayout(false);
            issuedBooksTab.PerformLayout();
            issuedBooksTableLayout.ResumeLayout(false);
            issuedBooksTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)issuedBooksDataGrid).EndInit();
            issuedBooksToolBar.ResumeLayout(false);
            issuedBooksToolBar.PerformLayout();
            searchIssueBooksTableLayout.ResumeLayout(false);
            searchIssueBooksTableLayout.PerformLayout();
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabPage readingRoomsListTab;
        private TableLayoutPanel readingRoomsTableLayout;
        private DataGridView readingRoomsDataGrid;
        private MenuStrip readingRoomsToolBar;
        private ToolStripMenuItem addReadingRoomButton;
        private ToolStripMenuItem refreshReadingRoomsButton;
        private TableLayoutPanel searchReadingRoomsLayout;
        private MaterialButton searchReadingRoomsButton;
        private MaterialTextBox searchReadingRoomsInput;
        private MenuStrip miniToolStrip;
        private TabPage readersListTab;
        private TableLayoutPanel readersTableLayout;
        private DataGridView readersDataGrid;
        private MenuStrip readersToolBar;
        private MaterialToolStripMenuItem addReaderButton;
        private MaterialToolStripMenuItem refreshReadersButton;
        private TabPage booksListTab;
        private TableLayoutPanel bookListLayout;
        private DataGridView booksDataGrid;
        private MenuStrip booksToolBar;
        private ToolStripMenuItem addBookButton;
        private ToolStripMenuItem refreshBooksButton;
        private TableLayoutPanel searchBooksLayout;
        private MaterialTextBox searchBooksInput;
        private MaterialButton searchBooksButton;
        private TabPage issuedBooksTab;
        private TabControl tabControl;
        private GroupBox quickActionsBox;
        private TableLayoutPanel tableLayoutPanel1;
        private MaterialButton searchReadersButton;
        private MaterialTextBox searchReadersInput;
        private TableLayoutPanel issuedBooksTableLayout;
        private DataGridView issuedBooksDataGrid;
        private MenuStrip issuedBooksToolBar;
        private ToolStripMenuItem addIssueBookButton;
        private ToolStripMenuItem refreshIssueBooksButton;
        private TableLayoutPanel searchIssueBooksTableLayout;
        private MaterialTextBox searchIssueBooksInput;
        private MaterialButton searchIssueBooksButton;
    }
}