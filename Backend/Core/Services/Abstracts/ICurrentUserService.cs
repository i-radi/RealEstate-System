using Data.Entities;

namespace Core.Services.Abstracts;

public interface ICurrentUserService
{
    public Task<User> GetUserAsync();
    public int GetUserId();
    public Task<List<string>> GetCurrentUserRolesAsync();
}
