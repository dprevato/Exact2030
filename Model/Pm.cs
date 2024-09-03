using Model.Enums;

namespace Model
{
    /// <summary>
    /// Punti di misura o canali
    /// </summary>
    public partial class Pm
    {
        public required string Id { get; set; }
        public required string DevId { get; set; }
        public required string Channel { get; set; }
        public required string Tag { get; set; }
        public required string Name { get; set; }
        public DateOnly Installed { get; set; }
        public DateOnly? Dismissed { get; set; }
        public double ReadOffset { get; set; } // quantità fissa da aggiungere in certi casi alle letture
        public bool? OnReport { get; set; }
        public PmStates? PmStatus { get; set; }
        public bool? FakePm { get; set; } // Non si tratta di un Pm fisico
        public bool? Validate { get; set; }
        public double? WarningLo { get; set; }
        public double? WarningHi { get; set; }
        public double? AlarmLo { get; set; }
        public double? AlarmHi { get; set; }
        public bool AutoImport { get; set; }
        public bool CanImport { get; set; }
        public string? SourceTable { get; set; }
        public string? SourceFilter { get; set; }
        public int FormulaId { get; set; }
        public DateOnly LastImport { get; set; }

        public virtual Device? Device { get; set; }
        public virtual Formula? Formula { get; set; }
    }
}
