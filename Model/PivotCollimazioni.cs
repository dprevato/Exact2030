namespace Model
{
    public partial class PivotCollimazioni
    {
        public string DeviceId { get; set; } = null!;
        public double? ReadingDateTime { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public double? Altitude { get; set; }
    }
}
