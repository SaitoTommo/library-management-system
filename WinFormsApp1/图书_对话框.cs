using Microsoft.EntityFrameworkCore;

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
    public partial class Dialog_BookModify : Form
    {
        private enum ActionType
        {
            Modify,
            Add
        }

        private Book booktoEdit = new Book();
        private BookInfo bookInfotoEdit = new BookInfo();
        private BookCategory bookCategory = new();
        private BookWareHouse wareHouse = new();

        private ActionType actionType;

        private bool BookIDChangeFlag = false;
        private string OldBookID = string.Empty;

        public Dialog_BookModify()
        {
            actionType = ActionType.Add;

            InitializeComponent();
            this.Text = "增加图书信息";
            this.textBox_BookID.Enabled = false;
        }

        public Dialog_BookModify(Book book, BookInfo bookInfo, BookCategory category, BookWareHouse bookWareHouse)
        {
            booktoEdit = book;
            bookInfotoEdit = bookInfo;
            bookCategory = category;
            wareHouse = bookWareHouse;
            actionType = ActionType.Modify;
            OldBookID= book.BookID;

            InitializeComponent();
            this.Text = "修改图书信息";
        }

        private async void Dialog_BookModify_Load(object sender, EventArgs e)
        {
            comboBox_Category.Items.AddRange(LibraryDbContext.Shared.Categories.ToArray());
            comboBox_BookWarehouse.Items.AddRange(LibraryDbContext.Shared.BookWareHouses.ToArray());

            comboBox_BookWarehouse.SelectedIndex = 0;
            comboBox_Category.SelectedIndex = 0;

            if (actionType == ActionType.Modify)
            {
                textBox_BookName.Text = bookInfotoEdit.Name;
                textBox_ISBN.Text = bookInfotoEdit.ISBN;
                comboBox_Category.SelectedItem = bookCategory;
                textBox_Author.Text = bookInfotoEdit.Author;
                textBox_BookID.Text = booktoEdit.BookID;
                textBox_Publisher.Text = bookInfotoEdit.Publisher;
                comboBox_BookWarehouse.SelectedItem = wareHouse;
                textBox_Description.Text = bookInfotoEdit.Description;
            }

            string old = this.Text;
            this.Text = "加载中";
            //把书库库加载到本地
            await LibraryDbContext.Shared.Books.LoadAsync();
            this.Text = old;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            // = =
            if (actionType == ActionType.Modify)
            {
                if (textBox_BookID.Text != OldBookID && LibraryDbContext.Shared.Books.Single(e => (e.BookID.ToLower() == this.textBox_BookID.Text.ToLower()))!=null)
                {
                    MessageBox.Show("索书号重复，本次更改不会生效");
                    this.Close();
                    return;
                }
                bookInfotoEdit.Name = textBox_BookName.Text;
                bookInfotoEdit.ISBN = textBox_ISBN.Text;
                bookInfotoEdit.CategoryID = (comboBox_Category.SelectedItem as BookCategory).Id;
                bookInfotoEdit.Author = textBox_Author.Text;
                bookInfotoEdit.Publisher = textBox_Publisher.Text;
                bookInfotoEdit.Description = textBox_Description.Text;

                booktoEdit.BookID = textBox_BookID.Text;
                booktoEdit.Position = (comboBox_BookWarehouse.SelectedItem as BookWareHouse).Id;
            }
            else //增加书目 如果为已有书目要特别处理
            {
                var a = LibraryDbContext.Shared.BookInfo.Single(e => e.ISBN == textBox_ISBN.Text);

                if (a == null)
                {
                    bookInfotoEdit.Name = textBox_BookName.Text;
                    bookInfotoEdit.ISBN = textBox_ISBN.Text;
                    bookInfotoEdit.CategoryID = (comboBox_Category.SelectedItem as BookCategory).Id;
                    bookInfotoEdit.Author = textBox_Author.Text;
                    bookInfotoEdit.Publisher = textBox_Publisher.Text;
                    bookInfotoEdit.Description = textBox_Description.Text;
                    LibraryDbContext.Shared.BookInfo.Add(bookInfotoEdit);
                    LibraryDbContext.Shared.SaveChanges();
                    a = LibraryDbContext.Shared.BookInfo.Single(e => e.ISBN == bookInfotoEdit.ISBN);
                }

                booktoEdit.BookInfoId = a.Id;
                booktoEdit.BookID = textBox_BookID.Text;
                booktoEdit.Position = (comboBox_BookWarehouse.SelectedItem as BookWareHouse).Id;
                booktoEdit.OwnerID = null;
                LibraryDbContext.Shared.Books.Add(booktoEdit);
            }
            LibraryDbContext.Shared.SaveChanges();
            this.Close();
        }

        /// <summary>
        /// 自动生成索书号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_BookID.Text = $"{(comboBox_Category.SelectedItem as BookCategory).CategoryID}/{LibraryDbContext.Shared.Books.Where(e => LibraryDbContext.Shared.BookInfo.Single(f => f.Id == e.BookInfoId).CategoryID == (comboBox_Category.SelectedItem as BookCategory).Id).Count() + 1}";
        }

        private void textBox_BookID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_ISBN_Leave(object sender, EventArgs e)
        {
            //焦点离开自动生成内容
            var a = LibraryDbContext.Shared.BookInfo.Where(ee => ee.ISBN.Replace("-", string.Empty) == textBox_ISBN.Text.Replace("-", string.Empty));
            if (a.Count() >= 0) 
            { 
                textBox_BookName.Text = a.First().Name;
                textBox_ISBN.Text = a.First().ISBN;
                textBox_Publisher.Text = a.First().Publisher;
                textBox_Author.Text = a.First().Author;
                textBox_Description.Text = a.First().Description;
                comboBox_Category.SelectedItem = LibraryDbContext.Shared.Categories.Where(c => c.Id == a.First().CategoryID);
            }
        }
    }
}
