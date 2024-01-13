using Data.Entities.Projects;
using Infrastructure.Context;
using Infrastructure.Repositories.Abstracts;
using Infrastructure.Repositories.InfrastructureBases;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Implementations;
public class UnitRepository : GenericRepositoryAsync<Unit>, IUnitRepository
{
    #region Fields
    private DbSet<Unit> units;
    #endregion

    #region Constructors
    public UnitRepository(ApplicationDBContext dbContext) : base(dbContext)
    {
        units = dbContext.Set<Unit>();
    }
    #endregion

    #region Handle Functions

    #endregion
}
