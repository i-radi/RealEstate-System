using Data.Entities;
using Infrastructure.Repositories.InfrastructureBases;

namespace Infrastructure.Repositories.Abstracts;
public interface IRefreshTokenRepository : IGenericRepositoryAsync<UserRefreshToken>
{
}
