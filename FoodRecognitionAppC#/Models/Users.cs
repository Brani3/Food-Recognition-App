using System.ComponentModel.DataAnnotations;

namespace FoodRecognitionAppC_.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public required string Username { get; set; }

        [Required]
        public required string PasswordHash { get; set; }

        [EmailAddress]
        public required string Email { get; set; }
    }
}

