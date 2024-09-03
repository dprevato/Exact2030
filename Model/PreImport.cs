namespace Model;

public class PreImport
{
    public required string PmId { get; set; }
    public DateTime ReadDateTime { get; set; }
    public string? Comment { get; set; }
    public double RValue { get; set; }
    public DateOnly TakenOn { get; set; }
}