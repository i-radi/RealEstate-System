using Data.Entities;
using Data.Entities.Ads;
using Data.Entities.Auctions;
using Data.Entities.Projects;
using Data.Entities.Properties;
using Data.Lookups;
using Data.Lookups.Address;
using Data.Lookups.Auctions;
using Data.Lookups.Projects;
using Data.Lookups.Properties;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.DataEncryption;
using Microsoft.EntityFrameworkCore.DataEncryption.Providers;
using System.Reflection;

namespace Infrastructure.Context;
public class ApplicationDBContext : IdentityDbContext<User, Role, int, IdentityUserClaim<int>, IdentityUserRole<int>, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
{
    private readonly byte[] _encryptionKey = Convert.FromBase64String("6Xmb966HtuQj23qxoPnjzbvcP1jekO5qyVvRr8BDh2M=");
    private readonly byte[] _encryptionIV = Convert.FromBase64String("6ha/Vysj3arR/dogzwVEMA==");

    private readonly IEncryptionProvider _encryptionProvider;

    public ApplicationDBContext()
    {
        _encryptionProvider = new AesProvider(this._encryptionKey, this._encryptionIV);
    }
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
    {
        _encryptionProvider = new AesProvider(this._encryptionKey, this._encryptionIV);
    }
    public override DbSet<User> Users { get; set; }
    public override DbSet<Role> Roles { get; set; }
    public virtual DbSet<Broker> Brokers { get; set; }
    public virtual DbSet<Owner> Owners { get; set; }
    public virtual DbSet<Property> Properties { get; set; }
    public virtual DbSet<UserProperties> UserProperties { get; set; }
    public virtual DbSet<Project> Project { get; set; }
    public virtual DbSet<Unit> Units { get; set; }
    public virtual DbSet<Auction> Auctions { get; set; }
    public virtual DbSet<Asset> Assets { get; set; }
    public virtual DbSet<UserRefreshToken> UserRefreshToken { get; set; }
    public virtual DbSet<Ad> Ads { get; set; }

    #region Lookups

    public virtual DbSet<LkCity> LkCities { get; set; }
    public virtual DbSet<LkCountry> LkCountries { get; set; }
    public virtual DbSet<LkState> LkStates { get; set; }
    public virtual DbSet<LkAssetType> LkAssetTypes { get; set; }
    public virtual DbSet<LkResidencyType> LkResidencyTypes { get; set; }
    public virtual DbSet<LkFurniture> LkFurnitures { get; set; }
    public virtual DbSet<LkPropertyType> LkPropertyTypes { get; set; }
    public virtual DbSet<LkFacade> LkFacades { get; set; }
    public virtual DbSet<LkFacing> LkFacings { get; set; }

    #endregion

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        builder.Entity<User>().ToTable("Users");
        builder.Entity<Role>().ToTable("Roles");
        builder.Entity<IdentityUserRole<int>>().ToTable("UserRoles");
        builder.Entity<IdentityUserClaim<int>>().ToTable("UserClaims");
        builder.Entity<IdentityUserLogin<int>>().ToTable("UserLogins");
        builder.Entity<IdentityRoleClaim<int>>().ToTable("RoleClaims");
        builder.Entity<IdentityUserToken<int>>().ToTable("UserTokens");
        builder.Entity<UserProperties>().HasQueryFilter(m => !m.IsDeleted);
        builder.Entity<UserRefreshToken>().HasQueryFilter(m => !m.IsDeleted);

        builder.UseEncryption(_encryptionProvider);
    }
}
