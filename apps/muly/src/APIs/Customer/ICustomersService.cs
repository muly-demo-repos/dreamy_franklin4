using System.ComponentModel.DataAnnotations;
using Muly.APIs.Dtos;

namespace Muly.APIs;

public interface ICustomersService
{
    public Task<IEnumerable<Address>> Addresses(string id);
    public Task<IEnumerable<Order>> Orders(string id);
    public Task DisconnectAddress(string id, [Required] string AddressId);
    public Task DisconnectOrder(string id, [Required] string OrderId);
    public Task UpdateCustomer(string id, Customer dto);
    public Task DeleteCustomer(string id);
    public Task<IEnumerable<Address>> Addresses(string id);
    public Task<IEnumerable<Order>> Orders(string id);
    public Task<IEnumerable<Customer>> Customers();
    public Task ConnectAddress(string id, [Required] string AddressId);
    public Task ConnectOrder(string id, [Required] string OrderId);
    public Task<Customer> CreateCustomer(CustomerCreateInput input);
    public Task UpdateAddresses(CustomerIdDto idDto, AddressIdDto[] AddressesId);
    public Task UpdateOrders(CustomerIdDto idDto, OrderIdDto[] OrdersId);
}
