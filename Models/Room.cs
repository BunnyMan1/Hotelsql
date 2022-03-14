namespace Hotelsql.Models;

public enum RoomType
{
    Regular = 1,
    Double = 2,
    Master = 3,
    Suite = 4,
}

public record Room
{
    public int Id { get; set; }
    public RoomType Type { get; set; }
    public int Size { get; set; }
    public double Price { get; set; }
    public int StaffId { get; set; }
}