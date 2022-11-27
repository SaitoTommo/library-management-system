using Microsoft.EntityFrameworkCore;

using System;
using System.Collections;
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
            dateTimePicker1.Checked= false;
            QueryFlag= false;
        }

        private void button_add1_Click(object sender, EventArgs e)
        {
            new Dialog_Borrowlog1().ShowDialog(this);
            if (QueryFlag)
                form_record.DataSource = SearchQuery.ToList();
            else
                form_record.DataSource = BorrowLogs.ToList();

        }

        private void button_revise1_Click(object sender, EventArgs e)
        {
            BorrowLogQueryRecord _temp;
            foreach (DataGridViewRow r in form_record.SelectedRows)
            {
                _temp = r.DataBoundItem as BorrowLogQueryRecord;

                if (_temp == null) continue;

                new Dialog_Borrowlog1(_temp.log, _temp.AssosiatedAccount, _temp.book).ShowDialog(this);

            }
            if (QueryFlag)
                form_record.DataSource = SearchQuery.ToList();
            else
                form_record.DataSource = BorrowLogs.ToList();
        }

        private async void button_dele1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"你确定要删除\n{form_record.SelectedRows.Count}条记录吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                /* 删除借书记录
                 * 如果该记录为最新的一条且为借出
                 * 则把该书的ownerid删除
                 */
                if (form_record.SelectedRows.Count<=0) return;
                List<BorrowLogQueryRecord> q = null;

                foreach (DataGridViewRow row in form_record.SelectedRows)
                {
                    BorrowLogQueryRecord r = row.DataBoundItem as BorrowLogQueryRecord;
                    if (r.log.ActionType == BookActionType.Borrow
                        && LibraryDbContext.Shared.BorrowLogs.Where(
                            e => e.BookId == r.book.Id
                            && e.BorrowerID == r.AssosiatedAccount.AId).
                            OrderByDescending(e => e.BorrowTime).First() == r.log
                            )
                    {
                        LibraryDbContext.Shared.Books.Single(e => e==r.book).OwnerID = null; //r.book.OwnerID = null;
                    }
                    LibraryDbContext.Shared.BorrowLogs.Remove(r.log);
                }
                await LibraryDbContext.Shared.SaveChangesAsync(); //防止数据过多，采用异步防止线程卡死
                form_record.DataSource= BorrowLogs.ToList();
            }
            else
                return;
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