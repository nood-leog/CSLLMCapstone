using CSLLMCapstone.Data;
using CSLLMCapstone.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using Microsoft.AspNetCore.Identity;

namespace CSLLMCapstone.Services
{
    public class DbService
    {
        private readonly IDbContextFactory<StudyContext> _contextFactory;
        private readonly PasswordHasher<User> _passwordHasher = new(); // Initialize the hasher

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

        public async Task<User?> GetUserByIdAsync(int userId)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Users.FirstOrDefaultAsync(u => u.UserId == userId);
        }

        public async Task CreateUserAsync(User newUser)
        {
            using var context = _contextFactory.CreateDbContext();
            // HASH THE PASSWORD BEFORE SAVING
            newUser.Password = _passwordHasher.HashPassword(newUser, newUser.Password);
            context.Users.Add(newUser);
            await context.SaveChangesAsync();
        }

        public async Task<bool> IsEmailRegisteredAsync(string email)
        {
            using var context = _contextFactory.CreateDbContext();
            // returns true if a user exists with that email, false otherwise
            return await context.Users.AnyAsync(u => u.CwuEmail == email);
        }

        public async Task<User?> SignInUserAsync(string email, string password)
        {
            using var context = _contextFactory.CreateDbContext();

            // 1. Await the database call and find by email ONLY
            var user = await context.Users.FirstOrDefaultAsync(u => u.CwuEmail == email);

            // 2. If no user found, return null
            if (user == null) return null;

            // 3. Verify the plain-text 'password' against the stored 'user.Password' (the hash)
            var result = _passwordHasher.VerifyHashedPassword(user, user.Password, password);

            // 4. Return user if success, otherwise null
            return result == PasswordVerificationResult.Success ? user : null;
        }

        public async Task<bool> IsPasswordSameAsOldAsync(string email, string newPassword)
        {
            using var context = _contextFactory.CreateDbContext();
            var user = await context.Users.FirstOrDefaultAsync(u => u.CwuEmail == email);
            if (user == null)
            {
                return false;
            }

            // Use the hasher to compare the new plain-text password with the stored hash
            var result = _passwordHasher.VerifyHashedPassword(user, user.Password, newPassword);
            return result == PasswordVerificationResult.Success;
        }

        public async Task UpdateUserPasswordAsync(string email, string newPassword)
        {
            using var context = _contextFactory.CreateDbContext();
            var user = await context.Users.FirstOrDefaultAsync(u => u.CwuEmail == email);
            if (user != null)
            {
                user.Password = newPassword;
                // HASH THE NEW PASSWORD
                user.Password = _passwordHasher.HashPassword(user, newPassword);
                await context.SaveChangesAsync();
            }
        }

        // --- COURSE METHODS ---
        public async Task<List<Course>> GetAllCoursesAsync()
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Courses
                .Include(c => c.Topics)
                .ToListAsync();
        }

        //public async Task<List<Course>> GetAllCoursesAsync()
        //{
        //    using var context = _contextFactory.CreateDbContext();
        //    // Include Topics so we get the nested data
        //    return await context.Courses.Include(c => c.Topics).ToListAsync();
        //}

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

        public async Task<Course?> GetCourseByIdAsync(int courseId)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Courses
                .Include(c => c.Topics)
                .FirstOrDefaultAsync(c => c.CourseId == courseId);
        }

        public async Task<string?> GetCourseDescriptionByCourseIdAsync(int courseId)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Courses.Where(t => t.CourseId == courseId).Select(t => t.CourseDesc).FirstOrDefaultAsync();
        }

        // --- TOPIC METHODS ---

        public async Task<List<Topic>> GetTopicsByCourseIDAsync(int courseId)
        {
            using var context = _contextFactory.CreateDbContext();
            // takes courseId, returns list of topics
            return await context.Topics.Where(t => t.CourseId == courseId).ToListAsync();
        }

        public async Task<List<string>> GetTopicNamesByCourseIDAsnyc(int courseId)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Topics
                .Where(t => t.CourseId == courseId)
                .Select(t => t.Name)
                .ToListAsync();
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

        public async Task UpdateInstanceDataAsync(string instanceId, string data)
        {
            using var context = _contextFactory.CreateDbContext();

            var instance = await context.Instances.FirstOrDefaultAsync(i => i.InstanceId == instanceId);

            if(instance != null)
            {
                instance.Data = data;
                await context.SaveChangesAsync();
            }
        }
    }
}
