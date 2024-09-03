using System.Collections.ObjectModel;

namespace Model
{
    /// <summary>
    /// Singolo oggetto grafico
    /// </summary>
    public partial class Chart
    {
        public int DocId { get; set; }
        public int Id { get; set; }
        public int? PrintOrder { get; set; }
        public string? Title { get; set; }
        public string? YaxisTitle { get; set; }
        public float? MinY { get; set; }
        public float? MaxY { get; set; }
        public bool? Legend { get; set; }

        public virtual ObservableCollection<ChartData> ChartData { get; set; } = [];
    }
}
