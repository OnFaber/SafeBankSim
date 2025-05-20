public enum StatoConto{
    Attivo,
    Sopeso,
    Bloccato,
}

public class Conto {
    public Guid Id { get; set; }
    public double Saldo { get; set; }
    public StatoConto Stato  { get; set; }

    public Conto(Guid id, double saldo, StatoConto stato) {
        Id = id;
        Saldo = saldo;
        Stato = stato;
    }
}
