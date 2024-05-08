using S1.APIs.Dtos;
using S1.Infrastructure.Models;

namespace S1.APIs.Extensions;

public static class BooksExtensions
{
    public static BookDto ToDto(this Book model)
    {
        return new BookDto
        {
            Id = model.Id,
            CreatedAt = model.CreatedAt,
            UpdatedAt = model.UpdatedAt,
            Fld1 = model.Fld1,
        };
    }
}
