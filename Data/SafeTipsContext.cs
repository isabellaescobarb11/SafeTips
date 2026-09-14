using Microsoft.EntityFrameworkCore;
using SafeTips.Models;

namespace SafeTips.Data;

public class SafeTipsContext : DbContext
{
    public SafeTipsContext(DbContextOptions<SafeTipsContext> options)
        : base(options)
    {
    }

    public DbSet<Housekeeper> Housekeepers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Housekeeper>().HasData(
            new Housekeeper
            {
                Id = 19863245,
                Name = "Marcyne",
                Hotel = "Grand Village",
                Description = "Has worked here for 5 years"
            },
            new Housekeeper
            {
                Id = 97393749,
                Name = "Garry",
                Hotel = "Bonneville Mount",
                Description = "Has worked here for 7 months"
            }
        );
    }
}