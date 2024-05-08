using System.ComponentModel.DataAnnotations;
using System.IO.Compression;
using Microsoft.EntityFrameworkCore;
using S1.APIs.Dtos;
using S1.APIs.Errors;
using S1.APIs.Extensions;
using S1.Infrastructure;
using S1.Infrastructure.Models;

namespace S1.APIs;

public abstract class BooksServiceBase : IBooksService
{
    protected readonly S1Context _context;

    public BooksServiceBase(S1Context context)
    {
        _context = context;
    }

    private bool BookExists(long id)
    {
        return _context.Books.Any(e => e.Id == id);
    }

    public async Task<IEnumerable<BookDto>> books(BookFindMany findManyArgs)
    {
        var books = await _context
            .books.ApplyWhere(findManyArgs.Where)
            .ApplySkip(findManyArgs.Skip)
            .ApplyTake(findManyArgs.Take)
            .ApplyOrderBy(findManyArgs.SortBy)
            .ToListAsync();

        return books.ConvertAll(book => book.ToDto());
    }

    public async Task UpdateBook(string id, BookDto bookDto)
    {
        var book = new Book { Id = bookDto.Id, Name = bookDto.Name, };

        _context.Entry(book).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!BookExists(id))
            {
                throw new NotFoundException();
            }
            else
            {
                throw;
            }
        }
    }

    public async Task DeleteBook(string id)
    {
        var book = await _context.books.FindAsync(id);

        if (book == null)
        {
            throw new NotFoundException();
        }

        _context.books.Remove(book);
        await _context.SaveChangesAsync();
    }

    public async Task<BookDto> CreateBook(BookCreateInput inputDto)
    {
        var model = new Book { Id = inputDto.Id, Name = inputDto.Name, };
        _context.books.Add(model);
        await _context.SaveChangesAsync();

        var result = await _context.FindAsync<Book>(model.Id);

        if (result == null)
        {
            throw new NotFoundException();
        }

        return result.ToDto();
    }
}
