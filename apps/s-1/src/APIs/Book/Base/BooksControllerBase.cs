using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using S1.APIs.Dtos;
using S1.APIs.Errors;

namespace S1.APIs;

[Route("api/[controller]")]
[ApiController]
public class BooksControllerBase : ControllerBase
{
    protected readonly IBooksService _service;

    public BooksControllerBase(IBooksService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<BookDto>>> Books()
    {
        return Ok(await _service.books());
    }

    [HttpPatch("{id}")]
    public async Task<IActionResult> UpdateBook(string id, BookDto bookDto)
    {
        if (id != bookDto.Id)
        {
            return BadRequest();
        }

        try
        {
            await _service.UpdateBook(id, bookDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBook(string id)
    {
        try
        {
            await _service.DeleteBook(id);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    [HttpPost]
    public async Task<ActionResult<BookDto>> CreateBook(BookCreateInput input)
    {
        var dto = await _service.CreateBook(input);
        return CreatedAtAction(nameof(Book), new { id = dto.Id }, dto);
    }
}
