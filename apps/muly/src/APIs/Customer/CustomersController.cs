using Microsoft.AspNetCore.Mvc;

namespace Muly.APIs;

[ApiController]
public class CustomersController : CustomersControllerBase
{
    public CustomersController(ICustomersService service)
        : base(service) { }
}
