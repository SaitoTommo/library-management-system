using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1
{
    [PrimaryKey("Id")]
    public class Book
    {
        /// <summary>
        /// 资产编号
        /// </summary>
        [Key]
        public int Id { get; set; }

        [ForeignKey("BookInfoId")]
        public BookInfo bookInfo { get; set; }
        [Required]
        public int BookInfoId{ get; set; }

        /// <summary>
        /// 索书号
        /// </summary>
        public string BookID { get; set; }

        /// <summary>
        /// 书库位置 如三楼书库
        /// </summary>
        [ForeignKey("Position")]
        public virtual BookWareHouse BookWareHouse { get; set; } = null!;
        public int Position { get; set; }

        [ForeignKey("OwnerID")]
        public Account Account { get; set; }
        /// <summary>
        /// 借阅人的账号标识
        /// </summary>
        public int? OwnerID { get; set; }


        #region BookInfo
        /*下辈子一定一开始就反复验证怎么建表 = = 
         *打补丁太难受了
         */

        [NotMapped]
        private BookInfo info => LibraryDbContext.Shared.BookInfo.Single(e => e.Id == this.BookInfoId);
        /// <summary>
        /// 不再使用这个属性，如果需要请通过连接bookinfo表获取
        /// </summary>
        [NotMapped]
        public string Name =>info.Name;
        /// <summary>
        /// 不再使用这个属性，如果需要请通过连接bookinfo表获取
        /// </summary>
        [NotMapped]
        public string Author => info.Name;
        /// <summary>
        /// 不再使用这个属性，如果需要请通过连接bookinfo表获取
        /// </summary>
        [NotMapped]
        public string? Description => info.Name;
        [NotMapped]
        /// <summary>
        /// 出版社
        ///         
        /// 不再使用这个属性，如果需要请通过连接bookinfo表获取
        /// 
        /// </summary>
        public string Publisher => info.Name;
        [NotMapped]
        /// <summary>
        /// 《中国图书馆分类法》分类
        /// 
        /// 不再使用这个属性，如果需要请通过连接bookinfo表获取
        /// 
        /// </summary>
        public int CategoryID => info.CategoryID;
        #endregion
    }
}
