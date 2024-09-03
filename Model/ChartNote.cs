using Model.Enums;

namespace Model
{
    /// <summary>
    /// Definizione Annotazioni da inserire in un grafico
    /// </summary>
    public partial class ChartNote
    {
        public required int ChartFk { get; set; }
        public required int Id { get; set; }
        /// <summary>
        /// Posizione su asse X; è una data, rappresentata come float
        /// </summary>
        public double? Xpos { get; set; }
        /// <summary>
        /// Posizione su asse Y; è un valore Y
        /// </summary>
        public double? Ypos { get; set; }
        /// <summary>
        /// Testo associato all&apos;annotazione
        /// </summary>
        public string? Message { get; set; }
        /// <summary>
        /// 0=Sinistra,
        /// 1=destra,
        /// 2=centrato,
        /// 4=alto,
        /// 8=basso
        /// </summary>
        public Alignments? TextAlignment { get; set; }
        public string? NoteColor { get; set; }
    }
}
