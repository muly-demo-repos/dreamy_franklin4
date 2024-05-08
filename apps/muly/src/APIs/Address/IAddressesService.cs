using System.ComponentModel.DataAnnotations;
using Muly.APIs.Dtos;

namespace Muly.APIs;

public interface IAddressesService
{
    public Task DeleteAddress(string id);
    public Task UpdateAddress(string id, Address dto);
    public Task DisconnectCustomer(string id, [Required] string CustomerId);
    public Task UpdateCustomers(AddressIdDto idDto, CustomerIdDto[] CustomersId);
    public Task<Address> CreateAddress(AddressCreateInput input);
    public Task ConnectCustomer(string id, [Required] string CustomerId);
    public Task<IEnumerable<Address>> Addresses();
    public Task<IEnumerable<Customer>> Customers(string id);
}
