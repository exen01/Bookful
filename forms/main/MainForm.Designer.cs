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
            ListViewGroup listViewGroup4 = new ListViewGroup("Добавить новую запись", HorizontalAlignment.Left);
            ListViewGroup listViewGroup5 = new ListViewGroup("Редактировать запись", HorizontalAlignment.Left);
            ListViewGroup listViewGroup6 = new ListViewGroup("Удалить запись", HorizontalAlignment.Left);
            ListViewItem listViewItem1 = new ListViewItem("F5");
            ListViewItem listViewItem2 = new ListViewItem("Ctrl + цифра");
            ListViewItem listViewItem3 = new ListViewItem("Enter");
            ListViewItem listViewItem4 = new ListViewItem("Delete");
            ListViewItem listViewItem5 = new ListViewItem("Insert");
            ListViewItem listViewItem6 = new ListViewItem("Ctrl + E");
            ListViewGroup listViewGroup7 = new ListViewGroup("Обновить список", HorizontalAlignment.Center);
            ListViewGroup listViewGroup8 = new ListViewGroup("Переключение вкладок", HorizontalAlignment.Center);
            ListViewGroup listViewGroup9 = new ListViewGroup("Поиск", HorizontalAlignment.Center);
            ListViewGroup listViewGroup10 = new ListViewGroup("Добавить новую запись", HorizontalAlignment.Left);
            ListViewGroup listViewGroup11 = new ListViewGroup("Редактировать запись", HorizontalAlignment.Left);
            ListViewGroup listViewGroup12 = new ListViewGroup("Удалить запись", HorizontalAlignment.Left);
            ListViewItem listViewItem7 = new ListViewItem("F5");
            ListViewItem listViewItem8 = new ListViewItem("Ctrl + цифра");
            ListViewItem listViewItem9 = new ListViewItem("Enter");
            ListViewItem listViewItem10 = new ListViewItem("Delete");
            ListViewItem listViewItem11 = new ListViewItem("Insert");
            ListViewItem listViewItem12 = new ListViewItem("Ctrl + E");
            ListViewGroup listViewGroup13 = new ListViewGroup("Обновить список", HorizontalAlignment.Center);
            ListViewGroup listViewGroup14 = new ListViewGroup("Переключение вкладок", HorizontalAlignment.Center);
            ListViewGroup listViewGroup15 = new ListViewGroup("Поиск", HorizontalAlignment.Center);
            ListViewGroup listViewGroup16 = new ListViewGroup("Добавить новую запись", HorizontalAlignment.Left);
            ListViewGroup listViewGroup17 = new ListViewGroup("Редактировать запись", HorizontalAlignment.Left);
            ListViewGroup listViewGroup18 = new ListViewGroup("Удалить запись", HorizontalAlignment.Left);
            ListViewItem listViewItem13 = new ListViewItem("F5");
            ListViewItem listViewItem14 = new ListViewItem("Ctrl + цифра");
            ListViewItem listViewItem15 = new ListViewItem("Enter");
            ListViewItem listViewItem16 = new ListViewItem("Delete");
            ListViewItem listViewItem17 = new ListViewItem("Insert");
            ListViewItem listViewItem18 = new ListViewItem("Ctrl + E");
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            readingRoomsListTab = new TabPage();
            readingRoomsTableLayout = new TableLayoutPanel();
            groupBox3 = new GroupBox();
            listView3 = new ListView();
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
            listView1 = new ListView();
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
            issuedBooksDataGrid = new DataGridView();
            issuedBooksToolBar = new MenuStrip();
            addIssueBookButton = new MaterialToolStripMenuItem();
            refreshIssueBooksButton = new ToolStripMenuItem();
            editIssuedBookButton = new ToolStripMenuItem();
            deleteIssuedBookButton = new ToolStripMenuItem();
            searchIssueBooksTableLayout = new TableLayoutPanel();
            searchIssueBooksInput = new MaterialTextBox();
            searchIssueBooksButton = new MaterialButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            issuedBookReadersFilterSearch = new MaterialTextBox();
            issuedBookReaderFilterBox = new CheckedListBox();
            issuedBookSelectAllReadersFilter = new MaterialCheckbox();
            issuedBookFilterApplyButton = new MaterialButton();
            issuedBookBooksFilterSearch = new MaterialTextBox();
            issuedBookSelectAllBooksFilter = new MaterialCheckbox();
            issuedBookBookFilterBox = new CheckedListBox();
            issuedBookUnreturnedBookFilter = new MaterialSwitch();
            materialButton1 = new MaterialButton();
            tabControl = new TabControl();
            materialCheckbox1 = new MaterialCheckbox();
            materialCheckbox2 = new MaterialCheckbox();
            materialCheckbox3 = new MaterialCheckbox();
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
            ((System.ComponentModel.ISupportInitialize)issuedBooksDataGrid).BeginInit();
            issuedBooksToolBar.SuspendLayout();
            searchIssueBooksTableLayout.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tabControl.SuspendLayout();
            SuspendLayout();
            // 
            // readingRoomsListTab
            // 
            readingRoomsListTab.Controls.Add(readingRoomsTableLayout);
            readingRoomsListTab.Location = new Point(4, 28);
            readingRoomsListTab.Name = "readingRoomsListTab";
            readingRoomsListTab.Size = new Size(1236, 820);
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
            readingRoomsTableLayout.Size = new Size(1236, 820);
            readingRoomsTableLayout.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(listView3);
            groupBox3.Dock = DockStyle.Left;
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            readingRoomsTableLayout.SetRowSpan(groupBox3, 3);
            groupBox3.Size = new Size(210, 814);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Быстрые действия";
            // 
            // listView3
            // 
            listView3.Alignment = ListViewAlignment.Left;
            listView3.BorderStyle = BorderStyle.None;
            listView3.Dock = DockStyle.Fill;
            listView3.Enabled = false;
            listView3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
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
            listViewGroup4.Header = "Добавить новую запись";
            listViewGroup4.Name = "listViewGroup4";
            listViewGroup5.Header = "Редактировать запись";
            listViewGroup5.Name = "listViewGroup5";
            listViewGroup6.Header = "Удалить запись";
            listViewGroup6.Name = "listViewGroup6";
            listView3.Groups.AddRange(new ListViewGroup[] { listViewGroup1, listViewGroup2, listViewGroup3, listViewGroup4, listViewGroup5, listViewGroup6 });
            listViewItem1.Group = listViewGroup1;
            listViewItem1.UseItemStyleForSubItems = false;
            listViewItem2.Group = listViewGroup2;
            listViewItem3.Group = listViewGroup3;
            listViewItem4.Group = listViewGroup6;
            listViewItem5.Group = listViewGroup4;
            listViewItem6.Group = listViewGroup5;
            listView3.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5, listViewItem6 });
            listView3.Location = new Point(3, 23);
            listView3.Name = "listView3";
            listView3.Size = new Size(204, 788);
            listView3.TabIndex = 1;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.SmallIcon;
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
            readingRoomsDataGrid.Size = new Size(1014, 724);
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
            readingRoomsToolBar.Size = new Size(1020, 28);
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
            searchReadingRoomsLayout.Size = new Size(1014, 56);
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
            searchReadingRoomsButton.Location = new Point(938, 6);
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
            searchReadingRoomsInput.Hint = "Поиск по имени, дате и т.д.";
            searchReadingRoomsInput.LeadingIcon = null;
            searchReadingRoomsInput.Location = new Point(3, 3);
            searchReadingRoomsInput.MaxLength = 50;
            searchReadingRoomsInput.MouseState = MaterialSkin.MouseState.OUT;
            searchReadingRoomsInput.Multiline = false;
            searchReadingRoomsInput.Name = "searchReadingRoomsInput";
            searchReadingRoomsInput.Size = new Size(928, 50);
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
            readersListTab.Size = new Size(1236, 820);
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
            readersTableLayout.Size = new Size(1230, 814);
            readersTableLayout.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView1);
            groupBox2.Dock = DockStyle.Left;
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            readersTableLayout.SetRowSpan(groupBox2, 3);
            groupBox2.Size = new Size(210, 808);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Быстрые действия";
            // 
            // listView1
            // 
            listView1.Alignment = ListViewAlignment.Left;
            listView1.BorderStyle = BorderStyle.None;
            listView1.Dock = DockStyle.Fill;
            listView1.Enabled = false;
            listView1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
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
            listViewGroup10.Header = "Добавить новую запись";
            listViewGroup10.Name = "listViewGroup4";
            listViewGroup11.Header = "Редактировать запись";
            listViewGroup11.Name = "listViewGroup5";
            listViewGroup12.Header = "Удалить запись";
            listViewGroup12.Name = "listViewGroup6";
            listView1.Groups.AddRange(new ListViewGroup[] { listViewGroup7, listViewGroup8, listViewGroup9, listViewGroup10, listViewGroup11, listViewGroup12 });
            listViewItem7.Group = listViewGroup7;
            listViewItem7.UseItemStyleForSubItems = false;
            listViewItem8.Group = listViewGroup8;
            listViewItem9.Group = listViewGroup9;
            listViewItem10.Group = listViewGroup12;
            listViewItem11.Group = listViewGroup10;
            listViewItem12.Group = listViewGroup11;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem7, listViewItem8, listViewItem9, listViewItem10, listViewItem11, listViewItem12 });
            listView1.Location = new Point(3, 23);
            listView1.Name = "listView1";
            listView1.Size = new Size(204, 782);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.SmallIcon;
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
            readersDataGrid.Size = new Size(1008, 718);
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
            readersToolBar.Size = new Size(1014, 28);
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
            tableLayoutPanel1.Size = new Size(1008, 56);
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
            searchReadersButton.Location = new Point(932, 6);
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
            searchReadersInput.Hint = "Поиск по имени, дате и т.д.";
            searchReadersInput.LeadingIcon = null;
            searchReadersInput.Location = new Point(3, 3);
            searchReadersInput.MaxLength = 50;
            searchReadersInput.MouseState = MaterialSkin.MouseState.OUT;
            searchReadersInput.Multiline = false;
            searchReadersInput.Name = "searchReadersInput";
            searchReadersInput.Size = new Size(922, 50);
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
            booksListTab.Size = new Size(1236, 820);
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
            bookListLayout.Size = new Size(1230, 814);
            bookListLayout.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView2);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            bookListLayout.SetRowSpan(groupBox1, 3);
            groupBox1.Size = new Size(210, 808);
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
            listViewGroup13.Header = "Обновить список";
            listViewGroup13.HeaderAlignment = HorizontalAlignment.Center;
            listViewGroup13.Name = "listViewGroup1";
            listViewGroup13.Tag = "";
            listViewGroup14.Header = "Переключение вкладок";
            listViewGroup14.HeaderAlignment = HorizontalAlignment.Center;
            listViewGroup14.Name = "listViewGroup2";
            listViewGroup15.Header = "Поиск";
            listViewGroup15.HeaderAlignment = HorizontalAlignment.Center;
            listViewGroup15.Name = "listViewGroup3";
            listViewGroup16.Header = "Добавить новую запись";
            listViewGroup16.Name = "listViewGroup4";
            listViewGroup17.Header = "Редактировать запись";
            listViewGroup17.Name = "listViewGroup5";
            listViewGroup18.Header = "Удалить запись";
            listViewGroup18.Name = "listViewGroup6";
            listView2.Groups.AddRange(new ListViewGroup[] { listViewGroup13, listViewGroup14, listViewGroup15, listViewGroup16, listViewGroup17, listViewGroup18 });
            listViewItem13.Group = listViewGroup13;
            listViewItem13.UseItemStyleForSubItems = false;
            listViewItem14.Group = listViewGroup14;
            listViewItem15.Group = listViewGroup15;
            listViewItem16.Group = listViewGroup18;
            listViewItem17.Group = listViewGroup16;
            listViewItem18.Group = listViewGroup17;
            listView2.Items.AddRange(new ListViewItem[] { listViewItem13, listViewItem14, listViewItem15, listViewItem16, listViewItem17, listViewItem18 });
            listView2.Location = new Point(3, 23);
            listView2.Name = "listView2";
            listView2.Size = new Size(204, 782);
            listView2.TabIndex = 0;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.SmallIcon;
            // 
            // booksDataGrid
            // 
            booksDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            booksDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            booksDataGrid.Dock = DockStyle.Fill;
            booksDataGrid.Location = new Point(219, 93);
            booksDataGrid.Name = "booksDataGrid";
            booksDataGrid.ReadOnly = true;
            booksDataGrid.RowHeadersWidth = 51;
            booksDataGrid.RowTemplate.Height = 29;
            booksDataGrid.Size = new Size(1008, 718);
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
            booksToolBar.Size = new Size(1014, 28);
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
            searchBooksLayout.Size = new Size(1008, 56);
            searchBooksLayout.TabIndex = 2;
            // 
            // searchBooksInput
            // 
            searchBooksInput.AnimateReadOnly = false;
            searchBooksInput.BorderStyle = BorderStyle.None;
            searchBooksInput.Depth = 0;
            searchBooksInput.Dock = DockStyle.Fill;
            searchBooksInput.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            searchBooksInput.Hint = "Поиск по имени, дате и т.д.";
            searchBooksInput.LeadingIcon = null;
            searchBooksInput.Location = new Point(3, 3);
            searchBooksInput.MaxLength = 50;
            searchBooksInput.MouseState = MaterialSkin.MouseState.OUT;
            searchBooksInput.Multiline = false;
            searchBooksInput.Name = "searchBooksInput";
            searchBooksInput.Size = new Size(922, 50);
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
            searchBooksButton.Location = new Point(932, 6);
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
            issuedBooksTab.Size = new Size(1236, 820);
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
            issuedBooksTableLayout.Controls.Add(issuedBooksDataGrid, 1, 2);
            issuedBooksTableLayout.Controls.Add(issuedBooksToolBar, 1, 1);
            issuedBooksTableLayout.Controls.Add(searchIssueBooksTableLayout, 1, 0);
            issuedBooksTableLayout.Controls.Add(tableLayoutPanel2, 0, 0);
            issuedBooksTableLayout.Dock = DockStyle.Fill;
            issuedBooksTableLayout.Location = new Point(3, 3);
            issuedBooksTableLayout.Name = "issuedBooksTableLayout";
            issuedBooksTableLayout.RowCount = 3;
            issuedBooksTableLayout.RowStyles.Add(new RowStyle());
            issuedBooksTableLayout.RowStyles.Add(new RowStyle());
            issuedBooksTableLayout.RowStyles.Add(new RowStyle());
            issuedBooksTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            issuedBooksTableLayout.Size = new Size(1230, 814);
            issuedBooksTableLayout.TabIndex = 0;
            // 
            // issuedBooksDataGrid
            // 
            issuedBooksDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            issuedBooksDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            issuedBooksDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            issuedBooksDataGrid.Dock = DockStyle.Fill;
            issuedBooksDataGrid.Location = new Point(259, 93);
            issuedBooksDataGrid.Name = "issuedBooksDataGrid";
            issuedBooksDataGrid.ReadOnly = true;
            issuedBooksDataGrid.RowHeadersWidth = 51;
            issuedBooksDataGrid.RowTemplate.Height = 29;
            issuedBooksDataGrid.Size = new Size(968, 718);
            issuedBooksDataGrid.TabIndex = 0;
            issuedBooksDataGrid.CellFormatting += issuedBooksDataGrid_CellFormatting;
            issuedBooksDataGrid.DataBindingComplete += issuedBooksDataGrid_DataBindingComplete;
            // 
            // issuedBooksToolBar
            // 
            issuedBooksToolBar.ImageScalingSize = new Size(20, 20);
            issuedBooksToolBar.Items.AddRange(new ToolStripItem[] { addIssueBookButton, refreshIssueBooksButton, editIssuedBookButton, deleteIssuedBookButton });
            issuedBooksToolBar.Location = new Point(256, 62);
            issuedBooksToolBar.Name = "issuedBooksToolBar";
            issuedBooksToolBar.Size = new Size(974, 28);
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
            searchIssueBooksTableLayout.Location = new Point(259, 3);
            searchIssueBooksTableLayout.Name = "searchIssueBooksTableLayout";
            searchIssueBooksTableLayout.RowCount = 1;
            searchIssueBooksTableLayout.RowStyles.Add(new RowStyle());
            searchIssueBooksTableLayout.Size = new Size(968, 56);
            searchIssueBooksTableLayout.TabIndex = 2;
            // 
            // searchIssueBooksInput
            // 
            searchIssueBooksInput.AnimateReadOnly = false;
            searchIssueBooksInput.BorderStyle = BorderStyle.None;
            searchIssueBooksInput.Depth = 0;
            searchIssueBooksInput.Dock = DockStyle.Fill;
            searchIssueBooksInput.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            searchIssueBooksInput.Hint = "Поиск по имени, дате и т.д.";
            searchIssueBooksInput.LeadingIcon = null;
            searchIssueBooksInput.Location = new Point(3, 3);
            searchIssueBooksInput.MaxLength = 50;
            searchIssueBooksInput.MouseState = MaterialSkin.MouseState.OUT;
            searchIssueBooksInput.Multiline = false;
            searchIssueBooksInput.Name = "searchIssueBooksInput";
            searchIssueBooksInput.Size = new Size(882, 50);
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
            searchIssueBooksButton.Location = new Point(892, 6);
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(issuedBookReadersFilterSearch, 0, 0);
            tableLayoutPanel2.Controls.Add(issuedBookReaderFilterBox, 0, 2);
            tableLayoutPanel2.Controls.Add(issuedBookSelectAllReadersFilter, 0, 1);
            tableLayoutPanel2.Controls.Add(issuedBookFilterApplyButton, 0, 10);
            tableLayoutPanel2.Controls.Add(issuedBookBooksFilterSearch, 0, 4);
            tableLayoutPanel2.Controls.Add(issuedBookSelectAllBooksFilter, 0, 5);
            tableLayoutPanel2.Controls.Add(issuedBookBookFilterBox, 0, 6);
            tableLayoutPanel2.Controls.Add(issuedBookUnreturnedBookFilter, 0, 8);
            tableLayoutPanel2.Controls.Add(materialButton1, 0, 11);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 14;
            issuedBooksTableLayout.SetRowSpan(tableLayoutPanel2, 3);
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(250, 808);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // issuedBookReadersFilterSearch
            // 
            issuedBookReadersFilterSearch.AnimateReadOnly = false;
            issuedBookReadersFilterSearch.BorderStyle = BorderStyle.None;
            issuedBookReadersFilterSearch.Depth = 0;
            issuedBookReadersFilterSearch.Dock = DockStyle.Top;
            issuedBookReadersFilterSearch.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            issuedBookReadersFilterSearch.Hint = "Читатель";
            issuedBookReadersFilterSearch.LeadingIcon = null;
            issuedBookReadersFilterSearch.Location = new Point(3, 3);
            issuedBookReadersFilterSearch.MaxLength = 50;
            issuedBookReadersFilterSearch.MouseState = MaterialSkin.MouseState.OUT;
            issuedBookReadersFilterSearch.Multiline = false;
            issuedBookReadersFilterSearch.Name = "issuedBookReadersFilterSearch";
            issuedBookReadersFilterSearch.Size = new Size(244, 50);
            issuedBookReadersFilterSearch.TabIndex = 2;
            issuedBookReadersFilterSearch.Text = "";
            issuedBookReadersFilterSearch.TrailingIcon = null;
            issuedBookReadersFilterSearch.TextChanged += issuedBookReadersFilterSearch_TextChanged;
            // 
            // issuedBookReaderFilterBox
            // 
            issuedBookReaderFilterBox.BorderStyle = BorderStyle.None;
            issuedBookReaderFilterBox.Dock = DockStyle.Fill;
            issuedBookReaderFilterBox.FormattingEnabled = true;
            issuedBookReaderFilterBox.Location = new Point(3, 96);
            issuedBookReaderFilterBox.Name = "issuedBookReaderFilterBox";
            issuedBookReaderFilterBox.Size = new Size(244, 150);
            issuedBookReaderFilterBox.TabIndex = 0;
            // 
            // issuedBookSelectAllReadersFilter
            // 
            issuedBookSelectAllReadersFilter.AutoSize = true;
            issuedBookSelectAllReadersFilter.Depth = 0;
            issuedBookSelectAllReadersFilter.Dock = DockStyle.Fill;
            issuedBookSelectAllReadersFilter.Location = new Point(0, 56);
            issuedBookSelectAllReadersFilter.Margin = new Padding(0);
            issuedBookSelectAllReadersFilter.MouseLocation = new Point(-1, -1);
            issuedBookSelectAllReadersFilter.MouseState = MaterialSkin.MouseState.HOVER;
            issuedBookSelectAllReadersFilter.Name = "issuedBookSelectAllReadersFilter";
            issuedBookSelectAllReadersFilter.ReadOnly = false;
            issuedBookSelectAllReadersFilter.Ripple = true;
            issuedBookSelectAllReadersFilter.Size = new Size(250, 37);
            issuedBookSelectAllReadersFilter.TabIndex = 3;
            issuedBookSelectAllReadersFilter.Text = "Выбрать все";
            issuedBookSelectAllReadersFilter.UseVisualStyleBackColor = true;
            issuedBookSelectAllReadersFilter.CheckedChanged += issuedBookSelectAllReadersFilter_CheckedChanged;
            // 
            // issuedBookFilterApplyButton
            // 
            issuedBookFilterApplyButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            issuedBookFilterApplyButton.Density = MaterialButton.MaterialButtonDensity.Default;
            issuedBookFilterApplyButton.Depth = 0;
            issuedBookFilterApplyButton.Dock = DockStyle.Fill;
            issuedBookFilterApplyButton.HighEmphasis = true;
            issuedBookFilterApplyButton.Icon = null;
            issuedBookFilterApplyButton.Location = new Point(4, 586);
            issuedBookFilterApplyButton.Margin = new Padding(4, 6, 4, 6);
            issuedBookFilterApplyButton.MouseState = MaterialSkin.MouseState.HOVER;
            issuedBookFilterApplyButton.Name = "issuedBookFilterApplyButton";
            issuedBookFilterApplyButton.NoAccentTextColor = Color.Empty;
            issuedBookFilterApplyButton.Size = new Size(242, 36);
            issuedBookFilterApplyButton.TabIndex = 5;
            issuedBookFilterApplyButton.Text = "Применить фильтр";
            issuedBookFilterApplyButton.Type = MaterialButton.MaterialButtonType.Contained;
            issuedBookFilterApplyButton.UseAccentColor = false;
            issuedBookFilterApplyButton.UseVisualStyleBackColor = true;
            issuedBookFilterApplyButton.Click += issuedBookFilterApplyButton_Click;
            // 
            // issuedBookBooksFilterSearch
            // 
            issuedBookBooksFilterSearch.AnimateReadOnly = false;
            issuedBookBooksFilterSearch.BorderStyle = BorderStyle.None;
            issuedBookBooksFilterSearch.Depth = 0;
            issuedBookBooksFilterSearch.Dock = DockStyle.Fill;
            issuedBookBooksFilterSearch.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            issuedBookBooksFilterSearch.Hint = "Книга";
            issuedBookBooksFilterSearch.LeadingIcon = null;
            issuedBookBooksFilterSearch.Location = new Point(3, 277);
            issuedBookBooksFilterSearch.MaxLength = 50;
            issuedBookBooksFilterSearch.MouseState = MaterialSkin.MouseState.OUT;
            issuedBookBooksFilterSearch.Multiline = false;
            issuedBookBooksFilterSearch.Name = "issuedBookBooksFilterSearch";
            issuedBookBooksFilterSearch.Size = new Size(244, 50);
            issuedBookBooksFilterSearch.TabIndex = 6;
            issuedBookBooksFilterSearch.Text = "";
            issuedBookBooksFilterSearch.TrailingIcon = null;
            issuedBookBooksFilterSearch.TextChanged += issuedBookBooksFilterSearch_TextChanged;
            // 
            // issuedBookSelectAllBooksFilter
            // 
            issuedBookSelectAllBooksFilter.AutoSize = true;
            issuedBookSelectAllBooksFilter.Depth = 0;
            issuedBookSelectAllBooksFilter.Dock = DockStyle.Fill;
            issuedBookSelectAllBooksFilter.Location = new Point(0, 330);
            issuedBookSelectAllBooksFilter.Margin = new Padding(0);
            issuedBookSelectAllBooksFilter.MouseLocation = new Point(-1, -1);
            issuedBookSelectAllBooksFilter.MouseState = MaterialSkin.MouseState.HOVER;
            issuedBookSelectAllBooksFilter.Name = "issuedBookSelectAllBooksFilter";
            issuedBookSelectAllBooksFilter.ReadOnly = false;
            issuedBookSelectAllBooksFilter.Ripple = true;
            issuedBookSelectAllBooksFilter.Size = new Size(250, 37);
            issuedBookSelectAllBooksFilter.TabIndex = 7;
            issuedBookSelectAllBooksFilter.Text = "Выбрать все";
            issuedBookSelectAllBooksFilter.UseVisualStyleBackColor = true;
            issuedBookSelectAllBooksFilter.CheckedChanged += issuedBookSelectAllBooksFilter_CheckedChanged;
            // 
            // issuedBookBookFilterBox
            // 
            issuedBookBookFilterBox.BorderStyle = BorderStyle.None;
            issuedBookBookFilterBox.Dock = DockStyle.Fill;
            issuedBookBookFilterBox.FormattingEnabled = true;
            issuedBookBookFilterBox.Location = new Point(3, 370);
            issuedBookBookFilterBox.Name = "issuedBookBookFilterBox";
            issuedBookBookFilterBox.Size = new Size(244, 120);
            issuedBookBookFilterBox.TabIndex = 8;
            // 
            // issuedBookUnreturnedBookFilter
            // 
            issuedBookUnreturnedBookFilter.AutoSize = true;
            issuedBookUnreturnedBookFilter.Depth = 0;
            issuedBookUnreturnedBookFilter.Dock = DockStyle.Fill;
            issuedBookUnreturnedBookFilter.Location = new Point(0, 518);
            issuedBookUnreturnedBookFilter.Margin = new Padding(0);
            issuedBookUnreturnedBookFilter.MouseLocation = new Point(-1, -1);
            issuedBookUnreturnedBookFilter.MouseState = MaterialSkin.MouseState.HOVER;
            issuedBookUnreturnedBookFilter.Name = "issuedBookUnreturnedBookFilter";
            issuedBookUnreturnedBookFilter.Ripple = true;
            issuedBookUnreturnedBookFilter.Size = new Size(250, 37);
            issuedBookUnreturnedBookFilter.TabIndex = 9;
            issuedBookUnreturnedBookFilter.Text = "Книга не возвращена";
            issuedBookUnreturnedBookFilter.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.Dock = DockStyle.Fill;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(4, 634);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(242, 36);
            materialButton1.TabIndex = 10;
            materialButton1.Text = "Сбросить фильтр";
            materialButton1.Type = MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
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
            tabControl.Size = new Size(1244, 852);
            tabControl.SizeMode = TabSizeMode.FillToRight;
            tabControl.TabIndex = 1;
            tabControl.KeyDown += tabControl_KeyDown;
            // 
            // materialCheckbox1
            // 
            materialCheckbox1.AutoSize = true;
            materialCheckbox1.Depth = 0;
            materialCheckbox1.Location = new Point(0, 0);
            materialCheckbox1.Margin = new Padding(0);
            materialCheckbox1.MouseLocation = new Point(-1, -1);
            materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCheckbox1.Name = "materialCheckbox1";
            materialCheckbox1.ReadOnly = false;
            materialCheckbox1.Ripple = true;
            materialCheckbox1.Size = new Size(10, 10);
            materialCheckbox1.TabIndex = 0;
            materialCheckbox1.Text = "materialCheckbox1";
            materialCheckbox1.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox2
            // 
            materialCheckbox2.AutoSize = true;
            materialCheckbox2.Depth = 0;
            materialCheckbox2.Location = new Point(0, 0);
            materialCheckbox2.Margin = new Padding(0);
            materialCheckbox2.MouseLocation = new Point(-1, -1);
            materialCheckbox2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCheckbox2.Name = "materialCheckbox2";
            materialCheckbox2.ReadOnly = false;
            materialCheckbox2.Ripple = true;
            materialCheckbox2.Size = new Size(10, 10);
            materialCheckbox2.TabIndex = 0;
            materialCheckbox2.Text = "materialCheckbox2";
            materialCheckbox2.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox3
            // 
            materialCheckbox3.AutoSize = true;
            materialCheckbox3.Depth = 0;
            materialCheckbox3.Location = new Point(0, 0);
            materialCheckbox3.Margin = new Padding(0);
            materialCheckbox3.MouseLocation = new Point(-1, -1);
            materialCheckbox3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCheckbox3.Name = "materialCheckbox3";
            materialCheckbox3.ReadOnly = false;
            materialCheckbox3.Ripple = true;
            materialCheckbox3.Size = new Size(10, 10);
            materialCheckbox3.TabIndex = 0;
            materialCheckbox3.Text = "materialCheckbox3";
            materialCheckbox3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 919);
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
            ((System.ComponentModel.ISupportInitialize)issuedBooksDataGrid).EndInit();
            issuedBooksToolBar.ResumeLayout(false);
            issuedBooksToolBar.PerformLayout();
            searchIssueBooksTableLayout.ResumeLayout(false);
            searchIssueBooksTableLayout.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
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
        private GroupBox groupBox1;
        private ListView listView2;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private ToolStripMenuItem editBookButton;
        private ToolStripMenuItem deleteBookButton;
        private ToolStripMenuItem editReaderButton;
        private ToolStripMenuItem deleteReaderButton;
        private ToolStripMenuItem editReadingRoomButton;
        private ToolStripMenuItem deleteReadingRoomButton;
        private MaterialCheckbox materialCheckbox1;
        private MaterialCheckbox materialCheckbox2;
        private MaterialCheckbox materialCheckbox3;
        private TableLayoutPanel issuedBooksTableLayout;
        private DataGridView issuedBooksDataGrid;
        private MenuStrip issuedBooksToolBar;
        private MaterialToolStripMenuItem addIssueBookButton;
        private ToolStripMenuItem refreshIssueBooksButton;
        private ToolStripMenuItem editIssuedBookButton;
        private ToolStripMenuItem deleteIssuedBookButton;
        private TableLayoutPanel searchIssueBooksTableLayout;
        private MaterialTextBox searchIssueBooksInput;
        private MaterialButton searchIssueBooksButton;
        private TableLayoutPanel tableLayoutPanel2;
        private MaterialButton issuedBookFilterApplyButton;
        private MaterialTextBox issuedBookReadersFilterSearch;
        private CheckedListBox issuedBookReaderFilterBox;
        private MaterialCheckbox issuedBookSelectAllReadersFilter;
        private MaterialTextBox issuedBookBooksFilterSearch;
        private MaterialCheckbox issuedBookSelectAllBooksFilter;
        private CheckedListBox issuedBookBookFilterBox;
        private MaterialSwitch issuedBookUnreturnedBookFilter;
        private MaterialButton materialButton1;
        private ListView listView3;
        private ListView listView1;
    }
}