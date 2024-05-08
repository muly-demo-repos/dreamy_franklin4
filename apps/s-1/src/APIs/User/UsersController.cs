using Microsoft.AspNetCore.Mvc;

namespace S1.APIs;

[ApiController]
public class UsersController : UsersControllerBase
{
    public UsersController(IUsersService service)
        : base(service) { }
}
