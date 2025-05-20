using System.ComponentModel.DataAnnotations;

public class TransactionModel {
    public Guid Id { get; set; }
    public Guid Account { get; set; }  // stesso guid dell'account
    public Guid Mittente { get; set; } // prendere l'id dalla classe AccountModel
    public Guid Destinatario { get; set; }
    [DataType(DataType.Date)]
    public DateTime Timestamp { get; set; }

    public TransactionModel (Guid id, Guid account, Guid destinatario)
    {
        Id = id;
        Account = account;
        Destinatario = destinatario;
    }
}
