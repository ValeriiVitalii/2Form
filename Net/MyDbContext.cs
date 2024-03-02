using _Net.Models;
using _Net.Models.Dp;
using Microsoft.EntityFrameworkCore;

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

        // DbSet моделей данных
        public DbSet<Category> Categories { get; set; }
        public DbSet<Dp> Dp { get; set; }

        public DbSet<Status> Status { get; set; }

        
        //Связь многие к многим
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Statuses)
                .WithMany(s => s.Categories)
                .UsingEntity(j => j.ToTable("CategoryStatus"));
        }
    }
}