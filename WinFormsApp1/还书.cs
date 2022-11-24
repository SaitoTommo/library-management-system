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
    public partial class 还书 : Form
    {
        private record ReturnBookQueryRecord
        {
            public Book book { get; set; }
            public BorrowLog log { get; set; }
            public DateTime BorrowTime => log.BorrowTime;
            public string BookName => book.Name;
        }

        IQueryable<ReturnBookQueryRecord> Query;

        public 还书()
        {
            InitializeComponent();
            RefreshQuery();
        }

        public void RefreshQuery()
        {
            Query =
                from books in LibraryDbContext.Shared.Books
                where books.OwnerID == Global.account.AId
                join logs in LibraryDbContext.Shared.BorrowLogs on
                new { BookId = books.Id, id = Global.account.AId } equals new { logs.BookId, id = logs.BorrowerID }
                select new ReturnBookQueryRecord { book = books, log = logs };
            form_record.DataSource = Query.ToList();
        }

        private void 还书_Load(object sender, EventArgs e)
        {
            form_record.AutoGenerateColumns= false;
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
