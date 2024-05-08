using Microsoft.AspNetCore.Mvc;

namespace Muly.APIs;

[ApiController]
public class ProductsController : ProductsControllerBase
{
    public ProductsController(IProductsService service)
        : base(service) { }
}
