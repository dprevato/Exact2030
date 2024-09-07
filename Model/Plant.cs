using System.Collections.ObjectModel;

namespace Model;
public class Plant
{
    public Guid Guid { get; set; }
    public required string RegionId { get; set; }
    public required string Id { get; set; } // codice Impianto - unique
    public string? Code { get; set; } // campo calcolato - RegionId + Id la combinazione è univoca
    public required string Name { get; set; } // nome breve
    public string? Details { get; set; } // nome esteso - descrizione
    public decimal? MaxAltitude { get; set; } // 2 decimali
    public decimal? MinAltitude { get; set; }
    public DateOnly? Built { get; set; }
    public DateOnly? Dismissed { get; set; }
    public required DateTime Version { get; set; } // Timestamp

    public ObservableCollection<Warden>? Wardens { get; set; } // personale di guardiania dell'impianto
    public ObservableCollection<PlantData>? PlantInfo { get; set; }
    public virtual ObservableCollection<Journal>? Journal { get; set; }
}
