using Data.Lookups;
using Data.Lookups.Auctions;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities.Auctions;
public class AdditionalInformation
{
    public int? AssetTypeId { get; set; }
    [NotMapped]
    public LkAssetType? AssetType { get; set; }
    public int? FacadeId { get; set; }
    [NotMapped]
    public LkFacade? Facade { get; set; }
    public bool Electricity { get; set; }
    public bool Water { get; set; }
}
