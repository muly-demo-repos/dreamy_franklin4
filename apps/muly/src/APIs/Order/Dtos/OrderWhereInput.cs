namespace Muly.APIs.Dtos;

public class OrderWhereInput
{
    public DateTime CreatedAt { get; set; }
    public CustomerDto CustomerId { get; set; }
    public decimal? Discount { get; set; }
    public ProductDto ProductId { get; set; }
    public long? Quantity { get; set; }
    public long? TotalPrice { get; set; }
}
