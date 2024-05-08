using S1.APIs.Dtos;
using S1.Infrastructure.Models;

namespace S1.APIs.Extensions;

public static class AddressesExtensions
{
    public static AddressDto ToDto(this Address model)
    {
        return new AddressDto
        {
            Id = model.Id,
            CreatedAt = model.CreatedAt,
            UpdatedAt = model.UpdatedAt,
            Address_1 = model.Address_1,
            Address_2 = model.Address_2,
            City = model.City,
            State = model.State,
            Zip = model.Zip,
            Customers = model.Customers.Select(x => x.ToDto()).ToList(),
        };
    }
}
