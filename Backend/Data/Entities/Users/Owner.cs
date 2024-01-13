using Data.Entities.Projects;

namespace Data.Entities;
public class Owner : User
{
    public int RefNo { get; set; }
    public DateTime LastUpdated { get; set; }
    public string? ListedByEn { get; set; }
    public string? ListedByAr { get; set; }
    public virtual ICollection<Project> Projects { get; set; } = new HashSet<Project>();
}
