namespace WinFormsApp1
{
    partial class winform_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winform_admin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.图书管理系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借书记录管理系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图书管理系统ToolStripMenuItem,
            this.借书记录管理系统ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(622, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 图书管理系统ToolStripMenuItem
            // 
            this.图书管理系统ToolStripMenuItem.Name = "图书管理系统ToolStripMenuItem";
            this.图书管理系统ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.图书管理系统ToolStripMenuItem.Text = "图书管理系统";
            this.图书管理系统ToolStripMenuItem.Click += new System.EventHandler(this.图书管理系统ToolStripMenuItem_Click);
            // 
            // 借书记录管理系统ToolStripMenuItem
            // 
            this.借书记录管理系统ToolStripMenuItem.Name = "借书记录管理系统ToolStripMenuItem";
            this.借书记录管理系统ToolStripMenuItem.Size = new System.Drawing.Size(116, 21);
            this.借书记录管理系统ToolStripMenuItem.Text = "借书记录管理系统";
            this.借书记录管理系统ToolStripMenuItem.Click += new System.EventHandler(this.借书记录管理系统ToolStripMenuItem_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("华文中宋", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(210, 169);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(166, 25);
            this.label.TabIndex = 1;
            this.label.Text = "欢迎管理员登录";
            // 
            // winform_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(622, 368);
            this.Controls.Add(this.label);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "winform_admin";
            this.Text = "管理员页面";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.winform_admin_FormClosed);
            this.Load += new System.EventHandler(this.winform_admin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 图书管理系统ToolStripMenuItem;
        private ToolStripMenuItem 借书记录管理系统ToolStripMenuItem;
        private Label label;
    }
}