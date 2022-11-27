using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class 还书 : Form
    {

        IQueryable<ReturnBookQueryRecord> Query;

        private record ReturnBookQueryRecord
        {
            public Book book { get; set; }

           // public BookInfo bookInfo { get; set; }
            //public BorrowLog log { get; set; }
            public DateTime BorrowTime { get; set; }// => log.BorrowTime;

            public int LogId { get; set; }

            public string BookName { get; set; }
            public int BookID => book.Id;
        }

        //IQueryable<IGrouping<int, ReturnBookQueryRecord>> Query;
        //List<ReturnBookQueryRecord> returnBookQueryRecords = new List<ReturnBookQueryRecord>();

        public 还书()
        {
            InitializeComponent();
        }

        private void 还书_Load(object sender, EventArgs e)
        {
            var n = LibraryDbContext.Shared.Books.Where(b => b.OwnerID == Global.account.AId).Count();
            if (n == 0)
                return;

            form_record.AutoGenerateColumns= false;
            /* 对应语句
             * select max(l.borrowtime), l.BookId, l.id from borrowlogs l 
             * inner join books b 
             * on l.BookId = b.id and b.ownerid = 2 
             * group by l.bookid
             */

            Query = from b in LibraryDbContext.Shared.Books.Where(e => e.OwnerID == Global.account.AId)
                    join bi in LibraryDbContext.Shared.BookInfo on b.BookInfoId equals bi.Id
                    join l in LibraryDbContext.Shared.BorrowLogs on new { i = b.Id, AI = Global.account.AId, t = BookActionType.Borrow } equals new { i = l.BookId, AI = l.BorrowerID, t = l.ActionType }
                    orderby l.BorrowTime descending
                    group new { bn = bi.Name, li = l.ID, t = l.BorrowTime } by b into g
                    select new ReturnBookQueryRecord { 
                        book = g.Key, 
                        BorrowTime = g.FirstOrDefault().t, 
                        LogId = g.FirstOrDefault().li,//Single(e => e.t == g.Max(f => f.t)).li, 
                        BookName = g.FirstOrDefault().bn//Single(e => e.t == g.Max(f => f.t)).bn 
                    };
            //from book in LibraryDbContext.Shared.Books
            //    join log in LibraryDbContext.Shared.BorrowLogs
            //    on new { id = book.OwnerID, bid = book.Id, type = BookActionType.Borrow }
            //    equals new { id = (int?)Global.account.AId, bid = log.BookId, type = log.ActionType }
            //    join bi in LibraryDbContext.Shared.BookInfo on book.ISBN equals bi.ISBN
            //    group new { id = log.ID, time = log.BorrowTime,name = bi.Name } by book into g
            //    select new ReturnBookQueryRecord {BookName = g.Key , book = g.Key, BorrowTime = g.Max(e => e.BorrowTime), LogId = g.Max(e => e.ID) };

            //if (Query.ToList().Count()<=0) return;
            //.Load();
            form_record.AutoGenerateColumns= false;
            form_record.DataSource = Query.ToList();
        }

        private async void button_back_Click(object sender, EventArgs e)
        {
            if (form_record.SelectedRows.Count<=0) return;
            //MessageBox.Show("Test");
            ReturnBookQueryRecord record;

            if (form_record.SelectedRows.Count>1)
            {
                foreach (DataGridViewRow row in form_record.SelectedRows)
                {
                    record = (ReturnBookQueryRecord)(row.DataBoundItem);
                    record.book.OwnerID = null;
                    LibraryDbContext.Shared.BorrowLogs.Add(new BorrowLog
                    {
                        ActionType = BookActionType.Return,
                        BookId = record.book.Id,
                        BorrowerID = Global.account.AId,
                        BorrowTime = DateTime.Now
                    });
                }
                await LibraryDbContext.Shared.SaveChangesAsync();//await 防止可能出现的大量更改导致卡死
            }
            else
            {
                record = (ReturnBookQueryRecord)form_record.CurrentRow.DataBoundItem;
                record.book.OwnerID = null;
                LibraryDbContext.Shared.BorrowLogs.Add(new BorrowLog
                {
                    ActionType = BookActionType.Return,
                    BookId = record.book.Id,
                    BorrowerID = Global.account.AId,
                    BorrowTime = DateTime.Now
                });
                LibraryDbContext.Shared.SaveChanges();
            }

            form_record.DataSource = Query.ToList();
        }


    }
}
