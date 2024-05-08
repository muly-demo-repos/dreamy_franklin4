using S1.Infrastructure;

namespace S1.APIs;

public class ProductsService : ProductsServiceBase
{
    public ProductsService(S1Context context)
        : base(context) { }
}
