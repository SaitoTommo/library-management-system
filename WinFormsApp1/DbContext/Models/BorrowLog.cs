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
        public string ID { get; set; }

        /// <summary>
        /// 借书的人的账号唯一标识
        /// </summary>
        [ForeignKey("BorrowerID")]
        public Account Account { get; set; }
        public int BorrowerID { get; set; }

        [ForeignKey("BookID")]
        public Book Book { get; set; }
        public int BookID { get; set; }

        /// <summary>
        /// 借书行为
        /// </summary>
        public BookActionType ActionType { get; set; }
    }
}
