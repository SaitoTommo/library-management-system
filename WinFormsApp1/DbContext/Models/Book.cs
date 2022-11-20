﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace WinFormsApp1
{
    public class Book
    {
        /// <summary>
        /// 资产编号
        /// </summary>
        [Key]
        public string BookID { get; set; }
        public string ISBN { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        /// <summary>
        /// 《中国图书馆分类法》分类
        /// </summary>
        [ForeignKey("Category")]
        public BookCategory BookCategory { get; set; }
        public string Category { get; set; }

        /// <summary>
        /// 书库位置 如三楼书库
        /// </summary>
        [ForeignKey("Position")]
        public BookWareHouse BookWareHouse { get; set; }
        public int Position { get; set; }
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
