namespace Model;
public class Argument
{
    public required string PmId { get; set; }
    public required int ArgPos { get; set; } // numero di posizione del parametro nella formula
    public required double ArgValue { get; set; }
    public required DateTime Version { get; set; }

    public virtual Pm? Pm { get; set; }
}
