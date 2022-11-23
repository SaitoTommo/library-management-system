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
    public partial class winform_stu : Form
    {
        public winform_stu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void winform_stu_Load(object sender, EventArgs e)
        {
            label1.Text = $"欢迎 {Global.account.Name} 同学";
        }

        private void 借书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           new 借书().Show();
        }

        private void winform_stu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void 还书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new 还书().Show();
        }
    }
}
