using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Book
    {
        /// <summary>
        /// 资产编号
        /// </summary>
        public string AssetID { get; set; }
        public string ISBN { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        /// <summary>
        /// 《中国图书馆分类法》分类
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// 书库位置 如三楼书库
        /// </summary>
        public string Position { get; set; }
        public string Author { get; set; }
        /// <summary>
        /// 出版社
        /// </summary>
        public string Publisher { get; set; }
        /// <summary>
        /// 是否在库
        /// </summary>
        public bool IsInLib { get; set; }
    }
}
