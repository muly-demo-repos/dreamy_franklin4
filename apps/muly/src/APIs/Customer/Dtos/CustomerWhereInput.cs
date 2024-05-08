namespace Muly.APIs.Dtos;

public class CustomerWhereInput
{
    public AddressDto AddressId { get; set; }
    public DateTime CreatedAt { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public ICollection<OrderDto>? Orders { get; set; }
    public string? Phone { get; set; }
}
