namespace WinFormsApp1
{
    partial class Dialog_Borrowlog1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_BookInfo = new System.Windows.Forms.GroupBox();
            this.dataGridView_BookInfo = new System.Windows.Forms.DataGridView();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CanBeBorrowed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox_accountInfo = new System.Windows.Forms.GroupBox();
            this.dataGridView_AccountInfo = new System.Windows.Forms.DataGridView();
            this._ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_SaveChange = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_BookAction = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_QueryByReader = new System.Windows.Forms.TextBox();
            this.textBox_QueryByBook = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView_ChangePreview = new System.Windows.Forms.ListView();
            this.columnHeader_Property = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_old = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_new = new System.Windows.Forms.ColumnHeader();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox_BookInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BookInfo)).BeginInit();
            this.groupBox_accountInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AccountInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox_BookInfo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox_accountInfo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox_BookInfo
            // 
            this.groupBox_BookInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_BookInfo.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_BookInfo.Controls.Add(this.dataGridView_BookInfo);
            this.groupBox_BookInfo.Location = new System.Drawing.Point(305, 5);
            this.groupBox_BookInfo.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox_BookInfo.Name = "groupBox_BookInfo";
            this.groupBox_BookInfo.Size = new System.Drawing.Size(490, 195);
            this.groupBox_BookInfo.TabIndex = 0;
            this.groupBox_BookInfo.TabStop = false;
            this.groupBox_BookInfo.Text = "书籍信息（双击选择需要的书籍）";
            // 
            // dataGridView_BookInfo
            // 
            this.dataGridView_BookInfo.AllowUserToAddRows = false;
            this.dataGridView_BookInfo.AllowUserToDeleteRows = false;
            this.dataGridView_BookInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_BookInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_BookInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BookInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookName,
            this.ISBN,
            this.BookID,
            this.CanBeBorrowed});
            this.dataGridView_BookInfo.Location = new System.Drawing.Point(7, 22);
            this.dataGridView_BookInfo.Name = "dataGridView_BookInfo";
            this.dataGridView_BookInfo.ReadOnly = true;
            this.dataGridView_BookInfo.RowHeadersVisible = false;
            this.dataGridView_BookInfo.RowTemplate.Height = 25;
            this.dataGridView_BookInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_BookInfo.Size = new System.Drawing.Size(476, 167);
            this.dataGridView_BookInfo.TabIndex = 0;
            this.dataGridView_BookInfo.DoubleClick += new System.EventHandler(this.dataGridView_BookInfo_DoubleClick);
            // 
            // BookName
            // 
            this.BookName.DataPropertyName = "Name";
            this.BookName.HeaderText = "书名";
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // BookID
            // 
            this.BookID.DataPropertyName = "BookID";
            this.BookID.HeaderText = "索书号";
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            // 
            // CanBeBorrowed
            // 
            this.CanBeBorrowed.DataPropertyName = "CanBeBorrowed";
            this.CanBeBorrowed.HeaderText = "是否在库";
            this.CanBeBorrowed.Name = "CanBeBorrowed";
            this.CanBeBorrowed.ReadOnly = true;
            this.CanBeBorrowed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CanBeBorrowed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox_accountInfo
            // 
            this.groupBox_accountInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_accountInfo.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_accountInfo.Controls.Add(this.dataGridView_AccountInfo);
            this.groupBox_accountInfo.Location = new System.Drawing.Point(305, 210);
            this.groupBox_accountInfo.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox_accountInfo.Name = "groupBox_accountInfo";
            this.groupBox_accountInfo.Size = new System.Drawing.Size(490, 195);
            this.groupBox_accountInfo.TabIndex = 1;
            this.groupBox_accountInfo.TabStop = false;
            this.groupBox_accountInfo.Text = "账户信息（双击选择需要的账户）";
            // 
            // dataGridView_AccountInfo
            // 
            this.dataGridView_AccountInfo.AllowUserToAddRows = false;
            this.dataGridView_AccountInfo.AllowUserToDeleteRows = false;
            this.dataGridView_AccountInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_AccountInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_AccountInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AccountInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._ID,
            this._Name});
            this.dataGridView_AccountInfo.Location = new System.Drawing.Point(7, 24);
            this.dataGridView_AccountInfo.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView_AccountInfo.Name = "dataGridView_AccountInfo";
            this.dataGridView_AccountInfo.ReadOnly = true;
            this.dataGridView_AccountInfo.RowHeadersVisible = false;
            this.dataGridView_AccountInfo.RowTemplate.Height = 25;
            this.dataGridView_AccountInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_AccountInfo.Size = new System.Drawing.Size(476, 164);
            this.dataGridView_AccountInfo.TabIndex = 1;
            this.dataGridView_AccountInfo.DoubleClick += new System.EventHandler(this.dataGridView_AccountInfo_DoubleClick);
            // 
            // _ID
            // 
            this._ID.DataPropertyName = "ID";
            this._ID.HeaderText = "学号";
            this._ID.Name = "_ID";
            this._ID.ReadOnly = true;
            // 
            // _Name
            // 
            this._Name.DataPropertyName = "Name";
            this._Name.HeaderText = "姓名";
            this._Name.Name = "_Name";
            this._Name.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.button_Cancel);
            this.panel1.Controls.Add(this.button_SaveChange);
            this.panel1.Location = new System.Drawing.Point(0, 410);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 3;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Cancel.Location = new System.Drawing.Point(641, 4);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 33);
            this.button_Cancel.TabIndex = 1;
            this.button_Cancel.Text = "取消";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_SaveChange
            // 
            this.button_SaveChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_SaveChange.Location = new System.Drawing.Point(722, 4);
            this.button_SaveChange.Name = "button_SaveChange";
            this.button_SaveChange.Size = new System.Drawing.Size(75, 33);
            this.button_SaveChange.TabIndex = 0;
            this.button_SaveChange.Text = "确定";
            this.button_SaveChange.UseVisualStyleBackColor = true;
            this.button_SaveChange.Click += new System.EventHandler(this.button_SaveChange_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox_BookAction);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_QueryByReader);
            this.groupBox1.Controls.Add(this.textBox_QueryByBook);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(290, 400);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑（日期条目中时间可以修改）";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 34);
            this.label5.TabIndex = 11;
            this.label5.Text = "书籍信息对应ISBN、书名、作者、索书号模糊查询\r\n借阅人信息对应学号和姓名的模糊查询";
            // 
            // comboBox_BookAction
            // 
            this.comboBox_BookAction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_BookAction.Enabled = false;
            this.comboBox_BookAction.FormattingEnabled = true;
            this.comboBox_BookAction.Items.AddRange(new object[] {
            "借出",
            "返还"});
            this.comboBox_BookAction.Location = new System.Drawing.Point(80, 114);
            this.comboBox_BookAction.Name = "comboBox_BookAction";
            this.comboBox_BookAction.Size = new System.Drawing.Size(204, 25);
            this.comboBox_BookAction.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "行为";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(81, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(204, 23);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "日期";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "借阅人信息";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "书籍信息";
            // 
            // textBox_QueryByReader
            // 
            this.textBox_QueryByReader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_QueryByReader.Location = new System.Drawing.Point(80, 58);
            this.textBox_QueryByReader.Name = "textBox_QueryByReader";
            this.textBox_QueryByReader.Size = new System.Drawing.Size(204, 23);
            this.textBox_QueryByReader.TabIndex = 1;
            this.textBox_QueryByReader.TextChanged += new System.EventHandler(this.textBox_QueryByReader_TextChanged);
            // 
            // textBox_QueryByBook
            // 
            this.textBox_QueryByBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_QueryByBook.Location = new System.Drawing.Point(80, 29);
            this.textBox_QueryByBook.Name = "textBox_QueryByBook";
            this.textBox_QueryByBook.Size = new System.Drawing.Size(204, 23);
            this.textBox_QueryByBook.TabIndex = 0;
            this.textBox_QueryByBook.TextChanged += new System.EventHandler(this.textBox_QueryByBook_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.listView_ChangePreview);
            this.groupBox2.Location = new System.Drawing.Point(7, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(277, 207);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "预览修改（单击表格内任意位置预览）";
            // 
            // listView_ChangePreview
            // 
            this.listView_ChangePreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_ChangePreview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Property,
            this.columnHeader_old,
            this.columnHeader_new});
            this.listView_ChangePreview.Location = new System.Drawing.Point(10, 24);
            this.listView_ChangePreview.Margin = new System.Windows.Forms.Padding(5);
            this.listView_ChangePreview.Name = "listView_ChangePreview";
            this.listView_ChangePreview.Size = new System.Drawing.Size(257, 173);
            this.listView_ChangePreview.TabIndex = 7;
            this.listView_ChangePreview.UseCompatibleStateImageBehavior = false;
            this.listView_ChangePreview.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_Property
            // 
            this.columnHeader_Property.Text = "属性";
            this.columnHeader_Property.Width = 25;
            // 
            // columnHeader_old
            // 
            this.columnHeader_old.Text = "旧值";
            this.columnHeader_old.Width = 25;
            // 
            // columnHeader_new
            // 
            this.columnHeader_new.Text = "新值";
            this.columnHeader_new.Width = 25;
            // 
            // Dialog_Borrowlog1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormsApp1.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Dialog_Borrowlog1";
            this.Load += new System.EventHandler(this.Dialog_Borrowlog_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox_BookInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BookInfo)).EndInit();
            this.groupBox_accountInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AccountInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox_BookInfo;
        private GroupBox groupBox1;
        private TextBox textBox_QueryByReader;
        private TextBox textBox_QueryByBook;
        private GroupBox groupBox_accountInfo;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView_BookInfo;
        private GroupBox groupBox2;
        private ListView listView_ChangePreview;
        private ColumnHeader columnHeader_Property;
        private ColumnHeader columnHeader_old;
        private ColumnHeader columnHeader_new;
        private DataGridView dataGridView_AccountInfo;
        private Panel panel1;
        private Button button_Cancel;
        private Button button_SaveChange;
        private DataGridViewTextBoxColumn BookName;
        private DataGridViewTextBoxColumn ISBN;
        private DataGridViewTextBoxColumn BookID;
        private DataGridViewCheckBoxColumn CanBeBorrowed;
        private Label label4;
        private ComboBox comboBox_BookAction;
        private DataGridViewTextBoxColumn _ID;
        private DataGridViewTextBoxColumn _Name;
        private Label label5;
    }
}