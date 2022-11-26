using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        
        [Key]
        [Required]
        public int ID { get; set; }

        [ForeignKey("BorrowerID")]
        public Account Account { get; set; }
        /// <summary>
        /// 借书的人的账号唯一标识
        /// </summary>
        public int BorrowerID { get; set; }

        [ForeignKey("BookId")]
        public Book Book { get; set; }
        /// <summary>
        /// 书唯一标识
        /// </summary>
        public int BookId { get; set; }
        /// <summary>
        /// 借书时间
        /// </summary>
        public DateTime BorrowTime { get; set; }
        /// <summary>
        /// 借书行为
        /// </summary>
        public BookActionType ActionType { get; set; }
    }
}
