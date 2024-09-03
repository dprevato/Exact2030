namespace Model
{
    /// <summary>
    /// Contiene i dati per la generazione di UNA curva
    /// </summary>
    public partial class ChartData
    {
        public required int ChartFk { get; set; }
        public required int Id { get; set; }
        /// <summary>
        /// Tipo di curva: per ora, sono ammessi i seguenti valori: 0 = Istogramma, 1 = Curva
        /// </summary>
        public int? DataType { get; set; }
        /// <summary>
        /// Colore della curva; per ora, solo valori letterali
        /// </summary>
        public string? DataColor { get; set; }
        /// <summary>
        /// Etichetta associata alla curva
        /// </summary>
        public string? DataLabel { get; set; }
        /// <summary>
        /// Codice della sorgente dati per costruire la curva; per default, coincide con il codice PDM
        /// </summary>
        public string? DataCode { get; set; }

        public virtual Chart? ChartFkNavigation { get; set; }
    }
}
