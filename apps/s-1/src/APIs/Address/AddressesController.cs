using Microsoft.AspNetCore.Mvc;

namespace S1.APIs;

[ApiController]
public class AddresssController : AddresssControllerBase
{
    public AddresssController(IAddresssService service)
        : base(service) { }
}
