using Data.Entities;
using Infrastructure.Context;
using Infrastructure.Repositories.Abstracts;
using Infrastructure.Repositories.InfrastructureBases;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Implementations;
public class OwnerRepository : GenericRepositoryAsync<Owner>, IOwnerRepository
{
    #region Fields
    private DbSet<Owner> owners;
    #endregion

    #region Constructors
    public OwnerRepository(ApplicationDBContext dbContext) : base(dbContext)
    {
        owners = dbContext.Set<Owner>();
    }
    #endregion

    #region Handle Functions

    #endregion
}
