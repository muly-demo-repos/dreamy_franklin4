using Microsoft.AspNetCore.Mvc;

namespace Muly.APIs;

[ApiController]
public class OrdersController : OrdersControllerBase
{
    public OrdersController(IOrdersService service)
        : base(service) { }
}
