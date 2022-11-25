namespace WinFormsApp1
{
    partial class winform_BookManage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winform_BookManage));
            this.button_add = new System.Windows.Forms.Button();
            this.button_dele = new System.Windows.Forms.Button();
            this.button_revise = new System.Windows.Forms.Button();
            this.label_search = new System.Windows.Forms.Label();
            this.label_search_isbn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Textbox_Bookname = new System.Windows.Forms.TextBox();
            this.Textbox_ISBN = new System.Windows.Forms.TextBox();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ownerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.form_book = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form_book)).BeginInit();
            this.SuspendLayout();
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_add.Location = new System.Drawing.Point(23, 60);
            this.button_add.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(81, 38);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "添加图书";
            this.button_add.UseVisualStyleBackColor = true;
            // 
            // button_dele
            // 
            this.button_dele.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_dele.Location = new System.Drawing.Point(121, 60);
            this.button_dele.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_dele.Name = "button_dele";
            this.button_dele.Size = new System.Drawing.Size(81, 38);
            this.button_dele.TabIndex = 1;
            this.button_dele.Text = "删除图书";
            this.button_dele.UseVisualStyleBackColor = true;
            this.button_dele.Click += new System.EventHandler(this.button_dele_Click);
            // 
            // button_revise
            // 
            this.button_revise.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_revise.Location = new System.Drawing.Point(72, 117);
            this.button_revise.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_revise.Name = "button_revise";
            this.button_revise.Size = new System.Drawing.Size(81, 38);
            this.button_revise.TabIndex = 1;
            this.button_revise.Text = "修改图书";
            this.button_revise.UseVisualStyleBackColor = true;
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_search.Location = new System.Drawing.Point(4, 202);
            this.label_search.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(84, 20);
            this.label_search.TabIndex = 2;
            this.label_search.Text = "书名查询：";
            // 
            // label_search_isbn
            // 
            this.label_search_isbn.AutoSize = true;
            this.label_search_isbn.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_search_isbn.Location = new System.Drawing.Point(4, 256);
            this.label_search_isbn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_search_isbn.Name = "label_search_isbn";
            this.label_search_isbn.Size = new System.Drawing.Size(88, 20);
            this.label_search_isbn.TabIndex = 2;
            this.label_search_isbn.Text = "ISBN查询：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(417, 320);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Textbox_Bookname);
            this.panel1.Controls.Add(this.Textbox_ISBN);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.button_dele);
            this.panel1.Controls.Add(this.label_search_isbn);
            this.panel1.Controls.Add(this.button_revise);
            this.panel1.Controls.Add(this.label_search);
            this.panel1.Location = new System.Drawing.Point(989, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 602);
            this.panel1.TabIndex = 4;
            // 
            // Textbox_Bookname
            // 
            this.Textbox_Bookname.Location = new System.Drawing.Point(94, 202);
            this.Textbox_Bookname.Name = "Textbox_Bookname";
            this.Textbox_Bookname.PlaceholderText = "请输入要查询的书名";
            this.Textbox_Bookname.Size = new System.Drawing.Size(121, 23);
            this.Textbox_Bookname.TabIndex = 5;
            this.Textbox_Bookname.TextChanged += new System.EventHandler(this.Textbox_Bookname_TextChanged);
            // 
            // Textbox_ISBN
            // 
            this.Textbox_ISBN.Location = new System.Drawing.Point(94, 253);
            this.Textbox_ISBN.Name = "Textbox_ISBN";
            this.Textbox_ISBN.PlaceholderText = "请输入要查询的ISBN";
            this.Textbox_ISBN.Size = new System.Drawing.Size(121, 23);
            this.Textbox_ISBN.TabIndex = 4;
            this.Textbox_ISBN.TextChanged += new System.EventHandler(this.Textbox_ISBN_TextChanged);
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(WinFormsApp1.Book);
            // 
            // ownerIDDataGridViewTextBoxColumn
            // 
            this.ownerIDDataGridViewTextBoxColumn.DataPropertyName = "OwnerID";
            this.ownerIDDataGridViewTextBoxColumn.HeaderText = "当前借阅人";
            this.ownerIDDataGridViewTextBoxColumn.Name = "ownerIDDataGridViewTextBoxColumn";
            this.ownerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "出版商";
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            this.publisherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "作者";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "书库位置";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryIDDataGridViewTextBoxColumn
            // 
            this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.HeaderText = "分类编号";
            this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
            this.categoryIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookCategoryDataGridViewTextBoxColumn
            // 
            this.bookCategoryDataGridViewTextBoxColumn.DataPropertyName = "BookCategory";
            this.bookCategoryDataGridViewTextBoxColumn.HeaderText = "分类";
            this.bookCategoryDataGridViewTextBoxColumn.Name = "bookCategoryDataGridViewTextBoxColumn";
            this.bookCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "描述";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "书名";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            this.iSBNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "索书号";
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            this.bookIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // form_book
            // 
            this.form_book.AllowUserToAddRows = false;
            this.form_book.AllowUserToDeleteRows = false;
            this.form_book.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.form_book.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.form_book.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.form_book.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.form_book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.form_book.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIDDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.bookCategoryDataGridViewTextBoxColumn,
            this.categoryIDDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.ownerIDDataGridViewTextBoxColumn});
            this.form_book.Location = new System.Drawing.Point(0, 0);
            this.form_book.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.form_book.Name = "form_book";
            this.form_book.ReadOnly = true;
            this.form_book.RowHeadersVisible = false;
            this.form_book.RowHeadersWidth = 51;
            this.form_book.RowTemplate.Height = 29;
            this.form_book.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.form_book.Size = new System.Drawing.Size(989, 602);
            this.form_book.TabIndex = 0;
            // 
            // winform_BookManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1215, 602);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.form_book);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "winform_BookManage";
            this.Text = "书籍管理";
            this.Load += new System.EventHandler(this.winform_BookManage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form_book)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button_add;
        private Button button_dele;
        private Button button_revise;
        private Label label_search;
        private Label label_search_isbn;
        private Label label1;
        private Panel panel1;
        private BindingSource bookBindingSource;
        private DataGridViewTextBoxColumn ownerIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookCategoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private DataGridView form_book;
        private TextBox Textbox_ISBN;
        private TextBox Textbox_Bookname;
    }
}