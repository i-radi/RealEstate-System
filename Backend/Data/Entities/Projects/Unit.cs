using Data.Commons;
using Data.Entities.Properties;

namespace Data.Entities.Projects;
public class Unit : Entity
{
    public string? NameEn { get; set; }
    public string? NameAr { get; set; }
    public string? RefNo { get; set; }
    public string? UnitNo { get; set; }
    public int Bedrooms { get; set; }
    public int LivingRooms { get; set; }
    public int Bathrooms { get; set; }
    public double BuiltUpArea { get; set; }
    public double LandArea { get; set; }
    public double Price { get; set; }
    public List<StreetInformation>? StreetInformation { get; set; }
    public AdditionalInformation? AdditionalInformation { get; set; }
    public bool ForSale { get; set; }

    public int? ProjectId { get; set; }
    public virtual Project? Project { get; set; }
}
