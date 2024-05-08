using Muly.Infrastructure;

namespace Muly.APIs;

public class ProductsService : ProductsServiceBase
{
    public ProductsService(MulyContext context)
        : base(context) { }
}
