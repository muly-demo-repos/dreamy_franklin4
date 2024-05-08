using System.ComponentModel.DataAnnotations;
using S1.APIs.Dtos;

namespace S1.APIs;

public interface IAddressesService
{
    public Task<IEnumerable<Address>> Addresses();
    public Task DeleteAddress(string id);
    public Task DisconnectCustomer(string id, [Required] string CustomerId);
    public Task UpdateCustomers(AddressIdDto idDto, CustomerIdDto[] CustomersId);
    public Task ConnectCustomer(string id, [Required] string CustomerId);
    public Task UpdateAddress(string id, Address dto);
    public Task<IEnumerable<Customer>> Customers(string id);
    public Task<Address> CreateAddress(AddressCreateInput input);
}
