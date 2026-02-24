using System.ComponentModel.DataAnnotations;

namespace CSLLMCapstone.Models
{
    // Course model representing a course with its details and associated topics
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string CourseDesc { get; set; } = string.Empty;

        [Required]
        public bool IsFavorite { get; set; } = false;

        public List<Topic> Topics { get; set; } = new();
    }
}
