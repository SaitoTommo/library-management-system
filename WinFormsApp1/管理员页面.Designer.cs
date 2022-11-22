namespace WinFormsApp1
{
    partial class 管理员页面
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(管理员页面));
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 图书管理系统ToolStripMenuItem
            // 
            this.图书管理系统ToolStripMenuItem.Name = "图书管理系统ToolStripMenuItem";
            this.图书管理系统ToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.图书管理系统ToolStripMenuItem.Text = "图书管理系统";
            // 
            // 借书记录管理系统ToolStripMenuItem
            // 
            this.借书记录管理系统ToolStripMenuItem.Name = "借书记录管理系统ToolStripMenuItem";
            this.借书记录管理系统ToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.借书记录管理系统ToolStripMenuItem.Text = "借书记录管理系统";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("华文中宋", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(303, 209);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(203, 31);
            this.label.TabIndex = 1;
            this.label.Text = "欢迎管理员登录";
            // 
            // 管理员页面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 433);
            this.Controls.Add(this.label);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "管理员页面";
            this.Text = "管理员页面";
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