using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    /// <summary>
    /// 借还书的行为类型，借和还
    /// </summary>
    public enum BookActionType 
    {
        Borrow = 0,
        Return = 1
    }
    /// <summary>
    /// 借还书事件记录
    /// </summary>
    public class BorrowLog
    {
        public string ID { get; set; }
        /// <summary>
        /// 借书的人的学号
        /// </summary>
        public string BorrowerID { get; set; }
        public string BookID { get; set; }
        /// <summary>
        /// 借书行为
        /// </summary>
        public BookActionType ActionType { get; set; }
    }
}
