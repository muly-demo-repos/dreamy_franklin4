using Microsoft.EntityFrameworkCore;
using Muly.Infrastructure.Models;

namespace Muly.Infrastructure;

public class MulyContext : DbContext
{
    public MulyContext(DbContextOptions<MulyContext> options)
        : base(options) { }

    public DbSet<Order> Orders { get; set; } = null!;
    public DbSet<Customer> Customers { get; set; } = null!;
    public DbSet<Address> Addresses { get; set; } = null!;
    public DbSet<Product> Products { get; set; } = null!;
}
