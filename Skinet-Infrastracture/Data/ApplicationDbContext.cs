using Microsoft.EntityFrameworkCore;
using Skinet_Domain.Models;

namespace Skinet_Infrastracture.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
