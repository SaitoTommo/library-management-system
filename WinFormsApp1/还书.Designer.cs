namespace WinFormsApp1
{
    partial class 还书
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(还书));
            this.form_record = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.form_record)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // form_record
            // 
            this.form_record.AllowUserToAddRows = false;
            this.form_record.AllowUserToDeleteRows = false;
            this.form_record.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.form_record.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.form_record.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.form_record.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.form_record.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.form_record.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form_record.Location = new System.Drawing.Point(0, 0);
            this.form_record.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.form_record.Name = "form_record";
            this.form_record.ReadOnly = true;
            this.form_record.RowHeadersVisible = false;
            this.form_record.RowHeadersWidth = 51;
            this.form_record.RowTemplate.Height = 29;
            this.form_record.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.form_record.Size = new System.Drawing.Size(411, 366);
            this.form_record.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "BookName";
            this.Column1.HeaderText = "书名";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "BorrowTime";
            this.Column2.HeaderText = "日期";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // button_back
            // 
            this.button_back.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_back.Location = new System.Drawing.Point(58, 241);
            this.button_back.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(104, 48);
            this.button_back.TabIndex = 3;
            this.button_back.Text = "归还图书";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button_back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(411, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 366);
            this.panel1.TabIndex = 4;
            // 
            // 还书
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(622, 366);
            this.Controls.Add(this.form_record);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "还书";
            this.Text = "还书页面";
            this.Load += new System.EventHandler(this.还书_Load);
            ((System.ComponentModel.ISupportInitialize)(this.form_record)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView form_record;
        private Button button_back;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Panel panel1;
    }
}