using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Muly.Infrastructure.Models;

[Table("Customers")]
public class Customer
{
    public string AddressId { get; set; }

    [ForeignKey(nameof(AddressId))]
    public Address? Address { get; set; }

    [Required]
    public DateTime CreatedAt { get; set; }

    public string? Email { get; set; }

    public string? FirstName { get; set; }

    [Key, Required]
    public long Id { get; set; }

    public string? LastName { get; set; }

    public ICollection<Order> Orders { get; set; } = new List<Order>();

    public string? Phone { get; set; }

    [Required]
    public DateTime UpdatedAt { get; set; }
}
