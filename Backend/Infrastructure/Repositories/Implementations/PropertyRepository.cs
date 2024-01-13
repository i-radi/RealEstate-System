using Data.Entities.Properties;
using Infrastructure.Context;
using Infrastructure.Repositories.Abstracts;
using Infrastructure.Repositories.InfrastructureBases;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Implementations;
public class PropertyRepository : GenericRepositoryAsync<Property>, IPropertyRepository
{
    #region Fields
    private DbSet<Property> properties;
    #endregion

    #region Constructors
    public PropertyRepository(ApplicationDBContext dbContext) : base(dbContext)
    {
        properties = dbContext.Set<Property>();
    }
    #endregion

    #region Handle Functions

    #endregion
}
