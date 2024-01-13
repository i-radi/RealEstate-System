namespace Data.Entities.Auctions;
public class LengthAndBorder
{
    public From? FromNorth { get; set; }
    public From? FromSouth { get; set; }
    public From? FromEast { get; set; }
    public From? FromWest { get; set; }
}

public class From
{
    public int Width { get; set; }
    public string? Description { get; set; }
}