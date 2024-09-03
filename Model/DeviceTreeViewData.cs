using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    // Definizione rimandata a quando verrà implementata
    public partial class DeviceTreeViewData
    {
        public required string PCode { get; set; }
        public string PName { get; set; } = null!;
        public string PmCode { get; set; } = null!;
        public string Tag { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Subtitle { get; set; } = null!;
        public int PmStatus { get; set; }
        public int InValid { get; set; }
        [NotMapped]
        public bool IsChecked { get; set; }                                                             // USATO SOLO PER CHILDREN
        [NotMapped] public ObservableCollection<DeviceTreeViewData> Children { get; set; } = []; // SOLO FATHER

    }
}
