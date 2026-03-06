using System.ComponentModel.DataAnnotations;

namespace CSLLMCapstone.Models
{
    // UserFavorite model representing a user's favorite course with a reference to the course details
    public class UserFavorite
    {
        [Key]
        public int UserFavoriteId { get; set; }

        [Required]
        public string UserId { get; set; } // Foreign key to User table

        [Required]
        public int CourseId { get; set; } // Foreign key to Course table

        public Course Course { get; set; } = null!;
    }
}
