using S1.Infrastructure;

namespace S1.APIs;

public class BooksService : BooksServiceBase
{
    public BooksService(S1Context context)
        : base(context) { }
}
