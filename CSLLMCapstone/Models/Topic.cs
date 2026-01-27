using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSLLMCapstone.Models
{
    public class Topic
    {
        [Key]
        public int TopicId { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course? Course { get; set; } // Navigation property

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string TopicDesc { get; set; } = string.Empty;
    }
}
