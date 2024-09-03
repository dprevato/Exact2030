namespace Model
{
    public partial class Plantdata
    {
        public required string PlantId { get; set; }
        public required int Id { get; set; }
        public string? ItemName { get; set; }
        public string? ItemUm { get; set; }
        public required string ItemValue { get; set; }

        public virtual Plant? Plant { get; set; }
    }
}
