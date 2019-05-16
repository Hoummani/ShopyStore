using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAPIPayement.Models
{
    public class Client
    {
        [Key]
        [Required]
        public int ClientId { get; set; }
        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string Email { get; set; }
        
        [Required]
        public string Password { get; set; }
        
        [Required]
        public string LastName { get; set; }
        
        [Required]
        public string City { get; set; }
        
        [Required]
        public string Phone { get; set; }
        
        public virtual ICollection<Command> Commands { get; set; }
    }
}