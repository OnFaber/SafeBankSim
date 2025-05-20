public enum StatoConto{
    Attivo,
    Sopeso,
    Bloccato,
}

public class ContoModel {
    public Guid Id { get; set; }
    public Guid Proprietario {get; set;}
    public double Saldo { get; set; }
    public StatoConto Stato { get; set; }

    public ContoModel(Guid id, Guid proprietario, double saldo, StatoConto stato) {
        Id = id;
        Proprietario = proprietario;
        Saldo = saldo;
        Stato = stato;
    }
}
