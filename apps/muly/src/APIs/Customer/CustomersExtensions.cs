using Muly.APIs.Dtos;
using Muly.Infrastructure.Models;

namespace Muly.APIs.Extensions;

public static class CustomersExtensions
{
    public static CustomerDto ToDto(this Customer model)
    {
        return new CustomerDto
        {
            Addresses = model.Addresses.Select(x => x.ToDto()).ToList(),
            CreatedAt = model.CreatedAt,
            Email = model.Email,
            FirstName = model.FirstName,
            Id = model.Id,
            LastName = model.LastName,
            Orders = model.Orders.Select(x => x.ToDto()).ToList(),
            Phone = model.Phone,
            UpdatedAt = model.UpdatedAt,
        };
    }
}
