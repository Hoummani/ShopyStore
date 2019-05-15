using System.ComponentModel.DataAnnotations;

namespace WebAPIPayement.Models
{
    public class PayementDetail
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        [MinLength(3)]
        public string CardOwnerName { get; private set; }
        [Required]
        public string CardNumber { get; private set; }
        [Required]
        [MinLength(10)]
        public string ExpirationDate { get; private set; }
        [Required]
        [StringLength(3)]
        public string CVV { get; private set; }
    }
}