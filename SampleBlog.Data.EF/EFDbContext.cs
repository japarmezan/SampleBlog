using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SampleBlog.Domain;

namespace SampleBlog.Data.EF
{
    public class EFDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server=.\SQLEXPRESS; Database=SampleBlog; Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<SamuraiBattle>().HasKey(s => new { s.BattleId, s.SamuraiId });
            //modelBuilder.Entity<Samurai>().Property(s => s.SecretIdentity).IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
}
