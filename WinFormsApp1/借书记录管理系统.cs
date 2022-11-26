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
        IQueryable<BorrowLogQueryRecord> SearchQuery;
        bool QueryFlag;

        public winform_BorrowLogManage()
        {
            InitializeComponent();
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

        private void UnionQuery(object sender, EventArgs e)
        {
            toolStripStatusLabel_LogNumber.Text = "查询中...";
            SearchQuery =
                (
                    from log in BorrowLogs.ToList()
                    where
                    (Textbox_Querybyname.Text == string.Empty || log.BookName.ToLower().Contains(Textbox_Querybyname.Text.ToLower())) &&
                    (!dateTimePicker1.Checked || log.BorrowTime.Date == dateTimePicker1.Value.Date) &&
                    (textBox_QueryByReader.Text == string.Empty || log.AssosiatedAccount.Name.ToLower().Contains(textBox_QueryByReader.Text.ToLower()) || log.AssosiatedAccount.ID.ToLower().Contains(textBox_QueryByReader.Text.ToLower())) &&
                    //(!checkBox_Borrow.Checked || log.log.ActionType == BookActionType.Borrow) || (!checkBox_Return.Checked || log.log.ActionType == BookActionType.Return)
                    ((!checkBox_Borrow.Checked&&!checkBox_Return.Checked)||(checkBox_Borrow.Checked&&checkBox_Return.Checked))||
                    ((!checkBox_Borrow.Checked || log.log.ActionType == BookActionType.Borrow) 
                    && (!checkBox_Return.Checked || log.log.ActionType == BookActionType.Return))
                    select log
                ).AsQueryable();

            form_record.DataSource = SearchQuery.ToList();
            QueryFlag = true;
            toolStripStatusLabel_LogNumber.Text = $"共{SearchQuery.Count()}条记录";

        }

        private void button_ResetQuery_Click(object sender, EventArgs e)
        {
            form_record.DataSource = BorrowLogs.ToList();
            Textbox_Querybyname.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
            QueryFlag= false;
        }

        private void button_add1_Click(object sender, EventArgs e)
        {
            new 
        }

        private void button_dele1_Click(object sender, EventArgs e)
        {

        }

        private void button_revise1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label_search_isbm1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_search1_Click(object sender, EventArgs e)
        {

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