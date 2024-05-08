using Microsoft.EntityFrameworkCore;
using S1.Infrastructure.Models;

namespace S1.Infrastructure;

public class S1Context : DbContext
{
    public S1Context(DbContextOptions<S1Context> options)
        : base(options) { }

    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Order> Orders { get; set; } = null!;
    public DbSet<Customer> Customers { get; set; } = null!;
    public DbSet<Address> Addresses { get; set; } = null!;
    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<Book> Books { get; set; } = null!;
}
