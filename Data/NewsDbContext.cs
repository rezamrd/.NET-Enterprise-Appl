using Lab4v2.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab4v2.Data
{
    public class NewsDbContext : DbContext
    {
        public NewsDbContext(DbContextOptions<NewsDbContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<NewsBoard> NewsBoards { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<NewsBoard>().ToTable("NewsBoard");
            modelBuilder.Entity<Subscription>()
                .HasKey(c => new { c.ClientId, c.NewsBoardId });

        }
    }
}
