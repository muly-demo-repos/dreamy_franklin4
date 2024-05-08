using Microsoft.AspNetCore.Mvc;

namespace S1.APIs;

[ApiController]
public class OrdersController : OrdersControllerBase
{
    public OrdersController(IOrdersService service)
        : base(service) { }
}
