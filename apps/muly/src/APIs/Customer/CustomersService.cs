using Muly.Infrastructure;

namespace Muly.APIs;

public class CustomersService : CustomersServiceBase
{
    public CustomersService(MulyContext context)
        : base(context) { }
}
