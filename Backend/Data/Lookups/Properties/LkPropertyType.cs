using Data.Entities.Properties;

namespace Data.Lookups.Properties;
public partial class LkPropertyType
{
    public int Id { get; set; }
    public string? NameAr { get; set; }
    public string? NameEn { get; set; }
    //public virtual ICollection<AdditionalInformation> AdditionalInformations { get; set; } = new HashSet<AdditionalInformation>();
}
