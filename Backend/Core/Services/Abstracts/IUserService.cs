
using Data.Entities;

namespace Core.Services.Abstracts;

public interface IUserService
{
    public Task<string> AddUserAsync(User user, string password);
}
