namespace LotoApp.DataAccess
{
    using LotoApp.Domain.Models;
    using Microsoft.EntityFrameworkCore;
    public class LotoAppDbContext : DbContext
    {
        public LotoAppDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .Property(x => x.FirstName)
                .HasMaxLength(30);

            modelBuilder.Entity<User>() 
                .Property(x => x.LastName)
                .HasMaxLength(30);

            modelBuilder.Entity<User>()
                .Property(x => x.Username)
                .HasMaxLength(30);

            modelBuilder.Entity<User>()
                .HasIndex(x => x.Username)
                .IsUnique();

            modelBuilder.Entity<User>()
                .Property(x => x.Password)
                .HasMaxLength(30);
        }
    }
}
