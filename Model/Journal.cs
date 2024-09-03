namespace Model
{
    /// <summary>
    /// Diario impianto
    /// </summary>
    public partial class Journal
    {
        public required string PlantCode { get; set; }
        public required int Id { get; set; }
        public DateTime RowDate { get; set; }
        public string? Annotation { get; set; }

        public virtual Plant Plant { get; set; }
    }
}
