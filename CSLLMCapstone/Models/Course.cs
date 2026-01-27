using System.ComponentModel.DataAnnotations;

namespace CSLLMCapstone.Models
{
    public class Course
    {
        [Key]
        //assuming Course ID is an integer like 111, 112 ect
        //to turn off AutoIncrement for this specific ID, use [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseId { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string CourseDesc { get; set; } = string.Empty;

        public List<Topic> Topics { get; set; } = new();
    }
}
