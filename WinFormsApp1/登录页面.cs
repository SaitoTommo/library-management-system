using System;
using System.CodeDom;
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

        private void button1_Click(object sender, EventArgs e)//登录按钮
        {
            if (textBox1.Text == null || textBox1.Text == string.Empty || textBox2.Text == null || textBox2.Text == string.Empty)
            {
                MessageBox.Show("请输入登录信息");
                return;
            }
            var Role = radioButton_admin.Checked ? AccountRole.Admin : AccountRole.Student;// 选择的身份
            try
            {
                var _temp = LibraryDbContext.Shared.Accounts.Single(acc =>
                    acc.ID == textBox1.Text && acc.Password == Encryptor.SHA256Encrypt(textBox2.Text + "X") && acc.Role == Role);

                if (_temp != null && _temp.ID == textBox1.Text)//复核登录
                {
                    Global.account = _temp;
                    switch (_temp.Role)
                    {
                        case AccountRole.Admin:
                            new winform_admin().Show();
                            this.Hide();
                            break;
                        case AccountRole.Student:
                            new winform_stu().Show();
                            this.Hide();
                            break;
                        default:
                            throw new InvalidOperationException("账户角色错误");
                    }

                    _temp = null;
                }
                else
                {
                    MessageBox.Show("账号或密码错误");
                }
            }
            catch (InvalidOperationException ex)
            {
                //throw ex;
                MessageBox.Show($"错误\n{ex.Message}");
                //MessageBox.Show(ex.Message+"\n"+ex.GetType().ToString());
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show($"未知错误\n{ex.GetType()}\n{ex.Message}");
            }
        }

        private void winform_log_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            //string b = "";
            //var aa = from book in LibraryDbContext.Shared.Books
            //         where book.CategoryID == 1
            //         select new { Name = book.Name, ID = book.BookID };
            //foreach (var a in aa)
            //{
            //    b+= a+"\n";
            //}
            //MessageBox.Show(b);
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
