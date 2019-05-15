using Microsoft.EntityFrameworkCore;
namespace WebAPIPayement.Models
{
    public class PayementDbContext:DbContext
    {
        public PayementDbContext(DbContextOptions options) : base(options)
        {
        }

        private DbSet<PayementDetail> PayementDetails { get; set; }
    }
}