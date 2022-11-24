namespace WinFormsApp1
{
    partial class winform_BorrowLogManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winform_BorrowLogManage));
            this.maskedTextBox22 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox11 = new System.Windows.Forms.MaskedTextBox();
            this.label_search_isbm1 = new System.Windows.Forms.Label();
            this.label_search1 = new System.Windows.Forms.Label();
            this.button_revise1 = new System.Windows.Forms.Button();
            this.button_dele1 = new System.Windows.Forms.Button();
            this.button_add1 = new System.Windows.Forms.Button();
            this.form_record = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.form_record)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextBox22
            // 
            this.maskedTextBox22.Location = new System.Drawing.Point(492, 263);
            this.maskedTextBox22.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.maskedTextBox22.Name = "maskedTextBox22";
            this.maskedTextBox22.Size = new System.Drawing.Size(121, 23);
            this.maskedTextBox22.TabIndex = 9;
            this.maskedTextBox22.Text = "请输入要查询的日期";
            // 
            // maskedTextBox11
            // 
            this.maskedTextBox11.Location = new System.Drawing.Point(492, 212);
            this.maskedTextBox11.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.maskedTextBox11.Name = "maskedTextBox11";
            this.maskedTextBox11.Size = new System.Drawing.Size(121, 23);
            this.maskedTextBox11.TabIndex = 10;
            this.maskedTextBox11.Text = "请输入要查询的书名";
            // 
            // label_search_isbm1
            // 
            this.label_search_isbm1.AutoSize = true;
            this.label_search_isbm1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_search_isbm1.Location = new System.Drawing.Point(408, 263);
            this.label_search_isbm1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_search_isbm1.Name = "label_search_isbm1";
            this.label_search_isbm1.Size = new System.Drawing.Size(84, 20);
            this.label_search_isbm1.TabIndex = 7;
            this.label_search_isbm1.Text = "日期查询：";
            // 
            // label_search1
            // 
            this.label_search1.AutoSize = true;
            this.label_search1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_search1.Location = new System.Drawing.Point(408, 212);
            this.label_search1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_search1.Name = "label_search1";
            this.label_search1.Size = new System.Drawing.Size(84, 20);
            this.label_search1.TabIndex = 8;
            this.label_search1.Text = "书名查询：";
            // 
            // button_revise1
            // 
            this.button_revise1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_revise1.Location = new System.Drawing.Point(470, 128);
            this.button_revise1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_revise1.Name = "button_revise1";
            this.button_revise1.Size = new System.Drawing.Size(81, 38);
            this.button_revise1.TabIndex = 4;
            this.button_revise1.Text = "修改记录";
            this.button_revise1.UseVisualStyleBackColor = true;
            // 
            // button_dele1
            // 
            this.button_dele1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_dele1.Location = new System.Drawing.Point(519, 70);
            this.button_dele1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_dele1.Name = "button_dele1";
            this.button_dele1.Size = new System.Drawing.Size(81, 38);
            this.button_dele1.TabIndex = 5;
            this.button_dele1.Text = "删除记录";
            this.button_dele1.UseVisualStyleBackColor = true;
            // 
            // button_add1
            // 
            this.button_add1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_add1.Location = new System.Drawing.Point(421, 70);
            this.button_add1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_add1.Name = "button_add1";
            this.button_add1.Size = new System.Drawing.Size(81, 38);
            this.button_add1.TabIndex = 6;
            this.button_add1.Text = "添加记录";
            this.button_add1.UseVisualStyleBackColor = true;
            // 
            // form_record
            // 
            this.form_record.AllowUserToAddRows = false;
            this.form_record.AllowUserToDeleteRows = false;
            this.form_record.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.form_record.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.form_record.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.form_record.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.form_record.Dock = System.Windows.Forms.DockStyle.Left;
            this.form_record.Location = new System.Drawing.Point(0, 0);
            this.form_record.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.form_record.MultiSelect = false;
            this.form_record.Name = "form_record";
            this.form_record.ReadOnly = true;
            this.form_record.RowHeadersVisible = false;
            this.form_record.RowHeadersWidth = 51;
            this.form_record.RowTemplate.Height = 29;
            this.form_record.Size = new System.Drawing.Size(394, 371);
            this.form_record.TabIndex = 1;
            this.form_record.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.form_book_CellContentClick);
            // 
            // winform_BorrowLogManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(622, 371);
            this.Controls.Add(this.maskedTextBox22);
            this.Controls.Add(this.maskedTextBox11);
            this.Controls.Add(this.label_search_isbm1);
            this.Controls.Add(this.label_search1);
            this.Controls.Add(this.button_revise1);
            this.Controls.Add(this.button_dele1);
            this.Controls.Add(this.button_add1);
            this.Controls.Add(this.form_record);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "winform_BorrowLogManage";
            this.Text = "借书记录管理系统";
            this.Load += new System.EventHandler(this.winform_BorrowLogManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.form_record)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaskedTextBox maskedTextBox22;//书名查询
        private MaskedTextBox maskedTextBox11;//日期查询
        private Label label_search_isbm1;
        private Label label_search1;
        private Button button_revise1;   //增删改
        private Button button_dele1;
        private Button button_add1;
        private DataGridView form_record;
    }
}