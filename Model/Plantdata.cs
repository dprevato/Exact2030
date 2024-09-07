namespace Model;
public class PlantData
{
    public Guid Guid { get; set; }
    public required string Code { get; set; } // codice impianto
    public required string ItemNo { get; set; } // ordinale 
    public required string ItemName { get; set; }
    public string? ItemUnit { get; set; }
    public required string ItemValue { get; set; }
    public required string Version { get; set; } // timestamp
}
