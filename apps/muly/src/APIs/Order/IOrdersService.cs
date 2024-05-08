using System.ComponentModel.DataAnnotations;
using Muly.APIs.Dtos;

namespace Muly.APIs;

public interface IOrdersService
{
    public Task DeleteOrder(string id);
    public Task UpdateOrder(string id, Order dto);
    public Task<IEnumerable<Order>> Orders();
    public Task<IEnumerable<Customer>> Customers(string id);
    public Task<IEnumerable<Product>> Products(string id);
    public Task<Order> CreateOrder(OrderCreateInput input);
    public Task<IEnumerable<Customer>> Customers(string id);
    public Task<IEnumerable<Product>> Products(string id);
}
