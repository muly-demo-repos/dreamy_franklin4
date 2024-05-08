using System.ComponentModel.DataAnnotations;
using S1.APIs.Dtos;

namespace S1.APIs;

public interface IProductsService
{
    public Task<IEnumerable<Order>> Orders(string id);
    public Task ConnectOrder(string id, [Required] string OrderId);
    public Task UpdateOrders(ProductIdDto idDto, OrderIdDto[] OrdersId);
    public Task DeleteProduct(string id);
    public Task<Product> CreateProduct(ProductCreateInput input);
    public Task UpdateProduct(string id, Product dto);
    public Task<IEnumerable<Product>> Products();
    public Task DisconnectOrder(string id, [Required] string OrderId);
}
