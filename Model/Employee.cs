namespace Model;
public class Employee
{
    public Guid Guid { get; set; }
    public required string Cid { get; set; } // Matricola
    public string? Title { get; set; }
    public required string LastName { get; set; }
    public string? MiddleName { get; set; }
    public string? FirstName { get; set; }
    public required string RegionId { get; set; } // Foreign Key: Region.Id
    public required DateOnly Hired { get; set; }
    public DateOnly? Retired { get; set; }
    public required DateTime Version { get; set; } // Timestamp
}
