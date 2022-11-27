using Microsoft.VisualBasic.Logging;

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
    public partial class Dialog_Borrowlog1 : Form
    {
        public enum ActionType
        {
            Add,
            Modify,
        }

        private BorrowLog log;

        private Account account = new Account();
        private Account account_New;

        private Book book = new Book();
        private Book book_New;

        private ActionType actionType;

        private List<bookQueryRecord> books;
        private List<Account> accounts;

        //private string BookQueryKeyword = string.Empty;
        //private string AccountQueryKeyword = string.Empty;


        /// <summary>
        /// 修改记录
        /// 
        /// </summary>
        /// <param name="borrowLog"></param>
        /// <param name="account"></param>
        /// <param name="book"></param>
        public Dialog_Borrowlog1(BorrowLog borrowLog, Account account, Book book)
        {
            InitializeComponent();
            this.log = borrowLog;
            this.account = account;
            this.book = book;
            actionType = ActionType.Modify;
        }

        /// <summary>
        /// 增加记录
        /// </summary>
        public Dialog_Borrowlog1()
        {
            InitializeComponent();
            actionType = ActionType.Add;
        }

        private void Dialog_Borrowlog_Load(object sender, EventArgs e)
        {
            dataGridView_AccountInfo.AutoGenerateColumns = false;
            dataGridView_BookInfo.AutoGenerateColumns = false;

            if (actionType == ActionType.Modify)
            {
                this.Text = "修改记录";

                textBox_QueryByBook.Text = book.BookID;
                //BookQueryKeyword = book.BookID;

                textBox_QueryByReader.Text = account.ID;
                //AccountQueryKeyword = textBox_QueryByReader.Text;

                dateTimePicker1.Value = log.BorrowTime;
                comboBox_BookAction.SelectedIndex = (int)log.ActionType;

                //QueryBook(book.BookID);
                //QueryAccount(account.ID);
            }
            else
            {
                dateTimePicker1.Enabled = true;
                comboBox_BookAction.Enabled = true;
                comboBox_BookAction.SelectedIndex = 0;
                this.Text = "增加记录";
            }

            //books = from b in LibraryDbContext.Shared.Books
            //        where (b.Name.ToLower().Contains(BookQueryKeyword.ToLower())
            //        || b.ISBN.Contains(BookQueryKeyword)
            //        || b.Author.ToLower().Contains(BookQueryKeyword.ToLower()))
            //        || b.BookID.ToLower().Contains(BookQueryKeyword.ToLower())
            //        select new bookQueryRecord { book = b };
            //dataGridView_BookInfo.AutoGenerateColumns = false;

            //dataGridView_BookInfo.DataSource = books.ToList();
            //dataGridView_AccountInfo.DataSource= accounts.ToList();
        }

        private void textBox_QueryByBook_TextChanged(object sender, EventArgs e)
        {
            //BookQueryKeyword = textBox_QueryByBook.Text;
            QueryBook(textBox_QueryByBook.Text);
            dataGridView_BookInfo.DataSource = books;
        }

        private void textBox_QueryByReader_TextChanged(object sender, EventArgs e)
        {
            //AccountQueryKeyword= textBox_QueryByReader.Text;
            QueryAccount(textBox_QueryByReader.Text);
            dataGridView_AccountInfo.DataSource = accounts;
        }

        private void dataGridView_BookInfo_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView_BookInfo.CurrentRow != null && (dataGridView_BookInfo.CurrentRow.DataBoundItem as bookQueryRecord).book !=book)
            {
                book_New = (dataGridView_BookInfo.CurrentRow.DataBoundItem as bookQueryRecord).book;
                ShowPreview();
            }
        }

        private void dataGridView_AccountInfo_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView_AccountInfo.CurrentRow != null && (dataGridView_AccountInfo.CurrentRow.DataBoundItem as Account) != account)
            {
                account_New = dataGridView_AccountInfo.CurrentRow.DataBoundItem as Account;
                ShowPreview();
            }
        }

        private void ShowPreview()
        {
            listView_ChangePreview.Items.Clear();
            if (book_New!=null) listView_ChangePreview.Items.Add(new ListViewItem(new string[] { "索书号", book.BookID, book_New.BookID }));
            if (account_New!=null) listView_ChangePreview.Items.Add(new ListViewItem(new string[] { "借阅人学号", account.ID, account_New.ID }));
            listView_ChangePreview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void QueryBook(string BookQueryKeyword)
        {
            books = (from b in LibraryDbContext.Shared.Books join
                     bi in LibraryDbContext.Shared.BookInfo on b.ISBN equals bi.ISBN
                     where (bi.Name.ToLower().Contains(BookQueryKeyword.ToLower())
                     || bi.ISBN.Contains(BookQueryKeyword)
                     || bi.Author.ToLower().Contains(BookQueryKeyword.ToLower()))
                     || b.BookID.ToLower().Contains(BookQueryKeyword.ToLower())
                     select new bookQueryRecord { book = b, bookInfo = bi }).ToList(); ;
            //dataGridView_BookInfo.AutoGenerateColumns = false;
            //dataGridView_BookInfo.DataSource = books.ToList();
        }

        private void QueryAccount(string AccountQueryKeyword)
        {
            accounts = (from a in LibraryDbContext.Shared.Accounts
                        where a.ID.ToLower().Contains(AccountQueryKeyword.ToLower())
                        || a.Name.ToLower().Contains(AccountQueryKeyword.ToLower())
                        select a).ToList();
            //dataGridView_AccountInfo.AutoGenerateColumns = false;
            //dataGridView_AccountInfo.DataSource= accounts.ToList();
        }

        private void button_SaveChange_Click(object sender, EventArgs e)
        {
            if (account_New==null&&book_New==null)
            {
                this.Close();
            }
            try
            {
                if (actionType == ActionType.Modify)
                {
                    if (book_New!=null) log.BookId = book_New.Id;
                    if (account_New!=null) log.BorrowerID = account_New.AId;

                    if (log.ActionType == BookActionType.Borrow) //查找未来的归还记录
                    {
                        var q = from l in LibraryDbContext.Shared.BorrowLogs // 查找过去此书是否已被归还
                                where l.BorrowTime < log.BorrowTime && l.BookId == log.BookId
                                orderby l.ID descending
                                select l;
                        if (q.Count()>0 && q.First().ActionType == BookActionType.Borrow) //如果过去书没被归还
                        {
                            throw new Exception("你的行为会导致记录混乱");//= =
                        }

                        q = from l in LibraryDbContext.Shared.BorrowLogs
                            where l.BorrowTime > log.BorrowTime && l.ActionType != log.ActionType && l.BorrowerID == account.AId && l.BookId == book.Id
                            orderby l.ID
                            select l;

                        var _temp = q.FirstOrDefault();
                        if (_temp != null)
                        {
                            if (MessageBox.Show($"发现{((account_New == null) ? (account.Name) : (account_New.Name))}于{_temp.BorrowTime}归还了{book.Name}，是否连带修改归还记录", "注意", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                if (book_New!=null) _temp.BookId = book_New.Id;
                                if (account_New!=null) _temp.BorrowerID = account_New.AId;
                            }
                        }
                    }
                    else
                    {
                        var q = from l in LibraryDbContext.Shared.BorrowLogs
                                where l.BorrowTime < log.BorrowTime && l.ActionType != log.ActionType && l.BorrowerID == account.AId && l.BookId == book_New.Id
                                orderby l.ID descending
                                select l;// 查找过去的借出记录

                        var _temp = q.FirstOrDefault();
                        if (_temp != null)
                        {
                            if (MessageBox.Show($"发现{((account_New == null) ? (account.Name) : (account_New.Name))}可能于{_temp.BorrowTime}归还了{book.Name}，是否连带修改归还记录", "注意", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                if (book_New!=null) _temp.BookId = book_New.Id;
                                if (account_New!=null) _temp.BorrowerID = account_New.AId;
                            }
                        }
                        else
                        {
                            throw new Exception("你的行为会导致记录混乱");
                            //if (MessageBox.Show("你的行为会导致记录混乱，是否继续？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                            //{
                            //    this.Close();
                            //    return;
                            //}
                        }
                    }
                }
                else //如果行为是增加
                {
                    if (account_New == null || book_New == null)
                    {
                        this.Close();
                        return;
                    }

                    /*
                    *如果增加的为借出  检查之前是否已归还
                    *如果增加的为归还，检查之前是否被同一人借出
                    */
                    var type = (BookActionType)comboBox_BookAction.SelectedIndex;
                    var time = dateTimePicker1.Value;

                    if (type == BookActionType.Borrow)
                    {
                        var q = LibraryDbContext.Shared.BorrowLogs.Where(l => l.BorrowTime < time).OrderByDescending(l=>l.BorrowTime).First();
                        if (q.ActionType == BookActionType.Borrow)
                            throw (new Exception("你的行为会导致记录混乱"));
                        //where l.BorrowTime < time
                        //select l;
                    }
                    else //增加的行为是归还
                    {
                        var q = from l in LibraryDbContext.Shared.BorrowLogs.Where(l=>l.BorrowTime<time)//在之前的记录中查找,这个之前的最新记录应该是书被同一人借出
                                where l.BorrowerID == account_New.AId && l.BookId == book_New.Id
                                orderby l.BorrowTime descending
                                select l;
                        if (q.First() != null && q.First().ActionType != BookActionType.Borrow)
                        {
                            throw (new Exception("你的行为会导致记录混乱"));
                        }
                        else //以前的记录没问题，检查他在未来是不是还了书
                        {
                            q = from l in LibraryDbContext.Shared.BorrowLogs.Where(l => l.BorrowTime > time)//在未来的记录中查找,最旧的一条记录如果是这个人还了书就不行
                                where l.BorrowerID == account_New.AId && l.BookId == book_New.Id
                                orderby l.BorrowTime
                                select l;
                            if(q.First().ActionType == BookActionType.Return)
                                throw (new Exception("你的行为会导致记录混乱"));
                        }
                    }

                    LibraryDbContext.Shared.BorrowLogs.Add(new BorrowLog
                    {
                        BorrowerID = account_New.AId,
                        BookId = book_New.Id,
                        BorrowTime = dateTimePicker1.Value,
                        ActionType = type
                    });
                }
            }
            catch (Exception ee)
            {
                if (ee.Message == "你的行为会导致记录混乱")//= = 不想定义新的错误类型了，度量值已经只剩40多了
                {
                    if (MessageBox.Show("你的行为会导致记录混乱，是否继续？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        this.Close();
                        return;
                    }
                    else 
                    {
                        MessageBox.Show($"{ee.Message}\n{ee.GetType()}");
                    }
                }
            }
            LibraryDbContext.Shared.SaveChanges();
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private record bookQueryRecord
        {
            public Book book { get; set; }
            public BookInfo bookInfo { get; set; }
            //Name = b.Name, ISBN = b.ISBN, BookID = b.BookID, CanBeBorrowed = (b.OwnerID == null)
            public string Name => bookInfo.Name;
            public string ISBN => bookInfo.ISBN;
            public string BookID => book.BookID;
            public bool CanBeBorrowed => (book.OwnerID == null);
        }

    }
}
