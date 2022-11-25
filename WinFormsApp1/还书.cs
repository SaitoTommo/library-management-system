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
        private record ReturnBookQueryRecord
        {
            public Book book { get; set; }
            //public BorrowLog log { get; set; }
            public DateTime BorrowTime { get; set; }// => log.BorrowTime;

            public int LogId { get; set; }

            public string BookName => book.Name;
            public int BookID => book.Id;
        }

        //IQueryable<IGrouping<int, ReturnBookQueryRecord>> Query;
        //List<ReturnBookQueryRecord> returnBookQueryRecords = new List<ReturnBookQueryRecord>();

        public 还书()
        {
            InitializeComponent();
        }

        public void RefreshQuery()
        {
            //returnBookQueryRecords.Clear();

            /* 对应语句
             * select max(l.borrowtime), l.BookId, l.id from borrowlogs l 
             * inner join books b 
             * on l.BookId = b.id and b.ownerid = 2 
             * group by l.bookid
             */

            var Query = from book in LibraryDbContext.Shared.Books
                        join log in LibraryDbContext.Shared.BorrowLogs
                        on new { id = book.OwnerID, bid = book.Id, type = BookActionType.Borrow }
                        equals new { id = (int?)Global.account.AId, bid = log.BookId, type = log.ActionType }
                        group new { log.ID, log.BorrowTime } by book into g
                        select new ReturnBookQueryRecord { book = g.Key, BorrowTime = g.Max(e => e.BorrowTime), LogId = g.Max(e => e.ID) };

            //if (Query.ToList().Count()<=0) return;

            form_record.AutoGenerateColumns= false;
            form_record.DataSource = Query.ToList();
        }

        private void 还书_Load(object sender, EventArgs e)
        {
            var n = LibraryDbContext.Shared.Books.Where(b => b.OwnerID == Global.account.AId).Count();
            if (n == 0)
                return;

            form_record.AutoGenerateColumns= false;
            RefreshQuery();
        }

        private async void button_back_Click(object sender, EventArgs e)
        {
            if (form_record.SelectedCells.Count<=0) return;
            //MessageBox.Show("Test");
            ReturnBookQueryRecord record;

            if (form_record.SelectedCells.Count>1)
            {
                foreach (DataGridViewCell cell in form_record.SelectedCells)
                {
                    record = (ReturnBookQueryRecord)(cell.OwningRow.DataBoundItem);
                    record.book.OwnerID = null;
                    LibraryDbContext.Shared.BorrowLogs.Add(new BorrowLog
                    {
                        ActionType = BookActionType.Return,
                        BookId = record.book.Id,
                        ID = Global.account.AId,
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

            RefreshQuery();
        }


    }
}
