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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winform_BookManage));
            this.form_book = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_add = new System.Windows.Forms.Button();
            this.button_dele = new System.Windows.Forms.Button();
            this.button_revise = new System.Windows.Forms.Button();
            this.label_search = new System.Windows.Forms.Label();
            this.label_search_isbm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_refresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.form_book)).BeginInit();
            this.SuspendLayout();
            // 
            // form_book
            // 
            this.form_book.AllowUserToAddRows = false;
            this.form_book.AllowUserToDeleteRows = false;
            this.form_book.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.form_book.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.form_book.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.form_book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.form_book.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.form_book.Dock = System.Windows.Forms.DockStyle.Left;
            this.form_book.Location = new System.Drawing.Point(0, 0);
            this.form_book.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.form_book.MultiSelect = false;
            this.form_book.Name = "form_book";
            this.form_book.RowHeadersVisible = false;
            this.form_book.RowHeadersWidth = 51;
            this.form_book.RowTemplate.Height = 29;
            this.form_book.Size = new System.Drawing.Size(507, 439);
            this.form_book.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "书名";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "作者";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "出版社";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ISBM";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "编号";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "位置";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_add.Location = new System.Drawing.Point(536, 71);
            this.button_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(104, 45);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "添加图书";
            this.button_add.UseVisualStyleBackColor = true;
            // 
            // button_dele
            // 
            this.button_dele.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_dele.Location = new System.Drawing.Point(662, 71);
            this.button_dele.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_dele.Name = "button_dele";
            this.button_dele.Size = new System.Drawing.Size(104, 45);
            this.button_dele.TabIndex = 1;
            this.button_dele.Text = "删除图书";
            this.button_dele.UseVisualStyleBackColor = true;
            // 
            // button_revise
            // 
            this.button_revise.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_revise.Location = new System.Drawing.Point(536, 138);
            this.button_revise.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_revise.Name = "button_revise";
            this.button_revise.Size = new System.Drawing.Size(104, 45);
            this.button_revise.TabIndex = 1;
            this.button_revise.Text = "修改图书";
            this.button_revise.UseVisualStyleBackColor = true;
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_search.Location = new System.Drawing.Point(519, 236);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(100, 24);
            this.label_search.TabIndex = 2;
            this.label_search.Text = "书名查询：";
            // 
            // label_search_isbm
            // 
            this.label_search_isbm.AutoSize = true;
            this.label_search_isbm.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_search_isbm.Location = new System.Drawing.Point(515, 278);
            this.label_search_isbm.Name = "label_search_isbm";
            this.label_search_isbm.Size = new System.Drawing.Size(105, 24);
            this.label_search_isbm.TabIndex = 2;
            this.label_search_isbm.Text = "ISBN查询：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(536, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(625, 236);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "请输入您要查询的书名";
            this.textBox1.Size = new System.Drawing.Size(156, 27);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(625, 278);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "请输入您要查询的ISBM";
            this.textBox2.Size = new System.Drawing.Size(162, 27);
            this.textBox2.TabIndex = 5;
            // 
            // button_refresh
            // 
            this.button_refresh.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_refresh.Location = new System.Drawing.Point(662, 138);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(104, 45);
            this.button_refresh.TabIndex = 6;
            this.button_refresh.Text = "刷新";
            this.button_refresh.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(520, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "作者查询：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(625, 327);
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "请输入您要查询的作者";
            this.textBox3.Size = new System.Drawing.Size(156, 27);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(625, 373);
            this.textBox4.Name = "textBox4";
            this.textBox4.PlaceholderText = "请输入您要查询的编号";
            this.textBox4.Size = new System.Drawing.Size(156, 27);
            this.textBox4.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(520, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "编号查询：";
            // 
            // winform_BookManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 439);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_search_isbm);
            this.Controls.Add(this.label_search);
            this.Controls.Add(this.button_revise);
            this.Controls.Add(this.button_dele);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.form_book);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "winform_BookManage";
            this.Text = "图书管理页面";
            this.Load += new System.EventHandler(this.winform_BookManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.form_book)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView form_book;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button button_add;
        private Button button_dele;
        private Button button_revise;
        private Label label_search;
        private Label label_search_isbm;
        private Label label1;
        private TextBox textBox1; //查书名
        private TextBox textBox2;//ISBN
        private Button button_refresh;
        private Label label2;
        private TextBox textBox3;//作者
        private TextBox textBox4;//编号（索书号）
        private Label label3;
    }
}