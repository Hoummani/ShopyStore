using Microsoft.EntityFrameworkCore;
namespace WebAPIPayement.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        
        
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasMany<Article>(c => c.Articles).WithOne(a=>a.Category);
            modelBuilder.Entity<Client>().HasMany<Command>(c => c.Commands).WithOne(c=>c.Client);
            modelBuilder.Entity<Article>().HasMany<Command>(c => c.Commands).WithOne(c=>c.Article);
        }
    }
}