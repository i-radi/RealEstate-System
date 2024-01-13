using Infrastructure.Repositories.Abstracts;
using Infrastructure.Repositories.Implementations;
using Infrastructure.Repositories.InfrastructureBases;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class ModuleInfrastructureDependencies
{
    public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
    {
        services.AddTransient<IAdsRepository, AdsRepository>();
        services.AddTransient<IAssetRepository, AssetRepository>();
        services.AddTransient<IAuctionRepository, AuctionRepository>();
        services.AddTransient<IBrokerRepository, BrokerRepository>();
        services.AddTransient<IOwnerRepository, OwnerRepository>();
        services.AddTransient<IProjectRepository, ProjectRepository>();
        services.AddTransient<IPropertyRepository, PropertyRepository>();
        services.AddTransient<IRefreshTokenRepository, RefreshTokenRepository>();
        services.AddTransient<IUnitRepository, UnitRepository>();
        services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));

        return services;
    }
}