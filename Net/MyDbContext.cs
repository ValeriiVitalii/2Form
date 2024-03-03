using _Net.Models;
using _Net.Models.Dp;
using Microsoft.EntityFrameworkCore;
using Task = _Net.Models.task.Task;

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
        
        public DbSet<StatusTransition> StatusTransitions { get; set; }
        public DbSet<Task> Tasks { get; set; }

        
        //Связь многие к многим
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Statuses)
                .WithMany(s => s.Categories)
                .UsingEntity(j => j.ToTable("CategoryStatus"));
            
            modelBuilder.Entity<StatusTransition>()
                .HasOne(p => p.Status)
                .WithMany()
                .HasForeignKey(p => p.StatusId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<StatusTransition>()
                .HasOne(p => p.AllowedStatus)
                .WithMany()
                .HasForeignKey(p => p.AllowedStatusId)
                .OnDelete(DeleteBehavior.Restrict);

            // Новая конфигурация для связи StatusTransition с Category
            modelBuilder.Entity<StatusTransition>()
                .HasOne(st => st.Category)
                .WithMany(c => c.AllowedTransitions)
                .HasForeignKey(st => st.CategoryId);
        }
    }
}