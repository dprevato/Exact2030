namespace Model;
public class PreImport
{
    public required string PmCode { get; set; }
    public required DateTime ReadDateTime { get; set; }
    public string? ReadComment { get; set; }
    public required double Value { get; set; }
    public required DateTime Acquisition { get; set; } // data di acquisizione lettura
}