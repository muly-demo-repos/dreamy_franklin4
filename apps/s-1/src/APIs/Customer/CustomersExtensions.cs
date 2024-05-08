using S1.APIs.Dtos;
using S1.Infrastructure.Models;

namespace S1.APIs.Extensions;

public static class CustomersExtensions
{
    public static CustomerDto ToDto(this Customer model)
    {
        return new CustomerDto
        {
            Id = model.Id,
            CreatedAt = model.CreatedAt,
            UpdatedAt = model.UpdatedAt,
            FirstName = model.FirstName,
            LastName = model.LastName,
            Email = model.Email,
            Phone = model.Phone,
            Orders = model.Orders.Select(x => x.ToDto()).ToList(),
            Addresses = model.Addresses.Select(x => x.ToDto()).ToList(),
        };
    }
}
