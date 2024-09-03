namespace Model
{
    public partial class Personplant
    {
        public string PlantId { get; set; } = null!;
        public string KeeperId { get; set; } = null!;
        public DateOnly From { get; set; }
        public DateOnly? To { get; set; }

        public virtual required Employee Employee { get; set; }
        public virtual required Plant Plant { get; set; }
    }
}
