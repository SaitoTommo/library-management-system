using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1
{
    /// <summary>
    /// 数据库内容
    /// </summary>
    public class LibraryDbContext : DbContext
    {
        /// <summary>
        /// 共享数据库上下文实例，使用前需要先调用SetSharedInstance方法
        /// </summary>
        public static LibraryDbContext Shared
        {
            get
            {
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }
        private static LibraryDbContext _instance;//shared属性对应的实体

        /// <summary>
        /// 设置共享数据库上下文的Connectionstring
        /// </summary>
        /// <param name="ConnectionString"></param>
        /// <returns>返回shared对象</returns>
        public static LibraryDbContext SetSharedInstance(string ConnectionString)
        {
            _instance = new LibraryDbContext(ConnectionString);

            return _instance;
        }

        public LibraryDbContext(string ConnectionString)
        {
            if (ConnectionString == null || ConnectionString == string.Empty)
                throw new ArgumentNullException("ConnectionString", "ConnectionString不能为空");

            this._ConnectionString = ConnectionString;
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<BookCategory> Categories { get; set; }
        public DbSet<BorrowLog> BorrowLogs { get; set; }
        public DbSet<BookWareHouse> BookWareHouses { get; set; }
        public DbSet<BookInfo> BookInfo { get; set; }

        private readonly string _ConnectionString = string.Empty;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite(_ConnectionString);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region 种子数据
            modelBuilder.Entity<BookWareHouse>().HasData(
                new BookWareHouse { Id = 1, Name = "一楼书库" },
                new BookWareHouse { Id = 2, Name = "二楼书库" }
            );
            modelBuilder.Entity<BookCategory>().HasData(
                new BookCategory { Id = 1, CategoryID = "A1", Name = "马克思、恩格斯著作" },
                new BookCategory { Id = 2, CategoryID = "A2", Name = "列宁著作" }
            );
            modelBuilder.Entity<BookInfo>().HasData(
                new BookInfo { 
                    Id = 1,
                    ISBN = "978-7-01-018150-9", 
                    Name = "列宁全集. 第十四卷. 第2版", 
                    Description = null, 
                    Author = "列宁", 
                    CategoryID = 2, 
                    Publisher = "北京:人民出版社,2013-2017" 
                },
                new BookInfo { 
                    Id = 2,
                    ISBN = "978-7-5117-3201-9", 
                    Name = "共产党宣言", 
                    Description = "《共产党宣言》是马克思和恩格斯为世界上第一个共产党组织——共产主义者同盟撰写的纲领。《共产党宣言》是科学社会主义的最伟大的纲领性文献，它的问世标志着马克思主义的诞生。" ,
                    CategoryID = 1,
                    Author = "马克思，恩格斯",
                    Publisher = "北京:中央编译出版社,[2017.04]"
                },//怎么还会有地方在用10位的旧格式的ISBN的 = =
                new BookInfo { 
                    Id = 3,
                    ISBN = "7-01-000386-6" ,
                    Name = "列宁全集. 第五十八卷, 《马克思和恩格斯通信集(1844～1883年)》提要 : 1913年10～12月. 第2版",
                    Description = null,
                    Author = "(苏) 列宁",
                    CategoryID = 2,
                    Publisher = "北京:人民出版社,1990"//原来是老书啊= =，还好没给ISBN做整数型
                }
            );
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, BookInfoId = 3, BookID = "A2/1", Position = 1 },
                new Book { Id = 2, BookInfoId = 3, BookID = "A2/2", Position = 1 },
                new Book { Id = 3, BookInfoId = 3, BookID = "A2/3", Position = 1 },
                new Book { Id = 4, BookInfoId = 1, BookID = "A2/4", Position = 2 },
                new Book { Id = 5, BookInfoId = 1, BookID = "A2/5", Position = 2 },
                new Book { Id = 6, BookInfoId = 1, BookID = "A2/6", Position = 2 },
                new Book { Id = 7, BookInfoId = 2, BookID = "A1/1", Position = 2 },
                new Book { Id = 8, BookInfoId = 2, BookID = "A1/2", Position = 2 },
                new Book { Id = 9, BookInfoId = 2, BookID = "A1/3", Position = 2 }
            );

            modelBuilder.Entity<Account>().HasData(
                new Account { AId = 1, ID = "1", Gender = "男", Name = "阿塔尼斯", RegisterDate = new DateTime(2022, 1, 1), Role = AccountRole.Admin, Password = Encryptor.SHA256Encrypt("123456X") },
                new Account { AId = 2, ID = "2", Gender = "女", Name = "塞兰迪斯", RegisterDate = new DateTime(2022, 1, 1), Role = AccountRole.Student, Password = Encryptor.SHA256Encrypt("123456X") },
                new Account { AId = 3, ID = "3", Gender = "男", Name = "泽拉图", RegisterDate = new DateTime(2022, 1, 1), Role = AccountRole.Student, Password = Encryptor.SHA256Encrypt("123456X") }

                );
            modelBuilder.Entity<BorrowLog>().HasData(
                new BorrowLog { ID = 1, BookId = 1, BorrowerID = 1, BorrowTime = DateTime.Now, ActionType = BookActionType.Borrow },
                new BorrowLog { ID = 2, BookId = 1, BorrowerID = 1, BorrowTime = DateTime.Now, ActionType = BookActionType.Return }
            );
            #endregion
        }
    }
}
