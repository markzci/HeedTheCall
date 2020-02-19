using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace HeedTheCall.Entity
{
    public class TrendContext : DbContext
    {
        public DbSet<Trend> Trends { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Trend;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity<Trend>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Url).HasColumnName("url");

                entity.Property(e => e.PromotedContent).HasColumnName("promoted_content");

                entity.Property(e => e.Query).HasColumnName("query");

                entity.Property(e => e.TweetVolume).HasColumnName("tweet_volume");
            });
        }
    }
}