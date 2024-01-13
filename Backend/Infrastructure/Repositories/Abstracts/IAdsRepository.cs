using Data.Entities.Ads;
using Infrastructure.Repositories.InfrastructureBases;

namespace Infrastructure.Repositories.Abstracts;
public interface IAdsRepository : IGenericRepositoryAsync<Ad>
{
}
