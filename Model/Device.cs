using System.Collections.ObjectModel;
using Model.Enums;

namespace Model;
public class Device
{
    public Guid Guid { get; set; }
    public required string RegionId { get; set; }
    public required string PlantId { get; set; }
    public required string KindId { get; set; }
    public required string DevId { get; set; } // DevId è la parte di codice che identifica un singolo device tra quelli che condividono la prima parte del codice
    public string? Code { get; set; }
    public required string Tag { get; set; }  // Nome corto, riportato sulla targa dello strumento
    public required string Name { get; set; } // Nome sintetico
    public string? Detail { get; set; } // nome esteso - dettagli
    public string? Batch { get; set; } // raggruppamento strumenti uguali (reportistica)
    public DateOnly PlacementDate { get; set; }
    public DateOnly? DismissionDate { get; set; }
    public string? Unit { get; set; } // Unità di misura delle letture strumentali
    public bool? VirtualDevice { get; set; } // Se true, è uno strumento non fisico
    public ReportType? Report { get; set; }
    public bool? ValidateReads { get; set; } // Le letture devono essere validate?
    public decimal? Longitude { get; set; }
    public decimal? Latitude { get; set; }
    public decimal? Altitude { get; set; }
    public required DateTime Version { get; set; }

    public Region? Region { get; set; }
    public Plant? Plant { get; set; }
    public Kind? Kind { get; set; }
    public ObservableCollection<Pm>? Pms { get; set; } // Punti di Misura discendenti dal device
    public ObservableCollection<DeviceData>? DevDataItems { get; set; }
}
