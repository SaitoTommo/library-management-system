namespace WinFormsApp1
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
            this.form_book1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.button_bollow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.form_book1)).BeginInit();
            this.SuspendLayout();
            // 
            // form_book1
            // 
            this.form_book1.AllowUserToAddRows = false;
            this.form_book1.AllowUserToDeleteRows = false;
            this.form_book1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.form_book1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.form_book1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.form_book1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.form_book1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.form_book1.Dock = System.Windows.Forms.DockStyle.Left;
            this.form_book1.Location = new System.Drawing.Point(0, 0);
            this.form_book1.MultiSelect = false;
            this.form_book1.Name = "form_book1";
            this.form_book1.RowHeadersVisible = false;
            this.form_book1.RowHeadersWidth = 51;
            this.form_book1.RowTemplate.Height = 29;
            this.form_book1.Size = new System.Drawing.Size(506, 431);
            this.form_book1.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(544, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "请输入您要查询的书名：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(557, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 27);
            this.textBox1.TabIndex = 5;
            // 
            // button_search
            // 
            this.button_search.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_search.Location = new System.Drawing.Point(694, 161);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(94, 29);
            this.button_search.TabIndex = 6;
            this.button_search.Text = "点击查询";
            this.button_search.UseVisualStyleBackColor = true;
            // 
            // button_bollow
            // 
            this.button_bollow.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_bollow.Location = new System.Drawing.Point(595, 282);
            this.button_bollow.Name = "button_bollow";
            this.button_bollow.Size = new System.Drawing.Size(129, 74);
            this.button_bollow.TabIndex = 7;
            this.button_bollow.Text = "借出图书";
            this.button_bollow.UseVisualStyleBackColor = true;
            // 
            // 借书
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 431);
            this.Controls.Add(this.button_bollow);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.form_book1);
            this.Name = "借书";
            this.Text = "借书界面";
            ((System.ComponentModel.ISupportInitialize)(this.form_book1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView form_book1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Label label1;
        private TextBox textBox1;
        private Button button_search;//查询
        private Button button_bollow;//借出
    }
}