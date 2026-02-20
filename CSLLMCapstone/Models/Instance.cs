using CSLLMCapstone.Services;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSLLMCapstone.Models
{
    // Instance can be of type: Quiz, Tutor, or Flash
    public enum InstanceType
    {
        Quiz,
        Tutor,
        Flash
    }

    // Instance model representing an instance of a quiz, tutor, or flashcard session associated with a user
    public class Instance
    {
        [NotMapped]
        public LLM? llm { get; set; }

        [Key]
        [MaxLength(8)]
        public string InstanceId { get; set; } = Guid.NewGuid().ToString().Substring(0, 8);

        [ForeignKey("User")]
        public int UserId { get; set; }

        public User? User { get; set; }

        [Required]
        public InstanceType Type { get; set; }

        [Required]
        public string Data { get; set; } = "{}";

        [Required]
        public bool IsFavorite { get; set; } = false;

        [Required]
        public int CourseId { get; set; }

        [Required]
        public string CourseTitle { get; set; } = "";

        [Required]
        public string TopicName { get; set; } = "";
    }
}
