using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Muly.Infrastructure.Models;

[Table("Products")]
public class Product
{
    [Required]
    public DateTime CreatedAt { get; set; }

    public string? Description { get; set; }

    [Key, Required]
    public long Id { get; set; }

    public decimal? ItemPrice { get; set; }

    public string? Name { get; set; }

    public ICollection<Order> Orders { get; set; } = new List<Order>();

    [Required]
    public DateTime UpdatedAt { get; set; }
}
