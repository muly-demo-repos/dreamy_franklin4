using S1.APIs.Dtos;
using S1.Infrastructure.Models;

namespace S1.APIs.Extensions;

public static class ProductsExtensions
{
    public static ProductDto ToDto(this Product model)
    {
        return new ProductDto
        {
            Id = model.Id,
            CreatedAt = model.CreatedAt,
            UpdatedAt = model.UpdatedAt,
            Name = model.Name,
            ItemPrice = model.ItemPrice,
            Description = model.Description,
            Orders = model.Orders.Select(x => x.ToDto()).ToList(),
        };
    }
}
