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
            this.label_search_isbm1 = new System.Windows.Forms.Label();
            this.label_search1 = new System.Windows.Forms.Label();
            this.button_revise1 = new System.Windows.Forms.Button();
            this.button_dele1 = new System.Windows.Forms.Button();
            this.button_add1 = new System.Windows.Forms.Button();
            this.form_record = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReaderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Textbox_Querybyname = new System.Windows.Forms.TextBox();
            this.button_ResetQuery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.form_record)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_search_isbm1
            // 
            this.label_search_isbm1.AutoSize = true;
            this.label_search_isbm1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_search_isbm1.Location = new System.Drawing.Point(13, 263);
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
            this.label_search1.Location = new System.Drawing.Point(13, 212);
            this.label_search1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_search1.Name = "label_search1";
            this.label_search1.Size = new System.Drawing.Size(84, 20);
            this.label_search1.TabIndex = 8;
            this.label_search1.Text = "书名查询：";
            // 
            // button_revise1
            // 
            this.button_revise1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_revise1.Location = new System.Drawing.Point(75, 128);
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
            this.button_dele1.Location = new System.Drawing.Point(124, 70);
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
            this.button_add1.Location = new System.Drawing.Point(26, 70);
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
            this.form_record.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.ReaderID,
            this.ActionType,
            this.BookName,
            this.BookID});
            this.form_record.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form_record.Location = new System.Drawing.Point(0, 0);
            this.form_record.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.form_record.Name = "form_record";
            this.form_record.ReadOnly = true;
            this.form_record.RowHeadersVisible = false;
            this.form_record.RowHeadersWidth = 51;
            this.form_record.RowTemplate.Height = 29;
            this.form_record.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.form_record.Size = new System.Drawing.Size(397, 371);
            this.form_record.TabIndex = 1;
            this.form_record.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.form_book_CellContentClick);
            // 
            // Time
            // 
            this.Time.DataPropertyName = "BorrowTime";
            this.Time.HeaderText = "时间";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // ReaderID
            // 
            this.ReaderID.DataPropertyName = "Reader";
            this.ReaderID.HeaderText = "借阅人信息";
            this.ReaderID.Name = "ReaderID";
            this.ReaderID.ReadOnly = true;
            // 
            // ActionType
            // 
            this.ActionType.DataPropertyName = "ActionType";
            this.ActionType.HeaderText = "行为";
            this.ActionType.Name = "ActionType";
            this.ActionType.ReadOnly = true;
            // 
            // BookName
            // 
            this.BookName.DataPropertyName = "BookName";
            this.BookName.HeaderText = "书名";
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            // 
            // BookID
            // 
            this.BookID.DataPropertyName = "BookID";
            this.BookID.HeaderText = "索书号";
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button_ResetQuery);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.Textbox_Querybyname);
            this.panel1.Controls.Add(this.button_add1);
            this.panel1.Controls.Add(this.button_dele1);
            this.panel1.Controls.Add(this.label_search_isbm1);
            this.panel1.Controls.Add(this.button_revise1);
            this.panel1.Controls.Add(this.label_search1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(397, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 371);
            this.panel1.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 260);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(117, 23);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // Textbox_Querybyname
            // 
            this.Textbox_Querybyname.Location = new System.Drawing.Point(88, 212);
            this.Textbox_Querybyname.Name = "Textbox_Querybyname";
            this.Textbox_Querybyname.Size = new System.Drawing.Size(117, 23);
            this.Textbox_Querybyname.TabIndex = 9;
            // 
            // button_ResetQuery
            // 
            this.button_ResetQuery.Location = new System.Drawing.Point(13, 299);
            this.button_ResetQuery.Name = "button_ResetQuery";
            this.button_ResetQuery.Size = new System.Drawing.Size(192, 26);
            this.button_ResetQuery.TabIndex = 12;
            this.button_ResetQuery.Text = "重置查询条件";
            this.button_ResetQuery.UseVisualStyleBackColor = true;
            // 
            // winform_BorrowLogManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(622, 371);
            this.Controls.Add(this.form_record);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "winform_BorrowLogManage";
            this.Text = "借书记录管理系统";
            this.Load += new System.EventHandler(this.winform_BorrowLogManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.form_record)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label_search_isbm1;
        private Label label_search1;
        private Button button_revise1;   //增删改
        private Button button_dele1;
        private Button button_add1;
        private DataGridView form_record;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn ReaderID;
        private DataGridViewTextBoxColumn ActionType;
        private DataGridViewTextBoxColumn BookName;
        private DataGridViewTextBoxColumn BookID;
        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private TextBox Textbox_Querybyname;
        private Button button_ResetQuery;
    }
}