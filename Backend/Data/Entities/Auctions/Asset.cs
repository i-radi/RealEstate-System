using Data.Commons;
using Data.Entities.Properties;
using Data.Lookups.Address;

namespace Data.Entities.Auctions;
public class Asset : Entity
{
    public string? NameEn { get; set; }
    public string? NameAr { get; set; }
    public double LandArea { get; set; }
    public int TotalFloors { get; set; }
    public double BuiltUpArea { get; set; }
    public int Apartments { get; set; }
    public int Bedrooms { get; set; }
    public int Bathrooms { get; set; }
    public int LivingRooms { get; set; }
    public int GuestRooms { get; set; }
    public double DespositAmount { get; set; }
    public List<StreetInformation>? StreetInformation { get; set; }
    public AdditionalInformation? AdditionalInformation { get; set; }
    public List<string>? FeatuersAndAmentitiesEn { get; set; }
    public List<string>? FeatuersAndAmentitiesAr { get; set; }
    public string? Longitude { get; set; }
    public string? Latitude { get; set; }
    public string? DescriptionEn { get; set; }
    public string? DescriptionAr { get; set; }
    public LengthAndBorder? LengthAndBorder { get; set; }

    public int? AuctionId { get; set; }
    public virtual Auction? Auction { get; set; }

    public int? CountryId { get; set; }
    public virtual LkCountry? Country { get; set; }
    public int? StateId { get; set; }
    public virtual LkState? State { get; set; }
    public int? CityId { get; set; }
    public virtual LkCity? City { get; set; }
}
