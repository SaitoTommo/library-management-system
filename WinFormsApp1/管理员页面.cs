using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class winform_admin : Form
    {
        public winform_admin()
        {
            InitializeComponent();
        }

        private void winform_admin_Load(object sender, EventArgs e)
        {
            label.Text=$"欢迎管理员 {Global.account.Name} 登录";
        }

        private void winform_admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void 图书管理系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new winform_BookManage().Show();
        }

        private void 借书记录管理系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new winform_BorrowLogManage().Show();
        }
    }
}
