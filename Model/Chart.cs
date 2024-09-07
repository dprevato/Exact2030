using System.Collections.ObjectModel;

namespace Model;
public class Chart
{
    public required int SerieId { get; set; }
    public required int Id { get; set; }
    public required string Title { get; set; }
    public bool? ShowLegend { get; set; }
    public required string Author { get; set; }
    public required DateTime Version { get; set; }

    public virtual ChartCollection? ChartCollection { get; set; }
    public virtual ObservableCollection<ChartYAxis>? YAxis { get; set; }
    public virtual ObservableCollection<ChartPlot>? Curves { get; set; }
    public virtual ObservableCollection<ChartNote>? Annotations { get; set; }
}
