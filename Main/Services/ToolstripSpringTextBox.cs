namespace Main.Services;

public class ToolstripSpringTextBox : ToolStripTextBox
{
    #region Overrides of ToolStripTextBox

    public override Size GetPreferredSize(Size constrainingSize) {
        // Se la casella di testo si trova nel menu overflow oppure se si trova in una toolstrip verticale, uso il formato di default
        if (IsOnOverflow || Owner!.Orientation == Orientation.Vertical) return DefaultSize;

        // Dichiaro una variabile per contenere la massima larghezza disponibile così come calcolata, partendo dalla larghezza visibile del
        // ToolStrip owner
        var width = Owner.DisplayRectangle.Width;
        // Sottraggo la larghezza del pulsante overflow se è visualizzato
        if (Owner.OverflowButton.Visible) width -= Owner.OverflowButton.Width - Owner.OverflowButton.Margin.Horizontal;
        // Dichiaro una variabile per mantenere il conteggio degli elementi ToolStripSpringTextBox attualmente visibili nel Toolstrip owner
        var springBoxCount = 0;

        foreach (ToolStripItem item in Owner.Items) {
            // Ignoro gli elementi che si trovano nel menu overflow
            if (item.IsOnOverflow) continue;

            if (item is ToolstripSpringTextBox) {
                // Per gli elementi ToolStripSpringTextBox, incremento il conteggio e sottraggo la larghezza del margine dalla larghezza massima disponibile
                springBoxCount++;
                width -= item.Margin.Horizontal;
            }
            else {
                // Per tutti gli altri elementi, sottraggo l'intera larghezza dalla larghezza massima disponibile.
                width -= item.Width + item.Margin.Horizontal;
            }
        }

        // Se il toolstrip owner contiene elementi ToolStripSpringTextBox multipli, divido tra di essi la larghezza totale disponibile.
        if (springBoxCount > 1) width /= springBoxCount;

        // Se la larghezza disponibile è inferiore alla larghezza di default, uso la larghezza di default, forzando uno o più elementi nel menu di overflow
        if (width < DefaultSize.Width) width = DefaultSize.Width;

        // Recupero le dimensioni preferite dalla classe base, ma cambio la larghezza alla larghezza calcolata
        var size = base.GetPreferredSize(constrainingSize);
        size.Width = width;
        return size;
    }

    #endregion Overrides of ToolStripTextBox
}