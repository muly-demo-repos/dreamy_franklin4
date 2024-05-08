using System.ComponentModel.DataAnnotations;
using S1.APIs.Dtos;

namespace S1.APIs;

public interface IBooksService
{
    public Task<IEnumerable<Book>> Books();
    public Task UpdateBook(string id, Book dto);
    public Task DeleteBook(string id);
    public Task<Book> CreateBook(BookCreateInput input);
}
