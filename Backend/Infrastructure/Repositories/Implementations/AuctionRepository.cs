using Data.Entities.Auctions;
using Infrastructure.Context;
using Infrastructure.Repositories.Abstracts;
using Infrastructure.Repositories.InfrastructureBases;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Implementations;
public class AuctionRepository : GenericRepositoryAsync<Auction>, IAuctionRepository
{
    #region Fields
    private DbSet<Auction> auctions;
    #endregion

    #region Constructors
    public AuctionRepository(ApplicationDBContext dbContext) : base(dbContext)
    {
        auctions = dbContext.Set<Auction>();
    }
    #endregion

    #region Handle Functions

    #endregion
}