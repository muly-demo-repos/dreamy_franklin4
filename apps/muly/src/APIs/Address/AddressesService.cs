using Muly.Infrastructure;

namespace Muly.APIs;

public class AddressesService : AddressesServiceBase
{
    public AddressesService(MulyContext context)
        : base(context) { }
}
