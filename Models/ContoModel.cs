public enum StatoConto
{
    Attivo,
    Sopeso,
    Bloccato,
}

public class ContoModel
{
    public Guid Id { get; set; }
    public Guid Proprietario { get; set; }
    public StatoConto Stato { get; set; }
    public List<TransactionModel> Transazioni { get; set; } = new();

    /**
     * Doppio operatore ternario, se l'id della transazione è uguale all'id del mittente
     * significa che è un deposito, se restituisce false la prima condizione allora
     * controllo se l'id della transizione è uguale all' id del destinatario, quindi
     * significa che è un deposito.
     * Restituisce la somma.
     */
    public decimal Saldo => Transazioni.Sum(
        t =>
        t.Mittente == Id ? -t.Importo : t.Destinatario == Id ? t.Importo : 0
    );

    public ContoModel(Guid id, Guid proprietario, StatoConto stato)
    {
        Id = id;
        Proprietario = proprietario;
        Stato = stato;
    }
}
