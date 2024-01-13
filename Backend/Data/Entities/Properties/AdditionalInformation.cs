using Data.Lookups;
using Data.Lookups.Properties;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities.Properties;
public class AdditionalInformation
{
    public int? PropertyTypeId { get; set; }
    [NotMapped]
    public LkPropertyType? PropertyType { get; set; }
    public int? FacadeId { get; set; }
    [NotMapped]
    public LkFacade? Facade { get; set; }
    public bool Electricity { get; set; }
    public bool Water { get; set; }
    public int TotalFloors { get; set; }
    public int PropertyFloor { get; set; }
    public int? FurnitureId { get; set; }
    [NotMapped]
    public LkFurniture? Furniture { get; set; }
    public int NumberOfParkings { get; set; }
    public int Age { get; set; }
}
