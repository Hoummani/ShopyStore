using System;
using System.ComponentModel.DataAnnotations;

namespace WebAPIPayement.Models
{
    public class Command
    {
        [Key]
        [Required]
        public int CommandId { get; set; }
        
        [Required]
        public DateTime CommandDate { get; set; }
        
        [Required]
        public int Quantity { get; set; }
        
        //Article
        public Nullable<int> ArticleId { get; set; }
        
        public Article Article { get; set; }
        
        //Client
        public Nullable<int> ClientId { get; set; }
        
        public Client Client { get; set; }
    }
}