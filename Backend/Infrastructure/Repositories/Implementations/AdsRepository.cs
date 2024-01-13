using Data.Entities.Ads;
using Infrastructure.Context;
using Infrastructure.Repositories.Abstracts;
using Infrastructure.Repositories.InfrastructureBases;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Implementations;
public class AdsRepository : GenericRepositoryAsync<Ad>, IAdsRepository
{
    #region Fields
    private DbSet<Ad> ads;
    #endregion

    #region Constructors
    public AdsRepository(ApplicationDBContext dbContext) : base(dbContext)
    {
        ads = dbContext.Set<Ad>();
    }
    #endregion

    #region Handle Functions

    #endregion
}
