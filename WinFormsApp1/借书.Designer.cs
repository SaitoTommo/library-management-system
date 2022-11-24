﻿namespace WinFormsApp1
{
    partial class 借书
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(借书));
            this.form_books = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_bookqueryword = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.button_borrow = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CanBeBorrowed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.button_bollow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.form_book1)).BeginInit();
            this.SuspendLayout();
            // 
            // form_books
            // 
            this.form_books.AllowUserToAddRows = false;
            this.form_books.AllowUserToDeleteRows = false;
            this.form_books.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.form_books.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.form_books.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.form_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.form_books.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.CanBeBorrowed,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.form_books.Dock = System.Windows.Forms.DockStyle.Left;
            this.form_books.Location = new System.Drawing.Point(0, 0);
            this.form_books.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.form_books.MultiSelect = false;
            this.form_books.Name = "form_books";
            this.form_books.ReadOnly = true;
            this.form_books.RowHeadersVisible = false;
            this.form_books.RowHeadersWidth = 51;
            this.form_books.RowTemplate.Height = 29;
            this.form_books.Size = new System.Drawing.Size(394, 366);
            this.form_books.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(423, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "请输入您要查询的书名：";
            // 
            // textbox_bookqueryword
            // 
            this.textbox_bookqueryword.Location = new System.Drawing.Point(439, 101);
            this.textbox_bookqueryword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textbox_bookqueryword.Name = "textbox_bookqueryword";
            this.textbox_bookqueryword.Size = new System.Drawing.Size(157, 23);
            this.textbox_bookqueryword.TabIndex = 5;
            // 
            // button_search
            // 
            this.button_search.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_search.Location = new System.Drawing.Point(463, 130);
            this.button_search.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(100, 37);
            this.button_search.TabIndex = 6;
            this.button_search.Text = "点击查询";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_borrow
            // 
            this.button_borrow.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_borrow.Location = new System.Drawing.Point(463, 242);
            this.button_borrow.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_borrow.Name = "button_borrow";
            this.button_borrow.Size = new System.Drawing.Size(100, 63);
            this.button_borrow.TabIndex = 7;
            this.button_borrow.Text = "借出图书";
            this.button_borrow.UseVisualStyleBackColor = true;
            this.button_borrow.Click += new System.EventHandler(this.button_borrow_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "BookName";
            this.Column1.HeaderText = "书名";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // CanBeBorrowed
            // 
            this.CanBeBorrowed.DataPropertyName = "CanBeBorrowed";
            this.CanBeBorrowed.HeaderText = "是否可借";
            this.CanBeBorrowed.Name = "CanBeBorrowed";
            this.CanBeBorrowed.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Author";
            this.Column2.HeaderText = "作者";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Publisher";
            this.Column3.HeaderText = "出版社";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ISBN";
            this.Column4.HeaderText = "ISBN";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "BookID";
            this.Column5.HeaderText = "编号";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Position";
            this.Column6.HeaderText = "位置";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(544, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "请输入您要查询的书名：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(557, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 27);
            this.textBox1.TabIndex = 5;
            // 
            // button_search
            // 
            this.button_search.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_search.Location = new System.Drawing.Point(694, 132);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(94, 29);
            this.button_search.TabIndex = 6;
            this.button_search.Text = "点击查询";
            this.button_search.UseVisualStyleBackColor = true;
            // 
            // button_bollow
            // 
            this.button_bollow.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_bollow.Location = new System.Drawing.Point(595, 310);
            this.button_bollow.Name = "button_bollow";
            this.button_bollow.Size = new System.Drawing.Size(129, 74);
            this.button_bollow.TabIndex = 7;
            this.button_bollow.Text = "借出图书";
            this.button_bollow.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(544, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "请输入您要查询的作者：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(557, 220);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 27);
            this.textBox2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(694, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "点击查询";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // 借书
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 431);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button_bollow);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.form_books);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "借书";
            this.Text = "借书界面";
            ((System.ComponentModel.ISupportInitialize)(this.form_books)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView form_books;
        private Label label1;
        private TextBox textbox_bookqueryword;
        private Button button_search;//查询
        private Button button_borrow;//借出
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewCheckBoxColumn CanBeBorrowed;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Label label1;
        private TextBox textBox1;//查询书名
        private Button button_search;//查询书名
        private Button button_bollow;//借出
        private Label label2;
        private TextBox textBox2;//查询作者
        private Button button1;//查询作者
    }
}