using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSLLMCapstone.Models
{
    public enum InstanceType
    {
        Quiz,
        Tutor,
        Flash
    }

    public class Instance
    {
        [Key]
        [MaxLength(8)]
        public string InstanceId { get; set; } = Guid.NewGuid().ToString().Substring(0, 8);

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User? User { get; set; }

        [Required]
        public InstanceType Type { get; set; }

        //SQLite doesn't have a native JSON type, it stores it as TEXT
        [Required]
        public string Data { get; set; } = "{}";
    }
}
