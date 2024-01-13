using System.ComponentModel.DataAnnotations;

namespace Data.Commons;
public class Entity : GeneralLocalizableEntity
{
    [Key]
    public int Id { get; set; }
    public int CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public int? UpdatedBy { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime? DeletedDate { get; set; }
}
