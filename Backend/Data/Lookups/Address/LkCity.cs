using Data.Entities;
using Data.Entities.Auctions;
using Data.Entities.Projects;
using Data.Entities.Properties;

namespace Data.Lookups.Address;

public partial class LkCity
{
    public int Id { get; set; }

    public string? NameAr { get; set; }

    public string? NameEn { get; set; }

    public int? StateId { get; set; }

    public virtual LkState? State { get; set; }

    public virtual ICollection<Asset> Assets { get; } = new List<Asset>();
    public virtual ICollection<Auction> Auctions { get; } = new List<Auction>();
    public virtual ICollection<User> Users { get; } = new List<User>();
    public virtual ICollection<Project> Projects { get; } = new List<Project>();
    public virtual ICollection<Property> Properties { get; } = new List<Property>();
}
