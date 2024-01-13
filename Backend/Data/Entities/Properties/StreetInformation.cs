using Data.Lookups;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities.Properties;
public class StreetInformation
{
    public int? FacingId { get; set; }
    [NotMapped]
    public LkFacing? Facing { get; set; }
    public double Width { get; set; }
}
