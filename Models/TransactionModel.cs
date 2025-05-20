using System.ComponentModel.DataAnnotations;

public class TransactionModel {
    public Guid Id { get; set; }
    public ContoModel Mittente { get; set; } // prendere l'id dalla classe AccountModel
    public Guid Destinatario { get; set; }
    [DataType(DataType.Date)]
    public DateTime Timestamp { get; set; }

    public TransactionModel (Guid id, Guid account, Guid destinatario)
    {
        Id = id;
        Destinatario = destinatario;
    }
}
