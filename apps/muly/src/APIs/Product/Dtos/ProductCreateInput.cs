namespace Muly.APIs.Dtos;

public class ProductCreateInput
{
    public DateTime CreatedAt { get; set; }
    public decimal? ItemPrice { get; set; }
    public string? Name { get; set; }
    public ICollection<OrderDto>? Orders { get; set; }
}
