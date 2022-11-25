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
    public partial class winform_BorrowLogManage : Form
    {
        IQueryable<BorrowLogQueryRecord> BorrowLogs;
        public winform_BorrowLogManage()
        {
            InitializeComponent();
        }

        private void form_book_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void winform_BorrowLogManage_Load(object sender, EventArgs e)
        {
            form_record.AutoGenerateColumns= false;
            //LibraryDbContext.Shared.BorrowLogs.Load();
            //this.borrowLogBindingSource.DataSource = LibraryDbContext.Shared.BorrowLogs.Local.ToBindingList();
            BorrowLogs = from BLog in LibraryDbContext.Shared.BorrowLogs
                         join book in LibraryDbContext.Shared.Books on BLog.BookId equals book.Id
                         join acc in LibraryDbContext.Shared.Accounts on BLog.BorrowerID equals acc.AId
                         select new BorrowLogQueryRecord { log = BLog, book = book, AssosiatedAccount = acc };
            //form_record.DataSource = BorrowLogs;
            form_record.DataSource = BorrowLogs.ToList();
        }

        private record BorrowLogQueryRecord
        {
            public BorrowLog log { get; set; }
            public Account AssosiatedAccount { get; set; }
            public Book book { get; set; }

            public DateTime BorrowTime => log.BorrowTime;
            public string Reader => $"{AssosiatedAccount.ID} | {AssosiatedAccount.Name}";
            public string ActionType => log.ActionType == BookActionType.Borrow ? "借出" : "归还";
            public string BookName => book.Name;
            public string BookID => book.BookID;
        }
    }
}