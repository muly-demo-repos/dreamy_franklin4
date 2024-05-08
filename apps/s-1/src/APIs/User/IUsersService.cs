using System.ComponentModel.DataAnnotations;
using S1.APIs.Dtos;

namespace S1.APIs;

public interface IUsersService
{
    public Task DeleteUser(string id);
    public Task UpdateUser(string id, User dto);
    public Task<User> CreateUser(UserCreateInput input);
    public Task<IEnumerable<User>> Users();
}
