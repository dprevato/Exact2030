using System.Collections.ObjectModel;

namespace Model
{
    /// <summary>
    /// algoritmi di ingegnerizzazione
    /// </summary>
    public partial class Formula
    {
        public required int Id { get; set; }
        public required string FormulaText { get; set; }
        public int? ArgsNum { get; set; }

        public virtual ObservableCollection<Pm> Pm { get; set; } = [];
    }
}
