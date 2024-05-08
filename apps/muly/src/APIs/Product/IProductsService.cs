using System.ComponentModel.DataAnnotations;
using Muly.APIs.Dtos;

namespace Muly.APIs;

public interface IProductsService
{
    public Task UpdateProduct(string id, Product dto);
    public Task<IEnumerable<Product>> Products();
    public Task<IEnumerable<Order>> Orders(string id);
    public Task DeleteProduct(string id);
    public Task DisconnectOrder(string id, [Required] string OrderId);
    public Task<Product> CreateProduct(ProductCreateInput input);
    public Task ConnectOrder(string id, [Required] string OrderId);
    public Task UpdateOrders(ProductIdDto idDto, OrderIdDto[] OrdersId);
}
