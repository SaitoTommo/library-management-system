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

        private readonly string _ConnectionString = string.Empty;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite(_ConnectionString);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region 种子数据
            modelBuilder.Entity<BookWareHouse>().HasData(
                new BookWareHouse { Id = 1, Name = "一楼书库" }
            );
            modelBuilder.Entity<BookCategory>().HasData(
                new BookCategory { Id = 1, CategoryID = "A1", Name = "马克思、恩格斯著作" },
                new BookCategory { Id = 2, CategoryID = "A2", Name = "列宁著作" }
            );
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    BookID = Random.Shared.Next(1, 9999).ToString(),
                    Author = "UnKnown",
                    CategoryID = 1,
                    Description = "Unknown",
                    ISBN = Random.Shared.Next(1000000, 9999999).ToString(),
                    IsInLib = true,
                    Name = $"Book{Random.Shared.Next(1, 9999)}",
                    Position = 1,
                    Publisher = "华南理工大学出版社"
                },
                new Book
                {
                    Id = 2,
                    BookID = Random.Shared.Next(1, 9999).ToString(),
                    Author = "UnKnown",
                    CategoryID = 1,
                    Description = "Unknown",
                    ISBN = Random.Shared.Next(1000000, 9999999).ToString(),
                    IsInLib = true,
                    Name = $"Book{Random.Shared.Next(1, 9999)}",
                    Position = 1,
                    Publisher = "华南理工大学出版社"
                },
                new Book
                {
                    Id = 3,
                    BookID = Random.Shared.Next(1, 9999).ToString(),
                    Author = "UnKnown",
                    CategoryID = 2,
                    Description = "Unknown",
                    ISBN = Random.Shared.Next(1000000, 9999999).ToString(),
                    IsInLib = true,
                    Name = $"Book{Random.Shared.Next(1, 9999)}",
                    Position = 1,
                    Publisher = "华南理工大学出版社"
                }
            );
            modelBuilder.Entity<Account>().HasData(
                new Account { AId = 1, ID = "1", Gender = "男", Name = "阿塔尼斯", RegisterDate = new DateTime(2022, 1, 1), Role = 0, Password = Encryptor.SHA256Encrypt("123456X") },
                new Account { AId = 2, ID = "2", Gender = "女", Name = "塞兰迪斯", RegisterDate = new DateTime(2022, 1, 1), Role = 1, Password = Encryptor.SHA256Encrypt("123456X") }
            );
            #endregion
        }
    }
}
