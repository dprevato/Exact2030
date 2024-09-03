namespace Model
{
    public partial class Reading
    {
        public required Guid Id { get; set; }
        public required string PmId { get; set; }
        public DateTime ReadDateTime { get; set; }
        public string? Comment { get; set; }
        public required double Rvalue { get; set; }
        public DateTime? TakenOn { get; set; }
        public bool Valid { get; set; }
        public DateTime? ValidatedOn { get; set; }
    }
}
