using Muly.APIs.Dtos;
using Muly.Infrastructure.Models;

namespace Muly.APIs.Extensions;

public static class ProductsExtensions
{
    public static ProductDto ToDto(this Product model)
    {
        return new ProductDto
        {
            CreatedAt = model.CreatedAt,
            Description = model.Description,
            Id = model.Id,
            ItemPrice = model.ItemPrice,
            Name = model.Name,
            Orders = model.Orders.Select(x => x.ToDto()).ToList(),
            UpdatedAt = model.UpdatedAt,
        };
    }
}
