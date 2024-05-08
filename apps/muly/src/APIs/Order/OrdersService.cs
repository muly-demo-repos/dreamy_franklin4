using Muly.Infrastructure;

namespace Muly.APIs;

public class OrdersService : OrdersServiceBase
{
    public OrdersService(MulyContext context)
        : base(context) { }
}
