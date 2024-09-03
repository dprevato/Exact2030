using System.Collections.ObjectModel;

namespace Model
{
    /// <summary>
    /// anagrafica impianti
    /// </summary>
    public partial class Plant
    {
        public required string Id { get; set; }
        public required string Name { get; set; }
        public string? Details { get; set; }
        public DateOnly Built { get; set; }
        public DateOnly? Dismissed { get; set; }
        public string AreaId { get; set; }
        public double? MaxAltitude { get; set; }
        public double? MinAltitude { get; set; }

        public virtual Area? Area { get; set; }
        public virtual ObservableCollection<Device> Device { get; set; } = [];
        public virtual ObservableCollection<Journal> Journal { get; set; } = [];
        public virtual ObservableCollection<Personplant> Personplant { get; set; } = [];
        public virtual ObservableCollection<Plantdata> Plantdata { get; set; } = [];
    }
}
