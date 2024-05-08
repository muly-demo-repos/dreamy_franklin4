using Microsoft.AspNetCore.Mvc;

namespace Muly.APIs;

[ApiController]
public class AddresssController : AddresssControllerBase
{
    public AddresssController(IAddresssService service)
        : base(service) { }
}
