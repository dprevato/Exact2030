using System.Collections.ObjectModel;

namespace Model
{
    /// <summary>
    /// aree geografiche raggruppamento impianti
    /// </summary>
    public partial class Area
    {
        public Guid Id { get; set; }
        public required string Code { get; set; }
        public required string AreaName { get; set; }
        public string? Details { get; set; }

        public virtual ObservableCollection<Employee> Person { get; set; } = [];
        public virtual ObservableCollection<Plant> Plant { get; set; } = [];
    }
}
