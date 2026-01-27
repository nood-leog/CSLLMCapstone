using CSLLMCapstone.Data;
using CSLLMCapstone.Models;
using Microsoft.EntityFrameworkCore;

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

        // --- COURSE METHODS ---
        public async Task<List<Course>> GetAllCoursesAsync()
        {
            using var context = _contextFactory.CreateDbContext();
            // Include Topics so we get the nested data
            return await context.Courses.Include(c => c.Topics).ToListAsync();
        }

        public async Task AddCourseAsync(Course course)
        {
            using var context = _contextFactory.CreateDbContext();
            context.Courses.Add(course);
            await context.SaveChangesAsync();
        }

        // --- INSTANCE/STUDY SESSION METHODS ---
        public async Task SaveInstanceAsync(Instance instance)
        {
            using var context = _contextFactory.CreateDbContext();
            context.Instances.Add(instance);
            await context.SaveChangesAsync();
        }

        public async Task<List<Instance>> GetUserHistoryAsync(int userId)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Instances
                .Where(i => i.UserId == userId)
                .OrderByDescending(i => i.InstanceId) // Or add a CreatedAt date
                .ToListAsync();
        }
    }
}
