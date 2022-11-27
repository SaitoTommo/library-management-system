using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyModel;

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
        IQueryable<BookListQueryRecord> SearchQuery;

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
            Query = from b in LibraryDbContext.Shared.Books
                    join a in LibraryDbContext.Shared.Accounts on b.OwnerID equals a.AId into ba_join
                    from baj in ba_join.DefaultIfEmpty()
                    join h in LibraryDbContext.Shared.BookWareHouses on b.Position equals h.Id
                    join bi in LibraryDbContext.Shared.BookInfo on b.BookInfoId equals bi.Id
                    join c in LibraryDbContext.Shared.Categories on bi.CategoryID equals c.Id
                    select new BookListQueryRecord { book = b, CategoryEntity = c, ReaderAccount = baj, bookInfo = bi, wareHouse = h };
            //from book in LibraryDbContext.Shared.Books
            //        join acc in LibraryDbContext.Shared.Accounts
            //        on book.OwnerID equals acc.AId into BA_Join
            //    from item in BA_Join.DefaultIfEmpty()
            //        join house in LibraryDbContext.Shared.BookWareHouses
            //        on book.Position equals house.Id into BAH_Join
            //    from x in BAH_Join.DefaultIfEmpty()
            //        join cate in LibraryDbContext.Shared.Categories
            //        on book.CategoryID equals cate.Id into BAHC_Join
            //    from record in BAHC_Join.DefaultIfEmpty()
            //    select new BookListQueryRecord
            //    {
            //        book = book,
            //        ReaderAccount = item,
            //        wareHouse = x,
            //        CategoryEntity= record,
            //    };
            //Query.Load();//加载到本地
            form_book.DataSource = Query.ToList();
        }

        private void Textbox_Bookname_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == string.Empty)
            {
                ShowBookList();
                return;
            }

            //(sender as TextBox).Text= string.Empty;
            SearchBookList((sender as TextBox).Text);
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



        private void SearchBookList(string name)
        {
            var q = from r in Query.ToList()
                    where r.Name.ToLower().Contains(name.ToLower()) || r.ISBN.ToLower().Contains(name.ToLower()) 
                    || r.Author.ToLower().Contains(name.ToLower()) || r.Publisher.StartsWith(name.ToLower())
                    || r.OwnerID.ToLower().Contains(name.ToLower())
                    select r;
            form_book.DataSource = q.ToList();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            new Dialog_BookModify().ShowDialog(this);
            ShowBookList();
        }

        private void button_revise_Click(object sender, EventArgs e)
        {
            var a = new BookListQueryRecord();
            foreach (DataGridViewRow row in form_book.SelectedRows)
            {
                a = row.DataBoundItem as BookListQueryRecord;
                new Dialog_BookModify(a.book, a.bookInfo, a.CategoryEntity, a.wareHouse).ShowDialog(this);
            }
            ShowBookList();
        }

        private record BookListQueryRecord
        {
            public Book book { get; set; }
            public Account ReaderAccount { get; set; }
            public BookWareHouse wareHouse { get; set; }
            public BookInfo bookInfo { get; set; }
            public BookCategory CategoryEntity { get; set; }
            public string BookID => book.BookID;
            public string ISBN => bookInfo.ISBN;
            public string Name => bookInfo.Name;
            public string Description => bookInfo.Description;
            public string Author => bookInfo.Author;
            public string Publisher => bookInfo.Publisher;
            public string OwnerID => ReaderAccount==null ? "无" : $"{ReaderAccount.ID} | {ReaderAccount.Name}";

            public string BookCategory => CategoryEntity.Name;
            public string CategoryID => CategoryEntity.CategoryID;

            public string Position => wareHouse.Name;
        }
    }
}
