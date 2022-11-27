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
    public partial class 借书 : Form
    {
        IQueryable<BookQueryRecord> Query;
        public 借书()
        {
            //if(Global.account == null || Global.)
            InitializeComponent();
            //RefreshQuery();
        }

        public void SearchQuery()
        {
            Query = from b in LibraryDbContext.Shared.Books
                    join bi in LibraryDbContext.Shared.BookInfo on b.ISBN equals bi.ISBN
                    join c in LibraryDbContext.Shared.Categories on bi.CategoryID equals c.Id
                    join h in LibraryDbContext.Shared.BookWareHouses on b.Position equals h.Id
                    where bi.Name.ToLower().Contains(textbox_bookqueryword.Text.ToLower())
                    select new BookQueryRecord { book = b, wareHouse = h, bookInfo = bi, bookCategory = c };

            form_books.DataSource = Query.ToList();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            if (textbox_bookqueryword.Text == string.Empty)
                ShowAllBooks();
            else
                SearchQuery();
        }

        private void button_borrow_Click(object sender, EventArgs e)
        {
            var book = ((BookQueryRecord)form_books.CurrentRow.DataBoundItem).book;

            if (book.OwnerID!=null)
            {
                MessageBox.Show("此书已被借出");
                return;
            }

            book.OwnerID = Global.account.AId;

            LibraryDbContext.Shared.BorrowLogs.Add(
            new BorrowLog
            {
                ActionType = BookActionType.Borrow,
                BookId = book.Id,
                BorrowerID = Global.account.AId,
                BorrowTime = DateTime.Now
            });

            LibraryDbContext.Shared.SaveChanges();
            //SearchQuery();
            form_books.Refresh();
        }

        private void 借书_Load(object sender, EventArgs e)
        {
            //直接加载所有书
            form_books.AutoGenerateColumns = false;
            ShowAllBooks();
        }

        private void ShowAllBooks() 
        {
            var q = from b in LibraryDbContext.Shared.Books
                    join bi in LibraryDbContext.Shared.BookInfo on b.ISBN equals bi.ISBN
                    join c in LibraryDbContext.Shared.Categories on bi.CategoryID equals c.Id
                    join h in LibraryDbContext.Shared.BookWareHouses on b.Position equals h.Id
                    select new BookQueryRecord { book = b, wareHouse = h, bookInfo = bi, bookCategory = c };

            form_books.DataSource = q.ToList();
        }

        private record BookQueryRecord
        {
            public Book book { get; set; }
            public BookWareHouse wareHouse { get; set; }
            public BookInfo bookInfo { get; set; }
            public BookCategory bookCategory { get; set; }

            public string BookName => bookInfo.Name;
            public string Author => bookInfo.Author;
            public string Category => bookCategory.CategoryID;
            public string Publisher => bookInfo.Publisher;
            public string ISBN => bookInfo.ISBN;
            public string BookID => book.BookID;
            public string Position => wareHouse.Name;
            public bool CanBeBorrowed => book.OwnerID == null;
        }
    }
}
