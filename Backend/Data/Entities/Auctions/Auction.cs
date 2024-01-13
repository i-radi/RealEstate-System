using Data.Commons;
using Data.Lookups.Address;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities.Auctions;
public class Auction : Entity
{
    public string? NameEn { get; set; }
    public string? NameAr { get; set; }
    public int AssetAvailable { get; set; }
    public string? DescriptionEn { get; set; }
    public string? DescriptionAr { get; set; }
    public DateTime StartsOn { get; set; }
    public DateTime EndsOn { get; set; }
    public List<string>? Gallery { get; set; }
    public string? Brochure { get; set; }
    public int? GroupId { get; set; }

    public int? BrokerId { get; set; }
    [ForeignKey(nameof(BrokerId))]
    public virtual Broker? Broker { get; set; }

    public int? CountryId { get; set; }
    public virtual LkCountry? Country { get; set; }
    public int? StateId { get; set; }
    public virtual LkState? State { get; set; }
    public int? CityId { get; set; }
    public virtual LkCity? City { get; set; }

    public virtual ICollection<Asset> Assets { get; set; } = new HashSet<Asset>();
}
