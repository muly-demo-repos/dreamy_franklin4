using System.ComponentModel.DataAnnotations;
using S1.APIs.Dtos;

namespace S1.APIs;

public interface ICustomersService
{
    public Task UpdateCustomer(string id, Customer dto);
    public Task ConnectOrder(string id, [Required] string OrderId);
    public Task ConnectAddress(string id, [Required] string AddressId);
    public Task UpdateOrders(CustomerIdDto idDto, OrderIdDto[] OrdersId);
    public Task UpdateAddresses(CustomerIdDto idDto, AddressIdDto[] AddressesId);
    public Task<IEnumerable<Order>> Orders(string id);
    public Task<IEnumerable<Address>> Addresses(string id);
    public Task<IEnumerable<Customer>> Customers();
    public Task<IEnumerable<Order>> Orders(string id);
    public Task<IEnumerable<Address>> Addresses(string id);
    public Task DeleteCustomer(string id);
    public Task<Customer> CreateCustomer(CustomerCreateInput input);
    public Task DisconnectOrder(string id, [Required] string OrderId);
    public Task DisconnectAddress(string id, [Required] string AddressId);
}
