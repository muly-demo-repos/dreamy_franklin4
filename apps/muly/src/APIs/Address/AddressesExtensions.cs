using Muly.APIs.Dtos;
using Muly.Infrastructure.Models;

namespace Muly.APIs.Extensions;

public static class AddressesExtensions
{
    public static AddressDto ToDto(this Address model)
    {
        return new AddressDto
        {
            Address_1 = model.Address_1,
            Address_2 = model.Address_2,
            City = model.City,
            CreatedAt = model.CreatedAt,
            Customers = model.Customers.Select(x => x.ToDto()).ToList(),
            Id = model.Id,
            State = model.State,
            UpdatedAt = model.UpdatedAt,
            Zip = model.Zip,
        };
    }
}
