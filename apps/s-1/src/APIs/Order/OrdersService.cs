using S1.Infrastructure;

namespace S1.APIs;

public class OrdersService : OrdersServiceBase
{
    public OrdersService(S1Context context)
        : base(context) { }
}
