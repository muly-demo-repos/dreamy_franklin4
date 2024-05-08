using S1.Infrastructure;

namespace S1.APIs;

public class UsersService : UsersServiceBase
{
    public UsersService(S1Context context)
        : base(context) { }
}
