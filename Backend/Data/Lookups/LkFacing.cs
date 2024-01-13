using Data.Entities.Properties;

namespace Data.Lookups;
public partial class LkFacing
{
    public int Id { get; set; }
    public string? NameAr { get; set; }
    public string? NameEn { get; set; }
    //public virtual ICollection<StreetInformation> StreetInformations { get; set; } = new HashSet<StreetInformation>();
}
