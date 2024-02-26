using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore;
using NetCore.Models;
using test;

namespace NetCore
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(
                    "Host=localhost;Port=5432;Database=d20Form;User Id=postgres;Password=8823");
            }
        }

        // DbSet для ваших моделей данных
        public DbSet<Category> Categories { get; set; }
        public DbSet<DpWithoutValue> DpWithoutValues { get; set; }
    }
}