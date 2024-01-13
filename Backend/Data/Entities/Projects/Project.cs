using Data.Commons;
using Data.Entities.Properties;
using Data.Lookups.Address;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities.Projects;
public class Project : Entity
{
    public string? NameEn { get; set; }
    public string? NameAr { get; set; }
    public List<int>? Bedrooms { get; set; }
    public List<int>? LivingRooms { get; set; }
    public List<int>? Bathrooms { get; set; }
    public int UnitAvailable { get; set; }
    public string? About { get; set; }
    public List<StreetInformation>? StreetInformation { get; set; }
    public AdditionalInformation? AdditionalInformation { get; set; }
    public List<string>? AmentitiesEn { get; set; }
    public List<string>? AmentitiesAr { get; set; }
    public string? Longitude { get; set; }
    public string? Latitude { get; set; }
    public string? DescriptionEn { get; set; }
    public string? DescriptionAr { get; set; }
    public List<string>? Videos { get; set; }
    public List<string>? Images { get; set; }
    public bool ForSale { get; set; }
    public bool ReadyToMoveIn { get; set; }

    public int? OwnerId { get; set; }
    [ForeignKey(nameof(OwnerId))]
    public virtual Owner? Owner { get; set; }

    public int? CountryId { get; set; }
    public virtual LkCountry? Country { get; set; }
    public int? StateId { get; set; }
    public virtual LkState? State { get; set; }
    public int? CityId { get; set; }
    public virtual LkCity? City { get; set; }

    public virtual ICollection<Unit> Units { get; set; } = new HashSet<Unit>();

}
