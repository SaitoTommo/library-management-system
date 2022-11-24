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
        public winform_BorrowLogManage()
        {
            InitializeComponent();
        }

        private void form_book_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void winform_BorrowLogManage_Load(object sender, EventArgs e)
        {
            //LibraryDbContext.Shared.BorrowLogs.Load();
            //this.borrowLogBindingSource.DataSource = LibraryDbContext.Shared.BorrowLogs.Local.ToBindingList();
            var BorrowLogs = from BLog in LibraryDbContext.Shared.BorrowLogs
                             join book in LibraryDbContext.Shared.Books on BLog.BookId equals book.Id
                             join acc in LibraryDbContext.Shared.Accounts on BLog.BorrowerID equals acc.AId
                             select new { Date = BLog.BorrowTime, BookName = book.Name, BookID = book.BookID, BorrowerName = acc.Name, BorrowerID = acc.ID, ActionType = BLog.ActionType == BookActionType.Borrow ? "借" : "还" };
            //form_record.DataSource = BorrowLogs;
            form_record.DataSource = BorrowLogs.ToList();
            form_record.Columns[0].HeaderText = "日期";
            form_record.Columns[1].HeaderText = "书名";
            form_record.Columns[2].HeaderText = "索书号";
            form_record.Columns[3].HeaderText = "姓名";
            form_record.Columns[4].HeaderText = "学号";
            form_record.Columns[5].HeaderText = "类型";
        }
    }
}