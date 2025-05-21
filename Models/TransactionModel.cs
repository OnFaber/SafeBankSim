using System.ComponentModel.DataAnnotations;

public class TransactionModel
{
    public Guid Id { get; set; }
    public ContoModel Mittente { get; set; } // prendere l'id dalla classe AccountModel
    public ContoModel Destinatario { get; set; }
    [DataType(DataType.Date)]
    public DateTime Timestamp { get; set; }

    public TransactionModel() { }
    public TransactionModel(Guid id, ContoModel mittente, ContoModel destinatario)
    {
        Id = id;
        Mittente = mittente;
        Destinatario = destinatario;
    }
}
