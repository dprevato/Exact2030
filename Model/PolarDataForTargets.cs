using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [NotMapped]
    public partial class PolarDataForTargets
    {
        public string DeviceId { get; set; }
        public double? RDt { get; set; }
        public double? E { get; set; }
        public double? N { get; set; }
        public double? Q { get; set; }
        public double? Vector { get; set; }
        public double? Omega { get; set; }
        public double? Phi { get; set; }
    }
}
