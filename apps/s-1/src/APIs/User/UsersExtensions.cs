using S1.APIs.Dtos;
using S1.Infrastructure.Models;

namespace S1.APIs.Extensions;

public static class UsersExtensions
{
    public static UserDto ToDto(this User model)
    {
        return new UserDto
        {
            Id = model.Id,
            CreatedAt = model.CreatedAt,
            UpdatedAt = model.UpdatedAt,
            FirstName = model.FirstName,
            LastName = model.LastName,
            Username = model.Username,
            Email = model.Email,
            Password = model.Password,
            Roles = model.Roles,
        };
    }
}
