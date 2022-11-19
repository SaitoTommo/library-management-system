using System;
using System.Collections.Generic;
using System.Linq;
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
        public DbSet<Book> Books { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<BookCategory> Categories { get; set; }
        public DbSet<BorrowLog> BorrowLogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=Database/products.db");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    AssetID = Random.Shared.Next(1, 9999).ToString(),
                    Author = "UnKnown",
                    Category = "A1",
                    Description = "Unknown",
                    ISBN = Random.Shared.Next(1000000, 9999999).ToString(),
                    IsInLib = true,
                    Name = $"Book{Random.Shared.Next(1, 9999)}",
                    Position = "一楼书库",
                    Publisher = "华南理工大学出版社"
                },
                new Book
                {
                    AssetID = Random.Shared.Next(1, 9999).ToString(),
                    Author = "UnKnown",
                    Category = "A1",
                    Description = "Unknown",
                    ISBN = Random.Shared.Next(1000000, 9999999).ToString(),
                    IsInLib = true,
                    Name = $"Book{Random.Shared.Next(1, 9999)}",
                    Position = "一楼书库",
                    Publisher = "华南理工大学出版社"
                }
            );
            modelBuilder.Entity<BookCategory>().HasData(
                new BookCategory {  ID = "A1", Name = "马克思、恩格斯著作" }
            );
            modelBuilder.Entity<Account>().HasData(
                new Account { ID = "1", Gender = "男", Name = "阿塔尼斯", RegisterDate = new DateTime(2022,1,1), Role = 0 },
                new Account { ID = "2", Gender = "女", Name = "塞兰迪斯", RegisterDate = new DateTime(2022, 1, 1), Role = 1 }
            );
        }
    }
}
