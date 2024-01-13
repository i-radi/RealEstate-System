using Data.Entities;
using Infrastructure.Context;
using Infrastructure.Repositories.Abstracts;
using Infrastructure.Repositories.InfrastructureBases;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Implementations;
public class RefreshTokenRepository : GenericRepositoryAsync<UserRefreshToken>, IRefreshTokenRepository
{
    #region Fields
    private DbSet<UserRefreshToken> userRefreshToken;
    #endregion

    #region Constructors
    public RefreshTokenRepository(ApplicationDBContext dbContext) : base(dbContext)
    {
        userRefreshToken = dbContext.Set<UserRefreshToken>();
    }
    #endregion

    #region Handle Functions

    #endregion
}