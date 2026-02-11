using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSLLMCapstone.Models
{
    // Topic model representing a topic associated with a course, including its name and description
    public class Topic
    {
        [Key]
        public int TopicId { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string TopicDesc { get; set; } = string.Empty;
    }
}
