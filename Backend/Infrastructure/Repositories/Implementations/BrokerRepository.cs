using Data.Entities;
using Infrastructure.Context;
using Infrastructure.Repositories.Abstracts;
using Infrastructure.Repositories.InfrastructureBases;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Implementations;
public class BrokerRepository : GenericRepositoryAsync<Broker>, IBrokerRepository
{
    #region Fields
    private DbSet<Broker> brokers;
    #endregion

    #region Constructors
    public BrokerRepository(ApplicationDBContext dbContext) : base(dbContext)
    {
        brokers = dbContext.Set<Broker>();
    }
    #endregion

    #region Handle Functions

    #endregion
}
