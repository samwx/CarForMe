using DealerAPI.Domain;
using Microsoft.EntityFrameworkCore;

namespace DealerAPI.Data
{
    public class CarForMeDbContext : DbContext
    {
        public CarForMeDbContext(DbContextOptions<CarForMeDbContext> options)
            : base(options)
        {}
        
        public DbSet<Dealer> Dealer { get; set; }
    }
}