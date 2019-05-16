using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAPIPayement.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int CateroryId { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        public virtual ICollection<Article> Articles { get; set; }
    }
}