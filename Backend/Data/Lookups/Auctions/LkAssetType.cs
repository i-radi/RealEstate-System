using Data.Entities.Auctions;

namespace Data.Lookups.Auctions;
public partial class LkAssetType
{
    public int Id { get; set; }
    public string? NameAr { get; set; }
    public string? NameEn { get; set; }

    //public virtual ICollection<AdditionalInformation> AdditionalInformations { get; set; } = new HashSet<AdditionalInformation>();
}
