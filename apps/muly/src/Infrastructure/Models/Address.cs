using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Muly.Infrastructure.Models;

[Table("Addresses")]
public class Address
{
    public string? Address_1 { get; set; }

    public string? Address_2 { get; set; }

    public string? City { get; set; }

    [Required]
    public DateTime CreatedAt { get; set; }

    public ICollection<Customer> Customers { get; set; } = new List<Customer>();

    [Key, Required]
    public long Id { get; set; }

    public string? State { get; set; }

    [Required]
    public DateTime UpdatedAt { get; set; }

    public int? Zip { get; set; }
}
