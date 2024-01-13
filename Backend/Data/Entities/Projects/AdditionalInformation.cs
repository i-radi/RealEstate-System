using Data.Lookups.Projects;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities.Projects;
public class AdditionalInformation
{
    public string? BuildingYear { get; set; }
    public bool Electricity { get; set; }
    public bool Water { get; set; }
    public int? ResidencyTypeId { get; set; }
    [NotMapped]
    public LkResidencyType? ResidencyType { get; set; }
}
