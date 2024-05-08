using S1.Infrastructure;

namespace S1.APIs;

public class AddressesService : AddressesServiceBase
{
    public AddressesService(S1Context context)
        : base(context) { }
}
