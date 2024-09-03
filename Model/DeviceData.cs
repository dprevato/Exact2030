namespace Model
{
    /// <summary>
    /// caratteristiche estese dei device
    /// </summary>
    public partial class DeviceData
    {
        public required string DevCode { get; set; }
        public required int Id { get; set; }
        public required string ItemName { get; set; }
        public string? ItemUm { get; set; }
        public string? ItemValue { get; set; }

        public virtual Device? Device { get; set; }
    }
}
