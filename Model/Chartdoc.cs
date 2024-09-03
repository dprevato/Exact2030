namespace Model
{
    /// <summary>
    /// Documento grafico (Form contenente uno o più grafici)
    /// </summary>
    public partial class Chartdoc

    {
        public required int Id { get; set; }
        public required string Code { get; set; }
        public int? PrintOrder { get; set; }
        public required string Title { get; set; }
        public string? Subtitle { get; set; }
        public int? TotalCurves { get; set; }
        public bool? FirstBigger { get; set; }
        public string? DocOwner { get; set; }
    }
}
