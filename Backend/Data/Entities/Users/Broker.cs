using Data.Entities.Properties;

namespace Data.Entities;
public class Broker : User
{
    public int RefNo { get; set; }
    public DateTime LastUpdated { get; set; }
    public int REGAAdLicenseNo { get; set; }
    public string? ListedByEn { get; set; }
    public string? ListedByAr { get; set; }
    public bool IsAuthorized { get; set; }
    public virtual ICollection<Property> Properties { get; set; } = new HashSet<Property>();
}
