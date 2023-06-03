using Amortization_System.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Amortization_System.Data
{
    public class AmorDbContext : DbContext
    {
        public AmorDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Buyer> Buyers { get; set; }
    }
}
