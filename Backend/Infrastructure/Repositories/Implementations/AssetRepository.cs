using Data.Entities.Auctions;
using Infrastructure.Context;
using Infrastructure.Repositories.Abstracts;
using Infrastructure.Repositories.InfrastructureBases;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Implementations;
public class AssetRepository : GenericRepositoryAsync<Asset>, IAssetRepository
{
    #region Fields
    private DbSet<Asset> assets;
    #endregion

    #region Constructors
    public AssetRepository(ApplicationDBContext dbContext) : base(dbContext)
    {
        assets = dbContext.Set<Asset>();
    }
    #endregion

    #region Handle Functions

    #endregion
}