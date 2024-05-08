using Microsoft.AspNetCore.Mvc;

namespace S1.APIs;

[ApiController]
public class BooksController : BooksControllerBase
{
    public BooksController(IBooksService service)
        : base(service) { }
}
