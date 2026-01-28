using CSLLMCapstone.Models;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

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

            // Add the seed data for Courses
            modelBuilder.Entity<Course>().HasData(
                new Course { CourseId = 102, Title = "Health and Technology", CourseDesc = "test desc" },
                new Course { CourseId = 105, Title = "The Logical Basis of Computing", CourseDesc = "test desc" },
                new Course { CourseId = 107, Title = "Make a Game with Computer Science", CourseDesc = "test desc" },
                new Course { CourseId = 109, Title = "Quantitative Reasoning Using Python", CourseDesc = "test desc" },
                new Course { CourseId = 110, Title = "Programming Fundamentals I", CourseDesc = "test desc" },
                new Course { CourseId = 111, Title = "Programming Fundamentals II", CourseDesc = "test desc" },
                new Course { CourseId = 112, Title = "Introduction to Data Science in Python", CourseDesc = "test desc" },
                new Course { CourseId = 301, Title = "Data Structures", CourseDesc = "test desc" },
                new Course { CourseId = 302, Title = "Advanced Data Structures and File Processing", CourseDesc = "test desc" },
                new Course { CourseId = 311, Title = "Computer Architecture I", CourseDesc = "test desc" },
                new Course { CourseId = 312, Title = "Computer Architecture II", CourseDesc = "test desc" },
                new Course { CourseId = 325, Title = "Technical Writing in Computer Science", CourseDesc = "test desc" },
                new Course { CourseId = 351, Title = "Web Development Technologies II", CourseDesc = "test desc" },
                new Course { CourseId = 361, Title = "Principles of Language Design I", CourseDesc = "test desc" },
                new Course { CourseId = 362, Title = "Principles of Language Design II", CourseDesc = "test desc" },
                new Course { CourseId = 367, Title = "Advanced Visual Basic Programming", CourseDesc = "test desc" },
                new Course { CourseId = 370, Title = "Introduction to Linux", CourseDesc = "test desc" },
                new Course { CourseId = 380, Title = "Introduction to Software Engineering", CourseDesc = "test desc" },
                new Course { CourseId = 420, Title = "Database Management Systems", CourseDesc = "test desc" },
                new Course { CourseId = 427, Title = "Algorithm Analysis", CourseDesc = "test desc" },
                new Course { CourseId = 428, Title = "Introduction to Graph Algorithm", CourseDesc = "test desc" },
                new Course { CourseId = 430, Title = "Cybersecurity", CourseDesc = "test desc" },
                new Course { CourseId = 440, Title = "Computer Graphics", CourseDesc = "test desc" },
                new Course { CourseId = 445, Title = "Data and Information Visualization", CourseDesc = "test desc" },
                new Course { CourseId = 446, Title = "User Interface Design and Development", CourseDesc = "test desc" },
                new Course { CourseId = 450, Title = "Computer Network and Data Communications", CourseDesc = "test desc" },
                new Course { CourseId = 452, Title = "Ethical Hacking and Penetration Testing for Computer Science", CourseDesc = "test desc" },
                new Course { CourseId = 456, Title = "Data Mining", CourseDesc = "test desc" },
                new Course { CourseId = 457, Title = "Computational Intelligence and Machine Learning", CourseDesc = "test desc" },
                new Course { CourseId = 460, Title = "Software Engineering for Mobile Devices", CourseDesc = "test desc" },
                new Course { CourseId = 465, Title = "Scientific Computing", CourseDesc = "test desc" },
                new Course { CourseId = 466, Title = "Virtual Reality", CourseDesc = "test desc" },
                new Course { CourseId = 467, Title = "Computational Statistics", CourseDesc = "test desc" },
                new Course { CourseId = 470, Title = "Operating Systems", CourseDesc = "test desc" },
                new Course { CourseId = 471, Title = "Optimization", CourseDesc = "test desc" },
                new Course { CourseId = 473, Title = "Parallel Computing", CourseDesc = "test desc" },
                new Course { CourseId = 480, Title = "Advanced Software Engineering", CourseDesc = "test desc" },
                new Course { CourseId = 481, Title = "Capstone Project", CourseDesc = "test desc" },
                new Course { CourseId = 489, Title = "Senior Colloquium", CourseDesc = "test desc" }
            );

            // Add the seed data for Topics that reference the Courses
            modelBuilder.Entity<Topic>().HasData(
                new Topic { TopicId = 1, CourseId = 102, Name = "Big Tech", TopicDesc = "test desc" },
                new Topic { TopicId = 2, CourseId = 102, Name = "Video Games", TopicDesc = "test desc" },
                new Topic { TopicId = 3, CourseId = 102, Name = "Telemedicine", TopicDesc = "test desc" },
                new Topic { TopicId = 4, CourseId = 102, Name = "AI", TopicDesc = "test desc" },
                new Topic { TopicId = 5, CourseId = 102, Name = "Robotis", TopicDesc = "test desc" },
                new Topic { TopicId = 6, CourseId = 102, Name = "Deep Web", TopicDesc = "test desc" },
                new Topic { TopicId = 7, CourseId = 102, Name = "VR", TopicDesc = "test desc" },
                new Topic { TopicId = 8, CourseId = 102, Name = "Music Technology", TopicDesc = "test desc" },
                new Topic { TopicId = 9, CourseId = 102, Name = "Wearables", TopicDesc = "test desc" },
                new Topic { TopicId = 10, CourseId = 102, Name = "Ethics", TopicDesc = "test desc" }
            );
        }
    }
}
