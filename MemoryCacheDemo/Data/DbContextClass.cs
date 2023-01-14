using MemoryCacheDemo.Model;
using Microsoft.EntityFrameworkCore;

namespace MemoryCacheDemo.Data
{
    public class DbContextClass: DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
