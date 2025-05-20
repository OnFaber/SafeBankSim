public class AccountModel {    
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string Salt { get; set; }
    public List<ContoModel> Conti { get; set; }

    public AccountModel(Guid id, string nome, string cognome, string email, string passwordHash, string salt, List<ContoModel> conti) {
        Id = id;
        Nome = nome;
        Cognome = cognome;
        Email = email;
        PasswordHash = passwordHash;
        Salt = salt;
        Conti = conti;
    }    
}
