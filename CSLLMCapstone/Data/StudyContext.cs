using CSLLMCapstone.Models;
using Microsoft.EntityFrameworkCore;

namespace CSLLMCapstone.Data
{
    public class StudyContext : DbContext
    {
        public StudyContext(DbContextOptions<StudyContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Instance> Instances { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Ensure email is unique
            modelBuilder.Entity<User>()
                .HasIndex(u => u.CwuEmail)
                .IsUnique();
        }
    }
}
