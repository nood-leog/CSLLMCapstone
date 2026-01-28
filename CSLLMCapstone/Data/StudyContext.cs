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
                new Topic { TopicId = 10, CourseId = 102, Name = "Ethics", TopicDesc = "test desc" },
                new Topic { TopicId = 11, CourseId = 105, Name = "Visual Basics Fundamentals", TopicDesc = "test desc" },
                new Topic { TopicId = 12, CourseId = 105, Name = "Mathematical/Logical Basis of Computing", TopicDesc = "test desc" },
                new Topic { TopicId = 13, CourseId = 105, Name = "Quantitative Reasoning", TopicDesc = "test desc" },
                new Topic { TopicId = 14, CourseId = 105, Name = "Social/Political/Ethical Implications of Technological Advancement", TopicDesc = "test desc" },
                new Topic { TopicId = 15, CourseId = 105, Name = "Data Association Implementing Parallel Mapping", TopicDesc = "test desc" },
                new Topic { TopicId = 16, CourseId = 105, Name = "Computational Thinking", TopicDesc = "test desc" },
                new Topic { TopicId = 17, CourseId = 105, Name = "Algorithm Sequencing", TopicDesc = "test desc" },
                new Topic { TopicId = 18, CourseId = 105, Name = "Integrated Development Environment (IDE) Proficiency", TopicDesc = "test desc" },
                new Topic { TopicId = 19, CourseId = 107, Name = "Unreal Engine Fundamentals and Software Development", TopicDesc = "test desc" },
                new Topic { TopicId = 20, CourseId = 107, Name = "Elements of a Game", TopicDesc = "test desc" },
                new Topic { TopicId = 21, CourseId = 107, Name = "Designing a Game", TopicDesc = "test desc" },
                new Topic { TopicId = 22, CourseId = 107, Name = "Brainstorming", TopicDesc = "test desc" },
                new Topic { TopicId = 23, CourseId = 107, Name = "Narrative and Backstory", TopicDesc = "test desc" },
                new Topic { TopicId = 24, CourseId = 107, Name = "Scenario", TopicDesc = "test desc" },
                new Topic { TopicId = 25, CourseId = 107, Name = "Storyboard and Script", TopicDesc = "test desc" },
                new Topic { TopicId = 26, CourseId = 107, Name = "Usability and Accessibility", TopicDesc = "test desc" },
                new Topic { TopicId = 27, CourseId = 107, Name = "Ethical/Social/Legal Issues in Gaming", TopicDesc = "test desc" },
                new Topic { TopicId = 28, CourseId = 107, Name = "Game-based Learning and Gamification", TopicDesc = "test desc" },
                new Topic { TopicId = 29, CourseId = 107, Name = "Gaming Science", TopicDesc = "test desc" },
                new Topic { TopicId = 30, CourseId = 107, Name = "History in Gaming", TopicDesc = "test desc" },
                new Topic { TopicId = 31, CourseId = 107, Name = "Careers in Gaming", TopicDesc = "test desc" },
                new Topic { TopicId = 32, CourseId = 107, Name = "Future of Gaming", TopicDesc = "test desc" },
                new Topic { TopicId = 33, CourseId = 107, Name = "Rise of Gaming Subcultures", TopicDesc = "test desc" },
                new Topic { TopicId = 34, CourseId = 109, Name = "Python Fundamentals", TopicDesc = "test desc" },
                new Topic { TopicId = 35, CourseId = 109, Name = "Data Visualization", TopicDesc = "test desc" },
                new Topic { TopicId = 36, CourseId = 109, Name = "Classes and OOP", TopicDesc = "test desc" },
                new Topic { TopicId = 37, CourseId = 109, Name = "Stochastic Programs", TopicDesc = "test desc" },
                new Topic { TopicId = 38, CourseId = 109, Name = "Probability and Distributions", TopicDesc = "test desc" },
                new Topic { TopicId = 39, CourseId = 109, Name = "Sampling and Confidence Intervals", TopicDesc = "test desc" },
                new Topic { TopicId = 40, CourseId = 109, Name = "Understanding Experimental Data", TopicDesc = "test desc" },
                new Topic { TopicId = 41, CourseId = 109, Name = "Hypothesis Checking", TopicDesc = "test desc" },
                new Topic { TopicId = 42, CourseId = 109, Name = "Conditional Probability and Bayesian Statistics", TopicDesc = "test desc" },
                new Topic { TopicId = 43, CourseId = 110, Name = "Java Fundamentals", TopicDesc = "test desc" },
                new Topic { TopicId = 44, CourseId = 110, Name = "Decision Structures", TopicDesc = "test desc" },
                new Topic { TopicId = 45, CourseId = 110, Name = "Careers in Gaming", TopicDesc = "test desc" },
                new Topic { TopicId = 46, CourseId = 110, Name = "Repetition", TopicDesc = "test desc" },
                new Topic { TopicId = 47, CourseId = 110, Name = "Methods", TopicDesc = "test desc" },
                new Topic { TopicId = 48, CourseId = 110, Name = "Classes", TopicDesc = "test desc" },
                new Topic { TopicId = 49, CourseId = 110, Name = "Object Oriented Programming", TopicDesc = "test desc" },
                new Topic { TopicId = 50, CourseId = 110, Name = "Arrays and ArrayLists", TopicDesc = "test desc" },
                new Topic { TopicId = 51, CourseId = 111, Name = "Static Fields and Methods", TopicDesc = "test desc" },
                new Topic { TopicId = 52, CourseId = 111, Name = "Returning Objects from Methods", TopicDesc = "test desc" },
                new Topic { TopicId = 53, CourseId = 111, Name = "toString Method", TopicDesc = "test desc" },
                new Topic { TopicId = 54, CourseId = 111, Name = "Comparing Objects", TopicDesc = "test desc" },
                new Topic { TopicId = 55, CourseId = 111, Name = "Aggregation", TopicDesc = "test desc" },
                new Topic { TopicId = 56, CourseId = 111, Name = "Copy Constructor", TopicDesc = "test desc" },
                new Topic { TopicId = 57, CourseId = 111, Name = "Null Reference", TopicDesc = "test desc" },
                new Topic { TopicId = 58, CourseId = 111, Name = "Enums", TopicDesc = "test desc" },
                new Topic { TopicId = 59, CourseId = 111, Name = "StringBuilder", TopicDesc = "test desc" },
                new Topic { TopicId = 60, CourseId = 111, Name = "Tokenizing", TopicDesc = "test desc" },
                new Topic { TopicId = 61, CourseId = 111, Name = "Inheritance", TopicDesc = "test desc" },
                new Topic { TopicId = 62, CourseId = 111, Name = "Superclasses", TopicDesc = "test desc" },
                new Topic { TopicId = 63, CourseId = 111, Name = "Overrriding", TopicDesc = "test desc" },
                new Topic { TopicId = 64, CourseId = 111, Name = "Protected Members", TopicDesc = "test desc" },
                new Topic { TopicId = 65, CourseId = 111, Name = "Chains of Inheritance", TopicDesc = "test desc" },
                new Topic { TopicId = 66, CourseId = 111, Name = "Polymorphism", TopicDesc = "test desc" },
                new Topic { TopicId = 67, CourseId = 111, Name = "Abstract Classes", TopicDesc = "test desc" },
                new Topic { TopicId = 68, CourseId = 111, Name = "Exceptions", TopicDesc = "test desc" },
                new Topic { TopicId = 69, CourseId = 111, Name = "Error Handling", TopicDesc = "test desc" },
                new Topic { TopicId = 70, CourseId = 111, Name = "Advanced File I/O", TopicDesc = "test desc" },
                new Topic { TopicId = 71, CourseId = 111, Name = "Binary Files", TopicDesc = "test desc" },
                new Topic { TopicId = 72, CourseId = 111, Name = "Random Access Files", TopicDesc = "test desc" },
                new Topic { TopicId = 73, CourseId = 111, Name = "Object Serialization", TopicDesc = "test desc" },
                new Topic { TopicId = 74, CourseId = 111, Name = "Binary Search", TopicDesc = "test desc" },
                new Topic { TopicId = 75, CourseId = 111, Name = "Recursion", TopicDesc = "test desc" },
                new Topic { TopicId = 76, CourseId = 111, Name = "GUI Applications", TopicDesc = "test desc" },
                new Topic { TopicId = 77, CourseId = 111, Name = "Action Listeners", TopicDesc = "test desc" },
                new Topic { TopicId = 78, CourseId = 112, Name = "Python Fundamentals", TopicDesc = "test desc" },
                new Topic { TopicId = 79, CourseId = 112, Name = "Troubleshooting and Debugging in Python", TopicDesc = "test desc" },
                new Topic { TopicId = 80, CourseId = 112, Name = "Identifying Data Science Packages in Python", TopicDesc = "test desc" },
                new Topic { TopicId = 81, CourseId = 112, Name = "Foundations of Data Science", TopicDesc = "test desc" },
                new Topic { TopicId = 82, CourseId = 112, Name = "Real-World Data Science Applications", TopicDesc = "test desc" },
                new Topic { TopicId = 83, CourseId = 112, Name = "Python Programming Paradigms for Data Science", TopicDesc = "test desc" },
                new Topic { TopicId = 84, CourseId = 301, Name = "Abstract Data Type (ADT)", TopicDesc = "test desc" },
                new Topic { TopicId = 85, CourseId = 301, Name = "Recursion", TopicDesc = "test desc" },
                new Topic { TopicId = 86, CourseId = 301, Name = "Asymptotic Algorithm Analysis", TopicDesc = "test desc" },
                new Topic { TopicId = 87, CourseId = 301, Name = "Big O Notation", TopicDesc = "test desc" },
                new Topic { TopicId = 88, CourseId = 301, Name = "Lists", TopicDesc = "test desc" },
                new Topic { TopicId = 89, CourseId = 301, Name = "Stack", TopicDesc = "test desc" },
                new Topic { TopicId = 90, CourseId = 301, Name = "Queue", TopicDesc = "test desc" },
                new Topic { TopicId = 91, CourseId = 301, Name = "Linked List", TopicDesc = "test desc" },
                new Topic { TopicId = 92, CourseId = 301, Name = "Tree", TopicDesc = "test desc" },
                new Topic { TopicId = 93, CourseId = 301, Name = "Tree Traversal", TopicDesc = "test desc" },
                new Topic { TopicId = 94, CourseId = 301, Name = "Binary Search Tree (BST)", TopicDesc = "test desc" },
                new Topic { TopicId = 95, CourseId = 301, Name = "BST as Dictionary", TopicDesc = "test desc" },
                new Topic { TopicId = 96, CourseId = 301, Name = "Insertion Sort", TopicDesc = "test desc" },
                new Topic { TopicId = 97, CourseId = 301, Name = "Java Collection Framework", TopicDesc = "test desc" },
                new Topic { TopicId = 98, CourseId = 301, Name = "Unit Testing", TopicDesc = "test desc" },
                new Topic { TopicId = 99, CourseId = 301, Name = "Backtracking", TopicDesc = "test desc" }
            );
        }
    }
}
