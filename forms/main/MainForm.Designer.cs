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
            ListViewGroup listViewGroup1 = new ListViewGroup("Обновить список", HorizontalAlignment.Center);
            ListViewGroup listViewGroup2 = new ListViewGroup("Переключение вкладок", HorizontalAlignment.Center);
            ListViewGroup listViewGroup3 = new ListViewGroup("Поиск", HorizontalAlignment.Center);
            ListViewItem listViewItem1 = new ListViewItem("F5");
            ListViewItem listViewItem2 = new ListViewItem("Ctrl + цифра");
            ListViewItem listViewItem3 = new ListViewItem("Enter");
            ListViewGroup listViewGroup4 = new ListViewGroup("Обновить список", HorizontalAlignment.Center);
            ListViewGroup listViewGroup5 = new ListViewGroup("Переключение вкладок", HorizontalAlignment.Center);
            ListViewGroup listViewGroup6 = new ListViewGroup("Поиск", HorizontalAlignment.Center);
            ListViewItem listViewItem4 = new ListViewItem("F5");
            ListViewItem listViewItem5 = new ListViewItem("Ctrl + цифра");
            ListViewItem listViewItem6 = new ListViewItem("Enter");
            ListViewGroup listViewGroup7 = new ListViewGroup("Обновить список", HorizontalAlignment.Center);
            ListViewGroup listViewGroup8 = new ListViewGroup("Переключение вкладок", HorizontalAlignment.Center);
            ListViewGroup listViewGroup9 = new ListViewGroup("Поиск", HorizontalAlignment.Center);
            ListViewItem listViewItem7 = new ListViewItem("F5");
            ListViewItem listViewItem8 = new ListViewItem("Ctrl + цифра");
            ListViewItem listViewItem9 = new ListViewItem("Enter");
            ListViewGroup listViewGroup10 = new ListViewGroup("Обновить список", HorizontalAlignment.Center);
            ListViewGroup listViewGroup11 = new ListViewGroup("Переключение вкладок", HorizontalAlignment.Center);
            ListViewGroup listViewGroup12 = new ListViewGroup("Поиск", HorizontalAlignment.Center);
            ListViewItem listViewItem10 = new ListViewItem("F5");
            ListViewItem listViewItem11 = new ListViewItem("Ctrl + цифра");
            ListViewItem listViewItem12 = new ListViewItem("Enter");
            readingRoomsListTab = new TabPage();
            readingRoomsTableLayout = new TableLayoutPanel();
            groupBox3 = new GroupBox();
            listView4 = new ListView();
            readingRoomsDataGrid = new DataGridView();
            readingRoomsToolBar = new MenuStrip();
            addReadingRoomButton = new ToolStripMenuItem();
            refreshReadingRoomsButton = new ToolStripMenuItem();
            editReadingRoomButton = new ToolStripMenuItem();
            deleteReadingRoomButton = new ToolStripMenuItem();
            searchReadingRoomsLayout = new TableLayoutPanel();
            searchReadingRoomsButton = new MaterialButton();
            searchReadingRoomsInput = new MaterialTextBox();
            miniToolStrip = new MenuStrip();
            readersListTab = new TabPage();
            readersTableLayout = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            listView3 = new ListView();
            readersDataGrid = new DataGridView();
            readersToolBar = new MenuStrip();
            addReaderButton = new MaterialToolStripMenuItem();
            refreshReadersButton = new MaterialToolStripMenuItem();
            editReaderButton = new ToolStripMenuItem();
            deleteReaderButton = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            searchReadersButton = new MaterialButton();
            searchReadersInput = new MaterialTextBox();
            booksListTab = new TabPage();
            bookListLayout = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            listView2 = new ListView();
            booksDataGrid = new DataGridView();
            booksToolBar = new MenuStrip();
            addBookButton = new ToolStripMenuItem();
            refreshBooksButton = new ToolStripMenuItem();
            editBookButton = new ToolStripMenuItem();
            deleteBookButton = new ToolStripMenuItem();
            searchBooksLayout = new TableLayoutPanel();
            searchBooksInput = new MaterialTextBox();
            searchBooksButton = new MaterialButton();
            issuedBooksTab = new TabPage();
            issuedBooksTableLayout = new TableLayoutPanel();
            quickActionsBox = new GroupBox();
            listView1 = new ListView();
            issuedBooksDataGrid = new DataGridView();
            issuedBooksToolBar = new MenuStrip();
            addIssueBookButton = new MaterialToolStripMenuItem();
            refreshIssueBooksButton = new ToolStripMenuItem();
            editIssuedBookButton = new ToolStripMenuItem();
            deleteIssuedBookButton = new ToolStripMenuItem();
            searchIssueBooksTableLayout = new TableLayoutPanel();
            searchIssueBooksInput = new MaterialTextBox();
            searchIssueBooksButton = new MaterialButton();
            tabControl = new TabControl();
            readingRoomsListTab.SuspendLayout();
            readingRoomsTableLayout.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)readingRoomsDataGrid).BeginInit();
            readingRoomsToolBar.SuspendLayout();
            searchReadingRoomsLayout.SuspendLayout();
            readersListTab.SuspendLayout();
            readersTableLayout.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)readersDataGrid).BeginInit();
            readersToolBar.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            booksListTab.SuspendLayout();
            bookListLayout.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)booksDataGrid).BeginInit();
            booksToolBar.SuspendLayout();
            searchBooksLayout.SuspendLayout();
            issuedBooksTab.SuspendLayout();
            issuedBooksTableLayout.SuspendLayout();
            quickActionsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)issuedBooksDataGrid).BeginInit();
            issuedBooksToolBar.SuspendLayout();
            searchIssueBooksTableLayout.SuspendLayout();
            tabControl.SuspendLayout();
            SuspendLayout();
            // 
            // readingRoomsListTab
            // 
            readingRoomsListTab.Controls.Add(readingRoomsTableLayout);
            readingRoomsListTab.Location = new Point(4, 28);
            readingRoomsListTab.Name = "readingRoomsListTab";
            readingRoomsListTab.Size = new Size(786, 351);
            readingRoomsListTab.TabIndex = 3;
            readingRoomsListTab.Text = "Читальные залы";
            readingRoomsListTab.UseVisualStyleBackColor = true;
            // 
            // readingRoomsTableLayout
            // 
            readingRoomsTableLayout.AutoSize = true;
            readingRoomsTableLayout.ColumnCount = 2;
            readingRoomsTableLayout.ColumnStyles.Add(new ColumnStyle());
            readingRoomsTableLayout.ColumnStyles.Add(new ColumnStyle());
            readingRoomsTableLayout.Controls.Add(groupBox3, 0, 0);
            readingRoomsTableLayout.Controls.Add(readingRoomsDataGrid, 1, 2);
            readingRoomsTableLayout.Controls.Add(readingRoomsToolBar, 1, 1);
            readingRoomsTableLayout.Controls.Add(searchReadingRoomsLayout, 1, 0);
            readingRoomsTableLayout.Dock = DockStyle.Fill;
            readingRoomsTableLayout.Location = new Point(0, 0);
            readingRoomsTableLayout.Name = "readingRoomsTableLayout";
            readingRoomsTableLayout.RowCount = 3;
            readingRoomsTableLayout.RowStyles.Add(new RowStyle());
            readingRoomsTableLayout.RowStyles.Add(new RowStyle());
            readingRoomsTableLayout.RowStyles.Add(new RowStyle());
            readingRoomsTableLayout.Size = new Size(786, 351);
            readingRoomsTableLayout.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(listView4);
            groupBox3.Dock = DockStyle.Left;
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            readingRoomsTableLayout.SetRowSpan(groupBox3, 3);
            groupBox3.Size = new Size(210, 473);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Быстрые действия";
            // 
            // listView4
            // 
            listView4.Alignment = ListViewAlignment.Left;
            listView4.BorderStyle = BorderStyle.None;
            listView4.Dock = DockStyle.Fill;
            listView4.Enabled = false;
            listView4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            listViewGroup1.Header = "Обновить список";
            listViewGroup1.HeaderAlignment = HorizontalAlignment.Center;
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup1.Tag = "";
            listViewGroup2.Header = "Переключение вкладок";
            listViewGroup2.HeaderAlignment = HorizontalAlignment.Center;
            listViewGroup2.Name = "listViewGroup2";
            listViewGroup3.Header = "Поиск";
            listViewGroup3.HeaderAlignment = HorizontalAlignment.Center;
            listViewGroup3.Name = "listViewGroup3";
            listView4.Groups.AddRange(new ListViewGroup[] { listViewGroup1, listViewGroup2, listViewGroup3 });
            listViewItem1.Group = listViewGroup1;
            listViewItem1.UseItemStyleForSubItems = false;
            listViewItem2.Group = listViewGroup2;
            listViewItem3.Group = listViewGroup3;
            listView4.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            listView4.Location = new Point(3, 23);
            listView4.Name = "listView4";
            listView4.Size = new Size(204, 447);
            listView4.TabIndex = 0;
            listView4.UseCompatibleStateImageBehavior = false;
            listView4.View = View.SmallIcon;
            // 
            // readingRoomsDataGrid
            // 
            readingRoomsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            readingRoomsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            readingRoomsDataGrid.Dock = DockStyle.Fill;
            readingRoomsDataGrid.Location = new Point(219, 93);
            readingRoomsDataGrid.Name = "readingRoomsDataGrid";
            readingRoomsDataGrid.ReadOnly = true;
            readingRoomsDataGrid.RowHeadersWidth = 51;
            readingRoomsDataGrid.RowTemplate.Height = 29;
            readingRoomsDataGrid.Size = new Size(780, 383);
            readingRoomsDataGrid.TabIndex = 0;
            readingRoomsDataGrid.DataBindingComplete += readingRoomsDataGrid_DataBindingComplete;
            // 
            // readingRoomsToolBar
            // 
            readingRoomsToolBar.Dock = DockStyle.Fill;
            readingRoomsToolBar.ImageScalingSize = new Size(20, 20);
            readingRoomsToolBar.Items.AddRange(new ToolStripItem[] { addReadingRoomButton, refreshReadingRoomsButton, editReadingRoomButton, deleteReadingRoomButton });
            readingRoomsToolBar.Location = new Point(216, 62);
            readingRoomsToolBar.Name = "readingRoomsToolBar";
            readingRoomsToolBar.Size = new Size(786, 28);
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
            // editReadingRoomButton
            // 
            editReadingRoomButton.Name = "editReadingRoomButton";
            editReadingRoomButton.Size = new Size(92, 24);
            editReadingRoomButton.Text = "Изменить";
            editReadingRoomButton.Click += editReadingRoomButton_Click;
            // 
            // deleteReadingRoomButton
            // 
            deleteReadingRoomButton.Name = "deleteReadingRoomButton";
            deleteReadingRoomButton.Size = new Size(79, 24);
            deleteReadingRoomButton.Text = "Удалить";
            deleteReadingRoomButton.Click += deleteReadingRoomButton_Click;
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
            searchReadingRoomsLayout.Location = new Point(219, 3);
            searchReadingRoomsLayout.Name = "searchReadingRoomsLayout";
            searchReadingRoomsLayout.RowCount = 1;
            searchReadingRoomsLayout.RowStyles.Add(new RowStyle());
            searchReadingRoomsLayout.Size = new Size(780, 56);
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
            searchReadingRoomsButton.Location = new Point(704, 6);
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
            searchReadingRoomsInput.Size = new Size(694, 50);
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
            readersListTab.Location = new Point(4, 28);
            readersListTab.Name = "readersListTab";
            readersListTab.Padding = new Padding(3);
            readersListTab.Size = new Size(786, 351);
            readersListTab.TabIndex = 2;
            readersListTab.Text = "Читатели";
            readersListTab.UseVisualStyleBackColor = true;
            // 
            // readersTableLayout
            // 
            readersTableLayout.AutoSize = true;
            readersTableLayout.ColumnCount = 2;
            readersTableLayout.ColumnStyles.Add(new ColumnStyle());
            readersTableLayout.ColumnStyles.Add(new ColumnStyle());
            readersTableLayout.Controls.Add(groupBox2, 0, 0);
            readersTableLayout.Controls.Add(readersDataGrid, 1, 2);
            readersTableLayout.Controls.Add(readersToolBar, 1, 1);
            readersTableLayout.Controls.Add(tableLayoutPanel1, 1, 0);
            readersTableLayout.Dock = DockStyle.Fill;
            readersTableLayout.Location = new Point(3, 3);
            readersTableLayout.Name = "readersTableLayout";
            readersTableLayout.RowCount = 3;
            readersTableLayout.RowStyles.Add(new RowStyle());
            readersTableLayout.RowStyles.Add(new RowStyle());
            readersTableLayout.RowStyles.Add(new RowStyle());
            readersTableLayout.Size = new Size(780, 345);
            readersTableLayout.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView3);
            groupBox2.Dock = DockStyle.Left;
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            readersTableLayout.SetRowSpan(groupBox2, 3);
            groupBox2.Size = new Size(210, 473);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Быстрые действия";
            // 
            // listView3
            // 
            listView3.Alignment = ListViewAlignment.Left;
            listView3.BorderStyle = BorderStyle.None;
            listView3.Dock = DockStyle.Fill;
            listView3.Enabled = false;
            listView3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            listViewGroup4.Header = "Обновить список";
            listViewGroup4.HeaderAlignment = HorizontalAlignment.Center;
            listViewGroup4.Name = "listViewGroup1";
            listViewGroup4.Tag = "";
            listViewGroup5.Header = "Переключение вкладок";
            listViewGroup5.HeaderAlignment = HorizontalAlignment.Center;
            listViewGroup5.Name = "listViewGroup2";
            listViewGroup6.Header = "Поиск";
            listViewGroup6.HeaderAlignment = HorizontalAlignment.Center;
            listViewGroup6.Name = "listViewGroup3";
            listView3.Groups.AddRange(new ListViewGroup[] { listViewGroup4, listViewGroup5, listViewGroup6 });
            listViewItem4.Group = listViewGroup4;
            listViewItem4.UseItemStyleForSubItems = false;
            listViewItem5.Group = listViewGroup5;
            listViewItem6.Group = listViewGroup6;
            listView3.Items.AddRange(new ListViewItem[] { listViewItem4, listViewItem5, listViewItem6 });
            listView3.Location = new Point(3, 23);
            listView3.Name = "listView3";
            listView3.Size = new Size(204, 447);
            listView3.TabIndex = 0;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.SmallIcon;
            // 
            // readersDataGrid
            // 
            readersDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            readersDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            readersDataGrid.Dock = DockStyle.Fill;
            readersDataGrid.Location = new Point(219, 93);
            readersDataGrid.Name = "readersDataGrid";
            readersDataGrid.ReadOnly = true;
            readersDataGrid.RowHeadersWidth = 51;
            readersDataGrid.RowTemplate.Height = 29;
            readersDataGrid.Size = new Size(774, 383);
            readersDataGrid.TabIndex = 1;
            readersDataGrid.CellFormatting += readersDataGrid_CellFormatting;
            readersDataGrid.DataBindingComplete += readersDataGrid_DataBindingComplete;
            // 
            // readersToolBar
            // 
            readersToolBar.Dock = DockStyle.Fill;
            readersToolBar.ImageScalingSize = new Size(20, 20);
            readersToolBar.Items.AddRange(new ToolStripItem[] { addReaderButton, refreshReadersButton, editReaderButton, deleteReaderButton });
            readersToolBar.Location = new Point(216, 62);
            readersToolBar.Name = "readersToolBar";
            readersToolBar.Size = new Size(780, 28);
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
            // editReaderButton
            // 
            editReaderButton.Name = "editReaderButton";
            editReaderButton.Size = new Size(92, 24);
            editReaderButton.Text = "Изменить";
            editReaderButton.Click += editReaderButton_Click;
            // 
            // deleteReaderButton
            // 
            deleteReaderButton.Name = "deleteReaderButton";
            deleteReaderButton.Size = new Size(79, 24);
            deleteReaderButton.Text = "Удалить";
            deleteReaderButton.Click += deleteReaderButton_Click;
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
            tableLayoutPanel1.Location = new Point(219, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(774, 56);
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
            searchReadersButton.Location = new Point(698, 6);
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
            searchReadersButton.Click += searchReadersButton_Click;
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
            searchReadersInput.Size = new Size(688, 50);
            searchReadersInput.TabIndex = 1;
            searchReadersInput.Text = "";
            searchReadersInput.TrailingIcon = null;
            searchReadersInput.KeyDown += searchReadersInput_KeyDown;
            // 
            // booksListTab
            // 
            booksListTab.Controls.Add(bookListLayout);
            booksListTab.Location = new Point(4, 28);
            booksListTab.Name = "booksListTab";
            booksListTab.Padding = new Padding(3);
            booksListTab.Size = new Size(786, 351);
            booksListTab.TabIndex = 1;
            booksListTab.Text = "Список книг";
            booksListTab.UseVisualStyleBackColor = true;
            // 
            // bookListLayout
            // 
            bookListLayout.AutoSize = true;
            bookListLayout.ColumnCount = 2;
            bookListLayout.ColumnStyles.Add(new ColumnStyle());
            bookListLayout.ColumnStyles.Add(new ColumnStyle());
            bookListLayout.Controls.Add(groupBox1, 0, 0);
            bookListLayout.Controls.Add(booksDataGrid, 1, 2);
            bookListLayout.Controls.Add(booksToolBar, 1, 1);
            bookListLayout.Controls.Add(searchBooksLayout, 1, 0);
            bookListLayout.Dock = DockStyle.Fill;
            bookListLayout.Location = new Point(3, 3);
            bookListLayout.Name = "bookListLayout";
            bookListLayout.RowCount = 3;
            bookListLayout.RowStyles.Add(new RowStyle());
            bookListLayout.RowStyles.Add(new RowStyle());
            bookListLayout.RowStyles.Add(new RowStyle());
            bookListLayout.Size = new Size(780, 345);
            bookListLayout.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView2);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            bookListLayout.SetRowSpan(groupBox1, 3);
            groupBox1.Size = new Size(210, 473);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Быстрые действия";
            // 
            // listView2
            // 
            listView2.Alignment = ListViewAlignment.Left;
            listView2.BorderStyle = BorderStyle.None;
            listView2.Dock = DockStyle.Fill;
            listView2.Enabled = false;
            listView2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            listViewGroup7.Header = "Обновить список";
            listViewGroup7.HeaderAlignment = HorizontalAlignment.Center;
            listViewGroup7.Name = "listViewGroup1";
            listViewGroup7.Tag = "";
            listViewGroup8.Header = "Переключение вкладок";
            listViewGroup8.HeaderAlignment = HorizontalAlignment.Center;
            listViewGroup8.Name = "listViewGroup2";
            listViewGroup9.Header = "Поиск";
            listViewGroup9.HeaderAlignment = HorizontalAlignment.Center;
            listViewGroup9.Name = "listViewGroup3";
            listView2.Groups.AddRange(new ListViewGroup[] { listViewGroup7, listViewGroup8, listViewGroup9 });
            listViewItem7.Group = listViewGroup7;
            listViewItem7.UseItemStyleForSubItems = false;
            listViewItem8.Group = listViewGroup8;
            listViewItem9.Group = listViewGroup9;
            listView2.Items.AddRange(new ListViewItem[] { listViewItem7, listViewItem8, listViewItem9 });
            listView2.Location = new Point(3, 23);
            listView2.Name = "listView2";
            listView2.Size = new Size(204, 447);
            listView2.TabIndex = 0;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.SmallIcon;
            // 
            // booksDataGrid
            // 
            booksDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            booksDataGrid.BackgroundColor = SystemColors.ActiveBorder;
            booksDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            booksDataGrid.Dock = DockStyle.Fill;
            booksDataGrid.Location = new Point(219, 93);
            booksDataGrid.Name = "booksDataGrid";
            booksDataGrid.ReadOnly = true;
            booksDataGrid.RowHeadersWidth = 51;
            booksDataGrid.RowTemplate.Height = 29;
            booksDataGrid.Size = new Size(774, 383);
            booksDataGrid.TabIndex = 0;
            booksDataGrid.DataBindingComplete += booksDataGrid_DataBindingComplete;
            // 
            // booksToolBar
            // 
            booksToolBar.Dock = DockStyle.Fill;
            booksToolBar.ImageScalingSize = new Size(20, 20);
            booksToolBar.Items.AddRange(new ToolStripItem[] { addBookButton, refreshBooksButton, editBookButton, deleteBookButton });
            booksToolBar.Location = new Point(216, 62);
            booksToolBar.Name = "booksToolBar";
            booksToolBar.Size = new Size(780, 28);
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
            // editBookButton
            // 
            editBookButton.Name = "editBookButton";
            editBookButton.Size = new Size(92, 24);
            editBookButton.Text = "Изменить";
            editBookButton.Click += editBookButton_Click;
            // 
            // deleteBookButton
            // 
            deleteBookButton.Name = "deleteBookButton";
            deleteBookButton.Size = new Size(79, 24);
            deleteBookButton.Text = "Удалить";
            deleteBookButton.Click += deleteBookButton_Click;
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
            searchBooksLayout.Location = new Point(219, 3);
            searchBooksLayout.Name = "searchBooksLayout";
            searchBooksLayout.RowCount = 1;
            searchBooksLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            searchBooksLayout.Size = new Size(774, 56);
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
            searchBooksInput.Size = new Size(688, 50);
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
            searchBooksButton.Location = new Point(698, 6);
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
            issuedBooksTab.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            issuedBooksTab.Location = new Point(4, 28);
            issuedBooksTab.Name = "issuedBooksTab";
            issuedBooksTab.Padding = new Padding(3);
            issuedBooksTab.Size = new Size(786, 351);
            issuedBooksTab.TabIndex = 0;
            issuedBooksTab.Text = "Выданные книги";
            issuedBooksTab.UseVisualStyleBackColor = true;
            // 
            // issuedBooksTableLayout
            // 
            issuedBooksTableLayout.AutoSize = true;
            issuedBooksTableLayout.ColumnCount = 2;
            issuedBooksTableLayout.ColumnStyles.Add(new ColumnStyle());
            issuedBooksTableLayout.ColumnStyles.Add(new ColumnStyle());
            issuedBooksTableLayout.Controls.Add(quickActionsBox, 0, 0);
            issuedBooksTableLayout.Controls.Add(issuedBooksDataGrid, 1, 2);
            issuedBooksTableLayout.Controls.Add(issuedBooksToolBar, 1, 1);
            issuedBooksTableLayout.Controls.Add(searchIssueBooksTableLayout, 1, 0);
            issuedBooksTableLayout.Dock = DockStyle.Fill;
            issuedBooksTableLayout.Location = new Point(3, 3);
            issuedBooksTableLayout.Name = "issuedBooksTableLayout";
            issuedBooksTableLayout.RowCount = 3;
            issuedBooksTableLayout.RowStyles.Add(new RowStyle());
            issuedBooksTableLayout.RowStyles.Add(new RowStyle());
            issuedBooksTableLayout.RowStyles.Add(new RowStyle());
            issuedBooksTableLayout.Size = new Size(780, 345);
            issuedBooksTableLayout.TabIndex = 0;
            // 
            // quickActionsBox
            // 
            quickActionsBox.Controls.Add(listView1);
            quickActionsBox.Dock = DockStyle.Left;
            quickActionsBox.Location = new Point(3, 3);
            quickActionsBox.Name = "quickActionsBox";
            issuedBooksTableLayout.SetRowSpan(quickActionsBox, 3);
            quickActionsBox.Size = new Size(210, 473);
            quickActionsBox.TabIndex = 3;
            quickActionsBox.TabStop = false;
            quickActionsBox.Text = "Быстрые действия";
            // 
            // listView1
            // 
            listView1.Alignment = ListViewAlignment.Left;
            listView1.BorderStyle = BorderStyle.None;
            listView1.Dock = DockStyle.Fill;
            listView1.Enabled = false;
            listView1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            listViewGroup10.Header = "Обновить список";
            listViewGroup10.HeaderAlignment = HorizontalAlignment.Center;
            listViewGroup10.Name = "listViewGroup1";
            listViewGroup10.Tag = "";
            listViewGroup11.Header = "Переключение вкладок";
            listViewGroup11.HeaderAlignment = HorizontalAlignment.Center;
            listViewGroup11.Name = "listViewGroup2";
            listViewGroup12.Header = "Поиск";
            listViewGroup12.HeaderAlignment = HorizontalAlignment.Center;
            listViewGroup12.Name = "listViewGroup3";
            listView1.Groups.AddRange(new ListViewGroup[] { listViewGroup10, listViewGroup11, listViewGroup12 });
            listViewItem10.Group = listViewGroup10;
            listViewItem10.UseItemStyleForSubItems = false;
            listViewItem11.Group = listViewGroup11;
            listViewItem12.Group = listViewGroup12;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem10, listViewItem11, listViewItem12 });
            listView1.Location = new Point(3, 23);
            listView1.Name = "listView1";
            listView1.Size = new Size(204, 447);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.SmallIcon;
            // 
            // issuedBooksDataGrid
            // 
            issuedBooksDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            issuedBooksDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            issuedBooksDataGrid.Dock = DockStyle.Fill;
            issuedBooksDataGrid.Location = new Point(219, 93);
            issuedBooksDataGrid.Name = "issuedBooksDataGrid";
            issuedBooksDataGrid.ReadOnly = true;
            issuedBooksDataGrid.RowHeadersWidth = 51;
            issuedBooksDataGrid.RowTemplate.Height = 29;
            issuedBooksDataGrid.Size = new Size(558, 383);
            issuedBooksDataGrid.TabIndex = 0;
            issuedBooksDataGrid.CellFormatting += issuedBooksDataGrid_CellFormatting;
            issuedBooksDataGrid.DataBindingComplete += issuedBooksDataGrid_DataBindingComplete;
            // 
            // issuedBooksToolBar
            // 
            issuedBooksToolBar.ImageScalingSize = new Size(20, 20);
            issuedBooksToolBar.Items.AddRange(new ToolStripItem[] { addIssueBookButton, refreshIssueBooksButton, editIssuedBookButton, deleteIssuedBookButton });
            issuedBooksToolBar.Location = new Point(216, 62);
            issuedBooksToolBar.Name = "issuedBooksToolBar";
            issuedBooksToolBar.Size = new Size(564, 28);
            issuedBooksToolBar.TabIndex = 1;
            issuedBooksToolBar.Text = "menuStrip1";
            // 
            // addIssueBookButton
            // 
            addIssueBookButton.AutoSize = false;
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
            // editIssuedBookButton
            // 
            editIssuedBookButton.Name = "editIssuedBookButton";
            editIssuedBookButton.Size = new Size(92, 24);
            editIssuedBookButton.Text = "Изменить";
            editIssuedBookButton.Click += editIssuedBookButton_Click;
            // 
            // deleteIssuedBookButton
            // 
            deleteIssuedBookButton.Name = "deleteIssuedBookButton";
            deleteIssuedBookButton.Size = new Size(79, 24);
            deleteIssuedBookButton.Text = "Удалить";
            deleteIssuedBookButton.Click += deleteIssuedBookButton_Click;
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
            searchIssueBooksTableLayout.Location = new Point(219, 3);
            searchIssueBooksTableLayout.Name = "searchIssueBooksTableLayout";
            searchIssueBooksTableLayout.RowCount = 1;
            searchIssueBooksTableLayout.RowStyles.Add(new RowStyle());
            searchIssueBooksTableLayout.Size = new Size(558, 56);
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
            searchIssueBooksInput.Size = new Size(472, 50);
            searchIssueBooksInput.TabIndex = 0;
            searchIssueBooksInput.Text = "";
            searchIssueBooksInput.TrailingIcon = null;
            searchIssueBooksInput.KeyDown += searchIssueBooksInput_KeyDown;
            // 
            // searchIssueBooksButton
            // 
            searchIssueBooksButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            searchIssueBooksButton.Density = MaterialButton.MaterialButtonDensity.Default;
            searchIssueBooksButton.Depth = 0;
            searchIssueBooksButton.Dock = DockStyle.Fill;
            searchIssueBooksButton.HighEmphasis = true;
            searchIssueBooksButton.Icon = null;
            searchIssueBooksButton.Location = new Point(482, 6);
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
            searchIssueBooksButton.Click += searchIssueBooksButton_Click;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(issuedBooksTab);
            tabControl.Controls.Add(booksListTab);
            tabControl.Controls.Add(readersListTab);
            tabControl.Controls.Add(readingRoomsListTab);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tabControl.Location = new Point(3, 64);
            tabControl.Multiline = true;
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(794, 383);
            tabControl.SizeMode = TabSizeMode.FillToRight;
            tabControl.TabIndex = 1;
            tabControl.KeyDown += tabControl_KeyDown;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl);
            MainMenuStrip = booksToolBar;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bookful";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            KeyDown += MainForm_KeyDown;
            readingRoomsListTab.ResumeLayout(false);
            readingRoomsListTab.PerformLayout();
            readingRoomsTableLayout.ResumeLayout(false);
            readingRoomsTableLayout.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)readingRoomsDataGrid).EndInit();
            readingRoomsToolBar.ResumeLayout(false);
            readingRoomsToolBar.PerformLayout();
            searchReadingRoomsLayout.ResumeLayout(false);
            searchReadingRoomsLayout.PerformLayout();
            readersListTab.ResumeLayout(false);
            readersListTab.PerformLayout();
            readersTableLayout.ResumeLayout(false);
            readersTableLayout.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)readersDataGrid).EndInit();
            readersToolBar.ResumeLayout(false);
            readersToolBar.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            booksListTab.ResumeLayout(false);
            booksListTab.PerformLayout();
            bookListLayout.ResumeLayout(false);
            bookListLayout.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)booksDataGrid).EndInit();
            booksToolBar.ResumeLayout(false);
            booksToolBar.PerformLayout();
            searchBooksLayout.ResumeLayout(false);
            searchBooksLayout.PerformLayout();
            issuedBooksTab.ResumeLayout(false);
            issuedBooksTab.PerformLayout();
            issuedBooksTableLayout.ResumeLayout(false);
            issuedBooksTableLayout.PerformLayout();
            quickActionsBox.ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel1;
        private MaterialButton searchReadersButton;
        private MaterialTextBox searchReadersInput;
        private TableLayoutPanel issuedBooksTableLayout;
        private DataGridView issuedBooksDataGrid;
        private MenuStrip issuedBooksToolBar;
        private ToolStripMenuItem refreshIssueBooksButton;
        private TableLayoutPanel searchIssueBooksTableLayout;
        private MaterialTextBox searchIssueBooksInput;
        private MaterialButton searchIssueBooksButton;
        private ToolStripMenuItem editIssuedBookButton;
        private MaterialToolStripMenuItem addIssueBookButton;
        private GroupBox quickActionsBox;
        private ListView listView1;
        private GroupBox groupBox1;
        private ListView listView2;
        private GroupBox groupBox3;
        private ListView listView4;
        private GroupBox groupBox2;
        private ListView listView3;
        private ToolStripMenuItem deleteIssuedBookButton;
        private ToolStripMenuItem editBookButton;
        private ToolStripMenuItem deleteBookButton;
        private ToolStripMenuItem editReaderButton;
        private ToolStripMenuItem deleteReaderButton;
        private ToolStripMenuItem editReadingRoomButton;
        private ToolStripMenuItem deleteReadingRoomButton;
    }
}