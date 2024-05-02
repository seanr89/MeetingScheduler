
public class Location : AuditableEntry
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool Active { get; set; }
    public int SeatCount { get; set; }
}