using System.Collections.ObjectModel;

namespace Model
{
    /// <summary>
    /// Tipologie strumentali
    /// </summary>
    public partial class Kind
    {
        public required string Id { get; set; }
        public required string Name { get; set; }

        public virtual ObservableCollection<Device> Device { get; set; } = [];
        public virtual ObservableCollection<Subkind> Subkind { get; set; } = [];
    }
}
