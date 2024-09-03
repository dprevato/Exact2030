using System.Collections.ObjectModel;

namespace Model
{
    public partial class Device
    {
        public required string Id { get; set; }
        public required string RegionCode { get; set; }
        public required string PlantCode { get; set; }
        public required string KindCode { get; set; }
        public required string SubCode { get; set; }
        public required string ItemCode { get; set; }
        public string? Tag { get; set; }
        public string? Batch { get; set; }
        public string? DevName { get; set; }
        public DateOnly InstalledOn { get; set; }
        public DateOnly? Dismissed { get; set; }
        public string? Unit { get; set; }
        public bool? Fake { get; set; }
        public bool? Report { get; set; }
        public bool? NeedValidation { get; set; }

        public virtual Kind? Kind { get; set; }
        public virtual Plant? Plant { get; set; }
        public virtual Subkind? Subkind { get; set; }
        public virtual ObservableCollection<DeviceData> DeviceData { get; set; } = [];
        public virtual ObservableCollection<Pm> Pm { get; set; } = [];
    }
}
