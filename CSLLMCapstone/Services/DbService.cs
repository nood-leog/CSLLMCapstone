using CSLLMCapstone.Data;
using CSLLMCapstone.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace CSLLMCapstone.Services
{
    public class DbService
    {
        private readonly IDbContextFactory<StudyContext> _contextFactory;

        // We use Factory pattern for Blazor Server to avoid threading issues
        public DbService(IDbContextFactory<StudyContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }   

        // --- USER METHODS ---
        public async Task<User?> GetUserByEmailAsync(string email)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Users.FirstOrDefaultAsync(u => u.CwuEmail == email);
        }

        public async Task CreateUserAsync(User newUser)
        {
            using var context = _contextFactory.CreateDbContext();
            context.Users.Add(newUser);
            await context.SaveChangesAsync();
        }

        public async Task AddUserAsync(User newUser)
        {
            using var context = _contextFactory.CreateDbContext();
            context.Users.Add(newUser);
            await context.SaveChangesAsync();
        }

        public async Task<bool> IsEmailRegisteredAsync(string email)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Users.AnyAsync(u => u.CwuEmail == email);
        }

        public async Task<User?> SignInUserAsync(string email, string password)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Users.FirstOrDefaultAsync(u => u.CwuEmail == email && u.Password == password);
        }

        public async Task<bool> IsPasswordSameAsOldAsync(string email, string newPassword)
        {
            using var context = _contextFactory.CreateDbContext();
            var user = await context.Users.FirstOrDefaultAsync(u => u.CwuEmail == email);
            if (user == null)
            {
                return false;
            }
            return user.Password == newPassword;
        }

        public async Task UpdateUserPasswordAsync(string email, string newPassword)
        {
            using var context = _contextFactory.CreateDbContext();
            var user = await context.Users.FirstOrDefaultAsync(u => u.CwuEmail == email);
            if (user != null)
            {
                user.Password = newPassword;
                await context.SaveChangesAsync();
            }
        }

        public async Task<User?> GetUserByIdAsync(int userId)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Users.FirstOrDefaultAsync(u => u.UserId == userId);
        }

        // --- COURSE METHODS ---
        public async Task<List<Course>> GetAllCoursesAsync()
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Courses.Include(c => c.Topics).ToListAsync();
        }

        public async Task AddCourseAsync(Course course)
        {
            using var context = _contextFactory.CreateDbContext();
            context.Courses.Add(course);
            await context.SaveChangesAsync();
        }

        public async Task<string?> GetCourseNameByCourseIdAsync(int courseId)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Courses.Where(t => t.CourseId == courseId).Select(t => t.Title).FirstOrDefaultAsync();
        }

        public async Task<string?> GetCourseDescriptionByCourseIdAsync(int courseId)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Courses.Where(t => t.CourseId == courseId).Select(t => t.CourseDesc).FirstOrDefaultAsync();
        }

        // --- TOPIC METHODS ---
        public async Task<List<string>> GetTopicNamesByCourseIDAsync(int courseId)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Topics.Where(t => t.CourseId == courseId).Select(t => t.Name).ToListAsync();
        }

        public async Task<List<Topic>> GetTopicsByCourseIDAsync(int courseId)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Topics.Where(t => t.CourseId == courseId).ToListAsync();
        }

        // --- INSTANCE/STUDY SESSION METHODS ---
        public async Task SaveInstanceAsync(Instance instance)
        {
            using var context = _contextFactory.CreateDbContext();
            context.Instances.Add(instance);
            await context.SaveChangesAsync();
        }

        public async Task<Instance?> GetInstanceByIdAsync(string instanceId)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Instances
                .Include(i => i.User)
                .FirstOrDefaultAsync(i => i.InstanceId == instanceId);
        }

        public async Task<List<Instance>> GetUserHistoryAsync(int userId)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Instances
                .Where(i => i.UserId == userId)
                .OrderByDescending(i => i.InstanceId)
                .ToListAsync();
        }
    }
}
