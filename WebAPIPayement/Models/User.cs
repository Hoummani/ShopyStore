using System.ComponentModel.DataAnnotations;

namespace WebAPIPayement.Models
{
    public class User
    {
        [Key]
        [Required]
        public int Id { get; set; }
        
        [Required]
        public string Email { get; set; }
        
        [Required]
        public string Password { get; set; }
        
    }
}