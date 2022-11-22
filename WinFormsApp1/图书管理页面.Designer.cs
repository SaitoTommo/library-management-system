namespace WinFormsApp1
{
    partial class 图书管理页面
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(图书管理页面));
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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.form_book.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.form_book.MultiSelect = false;
            this.form_book.Name = "form_book";
            this.form_book.RowHeadersVisible = false;
            this.form_book.RowHeadersWidth = 51;
            this.form_book.RowTemplate.Height = 29;
            this.form_book.Size = new System.Drawing.Size(394, 373);
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
            this.button_add.Location = new System.Drawing.Point(417, 60);
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
            this.button_dele.Location = new System.Drawing.Point(515, 60);
            this.button_dele.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_dele.Name = "button_dele";
            this.button_dele.Size = new System.Drawing.Size(81, 38);
            this.button_dele.TabIndex = 1;
            this.button_dele.Text = "删除图书";
            this.button_dele.UseVisualStyleBackColor = true;
            // 
            // button_revise
            // 
            this.button_revise.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_revise.Location = new System.Drawing.Point(466, 117);
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
            this.label_search.Location = new System.Drawing.Point(404, 201);
            this.label_search.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(84, 20);
            this.label_search.TabIndex = 2;
            this.label_search.Text = "书名查询：";
            // 
            // label_search_isbm
            // 
            this.label_search_isbm.AutoSize = true;
            this.label_search_isbm.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_search_isbm.Location = new System.Drawing.Point(398, 256);
            this.label_search_isbm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_search_isbm.Name = "label_search_isbm";
            this.label_search_isbm.Size = new System.Drawing.Size(91, 20);
            this.label_search_isbm.TabIndex = 2;
            this.label_search_isbm.Text = "ISBM查询：";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(488, 201);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(121, 23);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.Text = "请输入要查询的书名";
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(488, 256);
            this.maskedTextBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(121, 23);
            this.maskedTextBox2.TabIndex = 3;
            this.maskedTextBox2.Text = "请输入要查询的ISBM";
            this.maskedTextBox2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
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
            // 图书管理页面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(622, 373);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_search_isbm);
            this.Controls.Add(this.label_search);
            this.Controls.Add(this.button_revise);
            this.Controls.Add(this.button_dele);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.form_book);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "图书管理页面";
            this.Text = "图书管理页面";
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
        private MaskedTextBox maskedTextBox1;//书名查询
        private MaskedTextBox maskedTextBox2;//ISBM查询
        private Label label1;
    }
}