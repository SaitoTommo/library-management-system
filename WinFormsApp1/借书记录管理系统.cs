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

        private void Textbox_Querybyname_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == string.Empty)
                form_record.DataSource = BorrowLogs.ToList();
            else
                form_record.DataSource = BorrowLogs.Where(e => e.book.Name.ToLower().Contains(Textbox_Querybyname.Text.ToLower())).ToList();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //BorrowLogs.Load();
            form_record.DataSource= BorrowLogs.ToList().Where(e => e.BorrowTime.Date.Equals(dateTimePicker1.Value.Date));
        }

        private void button_ResetQuery_Click(object sender, EventArgs e)
        {
            form_record.DataSource = BorrowLogs.ToList();
            Textbox_Querybyname.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
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