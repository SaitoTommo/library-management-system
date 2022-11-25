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
                    join c in LibraryDbContext.Shared.Categories on b.CategoryID equals c.Id
                    join h in LibraryDbContext.Shared.BookWareHouses on b.Position equals h.Id
                    where b.Name.ToLower().Contains(textbox_bookqueryword.Text.ToLower())
                    select new BookQueryRecord { book = b, wareHouse = h };

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
                    join h in LibraryDbContext.Shared.BookWareHouses
                    on b.Position equals h.Id
                    select new BookQueryRecord { book = b, wareHouse = h };

            form_books.DataSource = q.ToList();
        }

        private record BookQueryRecord
        {
            public Book book { get; set; }
            public BookWareHouse wareHouse { get; set; }

            public string BookName => book.Name;
            public string Author => book.Author;
            public string Category => LibraryDbContext.Shared.Categories.Single(c => c.Id == book.CategoryID).Name;
            public string Publisher => book.Publisher;
            public string ISBN => book.ISBN;
            public string BookID => book.BookID;
            public string Position => wareHouse.Name;
            public bool CanBeBorrowed => book.OwnerID == null;
        }
    }
}
