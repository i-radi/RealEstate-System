using Data.Commons;
using Data.Lookups.Address;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities.Properties;
public class Property : Entity
{
    public string? NameEn { get; set; }
    public string? NameAr { get; set; }
    public int Bedrooms { get; set; }
    public int LivingRooms { get; set; }
    public double BuiltUpArea { get; set; }
    public int Bathrooms { get; set; }
    public int GuestRooms { get; set; }
    public double Price { get; set; }
    public List<StreetInformation>? StreetInformation { get; set; }
    public AdditionalInformation? AdditionalInformation { get; set; }
    public List<string>? FeatuersAndAmentitiesEn { get; set; }
    public List<string>? FeatuersAndAmentitiesAr { get; set; }
    public List<string>? FixturesAndFittingsEn { get; set; }
    public List<string>? FixturesAndFittingsAr { get; set; }
    public string? Longitude { get; set; }
    public string? Latitude { get; set; }
    public string? DescriptionEn { get; set; }
    public string? DescriptionAr { get; set; }
    public List<string>? Videos { get; set; }
    public List<string>? Images { get; set; }
    public bool ForSale { get; set; }

    public int? BrokerId { get; set; }
    [ForeignKey(nameof(BrokerId))]
    public virtual Broker? Broker { get; set; }

    public int? CountryId { get; set; }
    public virtual LkCountry? Country { get; set; }
    public int? StateId { get; set; }
    public virtual LkState? State { get; set; }
    public int? CityId { get; set; }
    public virtual LkCity? City { get; set; }

    public virtual ICollection<UserProperties> UserProperties { get; set; } = new HashSet<UserProperties>();
}

