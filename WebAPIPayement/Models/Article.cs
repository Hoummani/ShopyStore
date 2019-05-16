using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAPIPayement.Models
{
    public class Article
    {
        [Key]
        [Required]
        public int ArticleId { get; set; }
        
        [Required]
        public string Designation { get; set; }
        
        [Required]
        public double Price { get; set; }
        
        [Required]
        public int Stock { get; set; }
        
        [Required]
        public string Photo { get; set; }
        
        public Nullable<int> CateroryId { get; set; }
        
        public Category Category { get; set; }
        
        public virtual ICollection<Command> Commands { get; set; }
        
        
    }
}