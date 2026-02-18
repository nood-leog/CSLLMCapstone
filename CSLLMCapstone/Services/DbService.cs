using CSLLMCapstone.Data;
using CSLLMCapstone.Models;
using Google.GenAI.Types;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace CSLLMCapstone.Services
{
    // This service class is responsible for all SQLite DB interactions related to Users, Courses, Topics, and Instances
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
        // Get user by email, used for sign-in and other operations
        public async Task<User?> GetUserByEmailAsync(string email)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Users.FirstOrDefaultAsync(u => u.CwuEmail == email);
        }

        // Get user by ID, used for profile and other operations
        public async Task<User?> GetUserByIdAsync(int userId)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Users.FirstOrDefaultAsync(u => u.UserId == userId);
        }

        // Create a new user, hashing the password before saving to the database
        public async Task CreateUserAsync(User newUser)
        {
            using var context = _contextFactory.CreateDbContext();
            // HASH THE PASSWORD BEFORE SAVING
            newUser.Password = _passwordHasher.HashPassword(newUser, newUser.Password);
            context.Users.Add(newUser);
            await context.SaveChangesAsync();
        }

        // Check if an email is already registered, used for validation during sign-up
        public async Task<bool> IsEmailRegisteredAsync(string email)
        {
            using var context = _contextFactory.CreateDbContext();
            // returns true if a user exists with that email, false otherwise
            return await context.Users.AnyAsync(u => u.CwuEmail == email);
        }

        // Sign in a user by verifying the email and password, returns the user if successful, null otherwise
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

        // Check if the new password is the same as the old password for a given user, used for validation during password change
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

        // Update the user's password, hashing the new password before saving to the database
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
        // Get all courses with their associated topics, used for displaying the course catalog and other operations
        public async Task<List<Course>> GetAllCoursesAsync()
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Courses
                .Include(c => c.Topics)
                .ToListAsync();
        }

        // Get course name by course ID, used for displaying course details and other operations
        public async Task<string?> GetCourseNameByCourseIdAsync(int courseId)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Courses.Where(t => t.CourseId == courseId).Select(t => t.Title).FirstOrDefaultAsync();
        }

        // Get course description by course ID, used for displaying course details and other operations
        public async Task<string?> GetCourseDescriptionByCourseIdAsync(int courseId)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Courses.Where(t => t.CourseId == courseId).Select(t => t.CourseDesc).FirstOrDefaultAsync();
        }

        // --- TOPIC METHODS ---
        // Get all topics for a given course ID, used for displaying course details and other operations
        public async Task<List<Topic>> GetTopicsByCourseIDAsync(int courseId)
        {
            using var context = _contextFactory.CreateDbContext();
            // takes courseId, returns list of topics
            return await context.Topics.Where(t => t.CourseId == courseId).ToListAsync();
        }

        // Get topic names for a given course ID, used for displaying course details and other operations
        public async Task<List<string>> GetTopicNamesByCourseIDAsnyc(int courseId)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Topics
                .Where(t => t.CourseId == courseId)
                .Select(t => t.Name)
                .ToListAsync();
        }


        // --- INSTANCE METHODS ---
        // Save a new instance to the database, used for recording user interactions and other operations
        public async Task SaveInstanceAsync(Instance instance)
        {
            using var context = _contextFactory.CreateDbContext();
            context.Instances.Add(instance);
            await context.SaveChangesAsync();
        }

        // Get an instance by its unique ID, used for retrieving specific interactions and other operations
        public async Task<Instance?> GetInstanceByIdAsync(string instanceId)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Instances
                //.Include(i => i.User)
                .FirstOrDefaultAsync(i => i.InstanceId == instanceId);
        }

        // Get all instances for a given user ID, ordered by favorites first, then most recent
        public async Task<List<Instance>> GetUserHistoryAsync(int userId)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Instances
                .Where(i => i.UserId == userId)
                .OrderByDescending(i => i.IsFavorite) // Primary sort: Favorites at top
                .ThenByDescending(i => i.InstanceId)   // Secondary sort: Most recent first
                .ToListAsync();
        }

        // Update an existing instance favorite status, used for allowing users to mark interactions as favorites and other operations
        public async Task UpdateInstanceFavoriteStatusAsync(string instanceId, bool isFavorite)
        {
            using var context = _contextFactory.CreateDbContext();
            var instance = await context.Instances.FirstOrDefaultAsync(i => i.InstanceId == instanceId);
            if (instance != null)
            {
                instance.IsFavorite = isFavorite;
                await context.SaveChangesAsync();
            }
        }

        // Delete an existing instance by its unique ID, used for allowing users to remove interactions from their history and other operations
        public async Task DeleteInstanceAsync(string instanceId)
        {
            using var context = _contextFactory.CreateDbContext();
            var instance = await context.Instances.FirstOrDefaultAsync(i => i.InstanceId == instanceId);
            if (instance != null)
            {
                context.Instances.Remove(instance);
                await context.SaveChangesAsync();
            }
        }

        // Update an existing instance's data, used for allowing users to modify interactions and other operations
        public async Task UpdateInstanceDataAsync(string instanceId, string newData)
        {
            using var context = _contextFactory.CreateDbContext();
            var instance = await context.Instances.FindAsync(instanceId);
            if (instance != null)
            {
                instance.Data = newData;
                await context.SaveChangesAsync();
            }
        }
    }
}
