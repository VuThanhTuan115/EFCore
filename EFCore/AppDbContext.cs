using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFCore
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder
        optionsBuilder)
        {
            // Sửa lại Server cho đúng máy của bạn trước khi chạy thử
            optionsBuilder.UseSqlServer(
            "Server=.\\SQLEXPRESS;Database=EFCoreDb;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }
    }
}
