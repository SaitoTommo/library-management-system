using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;                //图书管理页面的增删改查

namespace WinFormsApp1
{
    public partial class winform_BookManage : Form
    {
        IQueryable<BookListQueryRecord> Query;
        public winform_BookManage()
        {
            InitializeComponent();
        }

        private void winform_BookManage_Load(object sender, EventArgs e)
        {
            form_book.AutoGenerateColumns = false;
            ShowBookList();
        }

        private void ShowBookList()
        {
            //Query.Load();
            Query = from book in LibraryDbContext.Shared.Books
                        join acc in LibraryDbContext.Shared.Accounts
                        on book.OwnerID equals acc.AId into BA_Join
                    from item in BA_Join.DefaultIfEmpty()
                        join house in LibraryDbContext.Shared.BookWareHouses
                        on book.Position equals house.Id into BAH_Join
                    from x in BAH_Join.DefaultIfEmpty()
                        join cate in LibraryDbContext.Shared.Categories
                        on book.CategoryID equals cate.Id into BAHC_Join
                    from record in BAHC_Join.DefaultIfEmpty()
                    select new BookListQueryRecord
                    {
                        book = book,
                        ReaderAccount = item,
                        wareHouse = x,
                        CategoryEntity= record,
                    };
            //Query.Load();//加载到本地
            form_book.DataSource = Query.ToList();
        }

        private void Textbox_ISBN_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == string.Empty) 
            {
                ShowBookList();
                return;
            }

            //Textbox_Bookname.Text = string.Empty;
            ShowBookListByISBN((sender as TextBox).Text);
        }
        private void Textbox_Bookname_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == string.Empty) 
            {
                ShowBookList();
                return; 
            }

            //(sender as TextBox).Text= string.Empty;
            ShowBookListByName((sender as TextBox).Text);
        }

        private void button_dele_Click(object sender, EventArgs e)
        {
            List<Book> books = new List<Book>();
            if (MessageBox.Show($"你确定要删除{form_book.SelectedRows.Count}本书目吗", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                foreach (DataGridViewRow row in form_book.SelectedRows) 
                {
                    if (row.DataBoundItem == null) continue;
                    books.Add((row.DataBoundItem as BookListQueryRecord).book);
                }
                LibraryDbContext.Shared.Books.RemoveRange(books);
                LibraryDbContext.Shared.SaveChanges();
                ShowBookList();
            }
            //LibraryDbContext.Shared.Books.RemoveRange(form_book.SelectedCells.);
        }

        private void ShowBookListByISBN(string ISBN)
        {
            Query = from book in LibraryDbContext.Shared.Books.Where(e=>e.ISBN.Contains(ISBN))
                    join acc in LibraryDbContext.Shared.Accounts
                    on book.OwnerID equals acc.AId into BA_Join
                    from item in BA_Join.DefaultIfEmpty()
                    join house in LibraryDbContext.Shared.BookWareHouses
                    on book.Position equals house.Id into BAH_Join
                    from x in BAH_Join.DefaultIfEmpty()
                    join cate in LibraryDbContext.Shared.Categories
                    on book.CategoryID equals cate.Id into BAHC_Join
                    from record in BAHC_Join.DefaultIfEmpty()
                    select new BookListQueryRecord
                    {
                        book = book,
                        ReaderAccount = item,
                        wareHouse = x,
                        CategoryEntity= record,
                    };
            //Query.Load();//加载到本地
            form_book.DataSource = Query.ToList();
        }

        private void ShowBookListByName(string name)
        {
            Query = from book in LibraryDbContext.Shared.Books.Where(e => e.Name.ToLower().Contains(name.ToLower()))
                    join acc in LibraryDbContext.Shared.Accounts
                    on book.OwnerID equals acc.AId into BA_Join
                    from item in BA_Join.DefaultIfEmpty()
                    join house in LibraryDbContext.Shared.BookWareHouses
                    on book.Position equals house.Id into BAH_Join
                    from x in BAH_Join.DefaultIfEmpty()
                    join cate in LibraryDbContext.Shared.Categories
                    on book.CategoryID equals cate.Id into BAHC_Join
                    from record in BAHC_Join.DefaultIfEmpty()
                    select new BookListQueryRecord
                    {
                        book = book,
                        ReaderAccount = item,
                        wareHouse = x,
                        CategoryEntity= record,
                    };
            //Query.Load();//加载到本地
            form_book.DataSource = Query.ToList();
        }

        private record BookListQueryRecord
        {
            public Book book { get; set; }
            public Account ReaderAccount { get; set; }
            public BookWareHouse wareHouse { get; set; }

            public BookCategory CategoryEntity { get; set; }
            public string BookID => book.BookID;
            public string ISBN => book.ISBN;
            public string Name => book.Name;
            public string Description => book.Description;
            public string Author => book.Author;
            public string Publisher => book.Publisher;
            public string OwnerID => ReaderAccount==null ? "无" : $"{ReaderAccount.ID} | {ReaderAccount.Name}";

            public string BookCategory => CategoryEntity.Name;
            public string CategoryID => CategoryEntity.CategoryID;

            public string Position => wareHouse.Name;
        }
    }
}
