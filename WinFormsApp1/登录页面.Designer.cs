namespace WinFormsApp1
{
    partial class winform_log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winform_log));
            this.welcome = new System.Windows.Forms.Label();
            this.account = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_log = new System.Windows.Forms.Button();
            this.radioButton_admin = new System.Windows.Forms.RadioButton();
            this.button_cancel = new System.Windows.Forms.Button();
            this.radioButton_stu = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.BackColor = System.Drawing.SystemColors.Control;
            this.welcome.Font = new System.Drawing.Font("华文新魏", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.welcome.Location = new System.Drawing.Point(226, 60);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(377, 40);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "欢迎登录图书馆系统";
            this.welcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // account
            // 
            this.account.AutoSize = true;
            this.account.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.account.Location = new System.Drawing.Point(255, 142);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(65, 30);
            this.account.TabIndex = 1;
            this.account.Text = "账户:";
            this.account.Click += new System.EventHandler(this.account_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(255, 191);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(65, 30);
            this.password.TabIndex = 1;
            this.password.Text = "密码:";
            this.password.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(331, 145);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 27);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(331, 194);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(218, 27);
            this.textBox2.TabIndex = 2;
            // 
            // button_log
            // 
            this.button_log.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_log.Location = new System.Drawing.Point(258, 313);
            this.button_log.Name = "button_log";
            this.button_log.Size = new System.Drawing.Size(122, 41);
            this.button_log.TabIndex = 3;
            this.button_log.Text = "登录";
            this.button_log.UseVisualStyleBackColor = true;
            this.button_log.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton_admin
            // 
            this.radioButton_admin.AutoSize = true;
            this.radioButton_admin.Checked = true;
            this.radioButton_admin.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_admin.Location = new System.Drawing.Point(305, 246);
            this.radioButton_admin.Name = "radioButton_admin";
            this.radioButton_admin.Size = new System.Drawing.Size(85, 28);
            this.radioButton_admin.TabIndex = 5;
            this.radioButton_admin.TabStop = true;
            this.radioButton_admin.Text = "管理员";
            this.radioButton_admin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_admin.UseVisualStyleBackColor = true;
            this.radioButton_admin.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_cancel.Location = new System.Drawing.Point(472, 313);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(122, 41);
            this.button_cancel.TabIndex = 3;
            this.button_cancel.Text = "取消";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // radioButton_stu
            // 
            this.radioButton_stu.AutoSize = true;
            this.radioButton_stu.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_stu.Location = new System.Drawing.Point(457, 246);
            this.radioButton_stu.Name = "radioButton_stu";
            this.radioButton_stu.Size = new System.Drawing.Size(67, 28);
            this.radioButton_stu.TabIndex = 5;
            this.radioButton_stu.Text = "学生";
            this.radioButton_stu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_stu.UseVisualStyleBackColor = true;
            this.radioButton_stu.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // winform_log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.radioButton_stu);
            this.Controls.Add(this.radioButton_admin);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_log);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.account);
            this.Controls.Add(this.welcome);
            this.Name = "winform_log";
            this.Text = "图书馆管理系统";
            this.Load += new System.EventHandler(this.winform_log_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label welcome;
        private Label account;
        private Label password;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button_log;
        private RadioButton radioButton_admin;
        private Button button_cancel;
        private RadioButton radioButton_stu;
    }
}