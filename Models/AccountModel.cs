public class AccountModel {    
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public string Email { get; set; }
    public string PlainPassword { get; set; }
    public string PasswordHash { get; set; }
    public string Salt { get; set; }
    public ContoModel? Conto { get; set; }

    public AccountModel() {}
    public AccountModel(Guid id, string nome, string cognome, string email, string passwordHash, string salt, ContoModel conto) {
        Id = id;
        Nome = nome;
        Cognome = cognome;
        Email = email;
        PasswordHash = passwordHash;
        Salt = salt;
        Conto = conto;
    }    
}
