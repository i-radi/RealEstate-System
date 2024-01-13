using Core.Features.Authorization.Quaries.Results;
using Data.Entities;
using Data.Results;

namespace Core.Services.Abstracts;

public interface IAuthorizationService
{
    public Task<string> AddRoleAsync(string roleName);
    public Task<bool> IsRoleExistByName(string roleName);
    public Task<string> EditRoleAsync(EditRoleRequest request);
    public Task<string> DeleteRoleAsync(int roleId);
    public Task<bool> IsRoleExistById(int roleId);
    public Task<List<Role>> GetRolesList();
    public Task<Role> GetRoleById(int id);
    public Task<ManageUserRolesResult> ManageUserRolesData(User user);
    public Task<string> UpdateUserRoles(UpdateUserRolesRequest request);
}
