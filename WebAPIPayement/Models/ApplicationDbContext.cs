using Microsoft.EntityFrameworkCore;
namespace WebAPIPayement.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<PayementDetail> PayementDetails { get; set; }
        
        //clients
        public DbSet<Client> Clients { get; set; }
        
        //Admins
        public DbSet<Admin> Admins { get; set; }
        
        //Articles
        public DbSet<Article> Articles { get; set; }
        
        //Caterories
        public DbSet<Category> Categories { get; set; }
        
        //Commands
        
        public DbSet<Command> Commands { get; set; }
        
        
    }
}