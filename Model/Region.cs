using System.Collections.ObjectModel;

namespace Model;
public class Region
{
    public Guid Guid { get; set; }
    public required string Id { get; set; }
    public required string Name { get; set; } // nome breve
    public string? Details { get; set; } // Nome esteso, descrizione
    public required DateTime Version { get; set; } // TimeStamp

    public ObservableCollection<Plant> Plants { get; set; } = [];
}
