using Data.Entities.Auctions;
using Infrastructure.Repositories.InfrastructureBases;

namespace Infrastructure.Repositories.Abstracts;
public interface IAuctionRepository : IGenericRepositoryAsync<Auction>
{
}
