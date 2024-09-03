namespace Model
{
    /// <summary>
    /// storico stati pdm
    /// </summary>
    public partial class StatusHistory
    {
        public required int Id { get; set; }
        public required string PmId { get; set; }
        public DateTime ChangedOn { get; set; }
        public int Status { get; set; }
        public string Details { get; set; }
    }
}
