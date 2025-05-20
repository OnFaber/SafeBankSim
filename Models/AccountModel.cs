public class AccountModel {    
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string PasswordHash { get; set; }
    public List<ContoModel> Conti { get; set; }

    public AccountModel(Guid id, string nome, string cognome, string email, string password, string passwordHash, List<ContoModel> conti) {
        Id = id;
        Nome = nome;
        Cognome = cognome;
        Email = email;
        Password = password; // l'hash
        PasswordHash = passwordHash; // salatura utilizzata per fare l'hash
        Conti = conti;
    }    
}
