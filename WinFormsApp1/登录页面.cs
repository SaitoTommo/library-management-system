using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class winform_log : Form
    {
        public winform_log()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//登录按钮
        {
            if (textBox1.Text == null || textBox1.Text == string.Empty || textBox2.Text == null || textBox2.Text == string.Empty) 
            {
                MessageBox.Show("请输入登录信息");
                return;
            }
            var Role = radioButton_admin.Checked? 0 : 1;// 选择的身份
            try
            {
                var _temp = LibraryDbContext.Shared.Accounts.Single(acc => acc.ID == textBox1.Text && acc.Password == Encryptor.SHA256Encrypt(textBox2.Text + "X") && acc.Role == Role);
                if (_temp != null && _temp.ID == textBox1.Text)//复核登录
                {
                    Global.account = _temp;
                    _temp = null;
                    MessageBox.Show("登陆成功");
                }
                else
                {
                    MessageBox.Show("账号或密码错误");
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("账号或密码错误");
                //MessageBox.Show(ex.Message+"\n"+ex.GetType().ToString());
            }
            catch (ArgumentNullException ex) 
            {
                MessageBox.Show("未知错误");
            }
        }

        private void winform_log_Load(object sender, EventArgs e)
        {

        }

        private void account_Click(object sender, EventArgs e)
        {

        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
