namespace Model;
public class ChartPlot
{
    public required int ChartId { get; set; }
    public required int Id { get; set; }
    public required int YAxisId { get; set; }
    public string? PlotType { get; set; }
    public string? PlotColor { get; set; }
    public string? PlotLabel { get; set; }
    public bool? ShowDatapoints { get; set; }
    public required string DataSource { get; set; }
    public required DateTime Version { get; set; }

    public virtual Chart? Chart { get; set; }
}
