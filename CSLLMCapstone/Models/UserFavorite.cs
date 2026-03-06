using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSLLMCapstone.Models
{
    // UserFavorite model representing a user's favorite course with a reference to the course details
    public class UserFavorite
    {
        [Key]
        public int UserFavoriteId { get; set; }

        public int UserId { get; set; }

        public int CourseId { get; set; }

        // Navigation Properties
        [ForeignKey("UserId")]
        public User User { get; set; } = null!;

        [ForeignKey("CourseId")]
        public Course Course { get; set; } = null!;
    }
}
