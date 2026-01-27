using System.ComponentModel.DataAnnotations;

namespace CSLLMCapstone.Models
{
    public class User
    {
        [Key] // Primary Key
        public int UserId { get; set; }

        [Required]
        [MaxLength(45)]
        public string FName { get; set; } = string.Empty;

        [Required]
        [MaxLength(45)]
        public string LName { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string CwuEmail { get; set; } = string.Empty;

        [Required]
        [MaxLength(45)]
        public string Major { get; set; } = string.Empty;

        [MaxLength(45)]
        public string? Minor { get; set; } // Nullable

        public int GraduationDate { get; set; } // Storing as Year (2025, 2026)

        [Required]
        public string Password { get; set; } = string.Empty; //!TODO hash this!

        // Navigation property for relationships
        public List<Instance> Instances { get; set; } = new();
    }
}
