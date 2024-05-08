using System.ComponentModel.DataAnnotations;
using S1.APIs.Dtos;

namespace S1.APIs;

public interface IOrdersService
{
    public Task<Order> CreateOrder(OrderCreateInput input);
    public Task DeleteOrder(string id);
    public Task<IEnumerable<Customer>> Customers(string id);
    public Task<IEnumerable<Product>> Products(string id);
    public Task<IEnumerable<Customer>> Customers(string id);
    public Task<IEnumerable<Product>> Products(string id);
    public Task<IEnumerable<Order>> Orders();
    public Task UpdateOrder(string id, Order dto);
}
