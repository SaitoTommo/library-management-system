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
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_Return = new System.Windows.Forms.CheckBox();
            this.checkBox_Borrow = new System.Windows.Forms.CheckBox();
            this.textBox_QueryByReader = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ResetQuery = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Textbox_Querybyname = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_LogNumber = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.form_record)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_search_isbm1
            // 
            this.label_search_isbm1.AutoSize = true;
            this.label_search_isbm1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_search_isbm1.Location = new System.Drawing.Point(1, 281);
            this.label_search_isbm1.Margin = new System.Windows.Forms.Padding(2);
            this.label_search_isbm1.Name = "label_search_isbm1";
            this.label_search_isbm1.Size = new System.Drawing.Size(84, 20);
            this.label_search_isbm1.TabIndex = 7;
            this.label_search_isbm1.Text = "日期查询：";
            // 
            // label_search1
            // 
            this.label_search1.AutoSize = true;
            this.label_search1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_search1.Location = new System.Drawing.Point(1, 233);
            this.label_search1.Margin = new System.Windows.Forms.Padding(2);
            this.label_search1.Name = "label_search1";
            this.label_search1.Size = new System.Drawing.Size(84, 20);
            this.label_search1.TabIndex = 8;
            this.label_search1.Text = "书名查询：";
            // 
            // button_revise1
            // 
            this.button_revise1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_revise1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_revise1.Location = new System.Drawing.Point(4, 96);
            this.button_revise1.Margin = new System.Windows.Forms.Padding(2);
            this.button_revise1.Name = "button_revise1";
            this.button_revise1.Size = new System.Drawing.Size(242, 38);
            this.button_revise1.TabIndex = 4;
            this.button_revise1.Text = "修改记录";
            this.button_revise1.UseVisualStyleBackColor = true;
            this.button_revise1.Click += new System.EventHandler(this.button_revise1_Click);
            // 
            // button_dele1
            // 
            this.button_dele1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_dele1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_dele1.Location = new System.Drawing.Point(4, 52);
            this.button_dele1.Margin = new System.Windows.Forms.Padding(2);
            this.button_dele1.Name = "button_dele1";
            this.button_dele1.Size = new System.Drawing.Size(242, 38);
            this.button_dele1.TabIndex = 5;
            this.button_dele1.Text = "删除记录";
            this.button_dele1.UseVisualStyleBackColor = true;
            this.button_dele1.Click += new System.EventHandler(this.button_dele1_Click);
            // 
            // button_add1
            // 
            this.button_add1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_add1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_add1.Location = new System.Drawing.Point(4, 8);
            this.button_add1.Margin = new System.Windows.Forms.Padding(2);
            this.button_add1.Name = "button_add1";
            this.button_add1.Size = new System.Drawing.Size(242, 38);
            this.button_add1.TabIndex = 6;
            this.button_add1.Text = "添加记录";
            this.button_add1.UseVisualStyleBackColor = true;
            this.button_add1.Click += new System.EventHandler(this.button_add1_Click);
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
            this.form_record.Size = new System.Drawing.Size(418, 371);
            this.form_record.TabIndex = 1;
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
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.checkBox_Return);
            this.panel1.Controls.Add(this.checkBox_Borrow);
            this.panel1.Controls.Add(this.textBox_QueryByReader);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_ResetQuery);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.Textbox_Querybyname);
            this.panel1.Controls.Add(this.button_add1);
            this.panel1.Controls.Add(this.button_dele1);
            this.panel1.Controls.Add(this.label_search_isbm1);
            this.panel1.Controls.Add(this.button_revise1);
            this.panel1.Controls.Add(this.label_search1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(418, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 371);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "记录类型：";
            // 
            // checkBox_Return
            // 
            this.checkBox_Return.AutoSize = true;
            this.checkBox_Return.Location = new System.Drawing.Point(187, 153);
            this.checkBox_Return.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_Return.Name = "checkBox_Return";
            this.checkBox_Return.Size = new System.Drawing.Size(51, 21);
            this.checkBox_Return.TabIndex = 16;
            this.checkBox_Return.Text = "归还";
            this.checkBox_Return.UseVisualStyleBackColor = true;
            this.checkBox_Return.CheckedChanged += new System.EventHandler(this.UnionQuery);
            // 
            // checkBox_Borrow
            // 
            this.checkBox_Borrow.AutoSize = true;
            this.checkBox_Borrow.Location = new System.Drawing.Point(87, 153);
            this.checkBox_Borrow.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_Borrow.Name = "checkBox_Borrow";
            this.checkBox_Borrow.Size = new System.Drawing.Size(51, 21);
            this.checkBox_Borrow.TabIndex = 15;
            this.checkBox_Borrow.Text = "借出";
            this.checkBox_Borrow.UseVisualStyleBackColor = true;
            this.checkBox_Borrow.CheckedChanged += new System.EventHandler(this.UnionQuery);
            // 
            // textBox_QueryByReader
            // 
            this.textBox_QueryByReader.Location = new System.Drawing.Point(83, 184);
            this.textBox_QueryByReader.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_QueryByReader.Name = "textBox_QueryByReader";
            this.textBox_QueryByReader.PlaceholderText = "借阅人的姓名或学号";
            this.textBox_QueryByReader.Size = new System.Drawing.Size(163, 23);
            this.textBox_QueryByReader.TabIndex = 14;
            this.textBox_QueryByReader.TextChanged += new System.EventHandler(this.UnionQuery);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "借阅人信息";
            // 
            // button_ResetQuery
            // 
            this.button_ResetQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ResetQuery.Location = new System.Drawing.Point(4, 334);
            this.button_ResetQuery.Margin = new System.Windows.Forms.Padding(2);
            this.button_ResetQuery.Name = "button_ResetQuery";
            this.button_ResetQuery.Size = new System.Drawing.Size(243, 26);
            this.button_ResetQuery.TabIndex = 12;
            this.button_ResetQuery.Text = "重置查询条件";
            this.button_ResetQuery.UseVisualStyleBackColor = true;
            this.button_ResetQuery.Click += new System.EventHandler(this.button_ResetQuery_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(83, 281);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowCheckBox = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(163, 23);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.UnionQuery);
            // 
            // Textbox_Querybyname
            // 
            this.Textbox_Querybyname.Location = new System.Drawing.Point(83, 233);
            this.Textbox_Querybyname.Margin = new System.Windows.Forms.Padding(2);
            this.Textbox_Querybyname.Name = "Textbox_Querybyname";
            this.Textbox_Querybyname.Size = new System.Drawing.Size(163, 23);
            this.Textbox_Querybyname.TabIndex = 9;
            this.Textbox_Querybyname.TextChanged += new System.EventHandler(this.UnionQuery);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_LogNumber});
            this.statusStrip1.Location = new System.Drawing.Point(0, 349);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(418, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_LogNumber
            // 
            this.toolStripStatusLabel_LogNumber.Name = "toolStripStatusLabel_LogNumber";
            this.toolStripStatusLabel_LogNumber.Size = new System.Drawing.Size(0, 17);
            // 
            // winform_BorrowLogManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(667, 371);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.form_record);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "winform_BorrowLogManage";
            this.Text = "借书记录管理系统";
            this.Load += new System.EventHandler(this.winform_BorrowLogManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.form_record)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private TextBox textBox_QueryByReader;
        private Label label1;
        private CheckBox checkBox_Return;
        private CheckBox checkBox_Borrow;
        private Label label2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel_LogNumber;
    }
}