using Muly.APIs.Dtos;
using Muly.Infrastructure.Models;

namespace Muly.APIs.Extensions;

public static class OrdersExtensions
{
    public static OrderDto ToDto(this Order model)
    {
        return new OrderDto
        {
            CreatedAt = model.CreatedAt,
            Customers = model.Customers.Select(x => x.ToDto()).ToList(),
            Discount = model.Discount,
            Id = model.Id,
            Products = model.Products.Select(x => x.ToDto()).ToList(),
            Quantity = model.Quantity,
            TotalPrice = model.TotalPrice,
            UpdatedAt = model.UpdatedAt,
        };
    }
}
