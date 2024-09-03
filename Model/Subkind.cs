using System.Collections.ObjectModel;

namespace Model
{
    /// <summary>
    /// Sottotipi strumentali
    /// </summary>
    public partial class Subkind
    {
        public required string KindId { get; set; }
        public required string Id { get; set; }
        public required string PmId { get; set; }

        public virtual required Kind Kind { get; set; }
        public virtual ObservableCollection<Device> Device { get; set; } = [];
    }
}
