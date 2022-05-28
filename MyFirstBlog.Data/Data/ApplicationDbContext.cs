using Microsoft.EntityFrameworkCore;
using MyFirstBlog.Data.Models;

namespace MyFirstBlog.Data.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {

        }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Theme> Themes { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Blog>()
                .HasOne(b => b.Theme)
                .WithMany(t => t.Blogs)
                .HasForeignKey(b => b.ThemeId);

            builder.Entity<Blog>()
                .HasOne(b => b.User)
                .WithMany(u => u.Blogs)
                .HasForeignKey(b => b.UserId);

            builder.Entity<User>()
                .HasMany(u => u.Themes)
                .WithOne(t => t.User)
                .HasForeignKey(t => t.UserId);
        }
    }
}
