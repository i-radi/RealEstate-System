namespace Data.Entities.Properties;
public class UserProperties
{
    public int? UserId { get; set; }
    public virtual User? User { get; set; }

    public int? PropertyId { get; set; }
    public virtual Property? Property { get; set; }

    public string? Review { get; set; }
    public double Rating { get; set; }
    public bool IsFavorite { get; set; }
    public bool IsBanchbook { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime? DeletedDate { get; set; }
}
