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
            ((System.ComponentModel.ISupportInitialize)(this.form_record)).BeginInit();
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
            this.form_record.Dock = System.Windows.Forms.DockStyle.Left;
            this.form_record.Location = new System.Drawing.Point(0, 0);
            this.form_record.MultiSelect = false;
            this.form_record.Name = "form_record";
            this.form_record.RowHeadersVisible = false;
            this.form_record.RowHeadersWidth = 51;
            this.form_record.RowTemplate.Height = 29;
            this.form_record.Size = new System.Drawing.Size(506, 431);
            this.form_record.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "书名";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "日期";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // button_back
            // 
            this.button_back.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_back.Location = new System.Drawing.Point(593, 284);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(134, 57);
            this.button_back.TabIndex = 3;
            this.button_back.Text = "归还图书";
            this.button_back.UseVisualStyleBackColor = true;
            // 
            // 还书
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 431);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.form_record);
            this.Name = "还书";
            this.Text = "还书页面";
            ((System.ComponentModel.ISupportInitialize)(this.form_record)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView form_record;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button button_back;
    }
}