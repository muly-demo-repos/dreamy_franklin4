using S1.Infrastructure;

namespace S1.APIs;

public class CustomersService : CustomersServiceBase
{
    public CustomersService(S1Context context)
        : base(context) { }
}
