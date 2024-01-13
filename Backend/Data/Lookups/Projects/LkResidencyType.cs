using Data.Entities.Projects;

namespace Data.Lookups.Projects;
public partial class LkResidencyType
{
    public int Id { get; set; }
    public string? NameAr { get; set; }
    public string? NameEn { get; set; }
    //public virtual ICollection<AdditionalInformation> AdditionalInformations { get; set; } = new HashSet<AdditionalInformation>();
}
