using System.Text.Json;

public class UserService
{
    private readonly List<AccountModel> _utenti = new();
    private string _path;

    public UserService(IWebHostEnvironment env)
    {
        // Riepilogo:
        //     Gets or sets an Microsoft.Extensions.FileProviders.IFileProvider pointing at
        //     Microsoft.AspNetCore.Hosting.IWebHostEnvironment.WebRootPath. This defaults to
        //     referencing files from the 'wwwroot' subfolder.
        // IFileProvider WebRootFileProvider { get; set; }
        // 
        // IWebHostEnvironment deriva da IHostEnvironment usiamo questa o la derivata per env?
        // perchè ContentRootPath si trova in IHostEnvironment 
        _path = Path.Combine(env.ContentRootPath, "wwwroot", "data", "utenti.json");
        if (File.Exists(_path))
        {
            string json = File.ReadAllText(_path);
            var utenti = JsonSerializer.Deserialize<List<AccountModel>>(json);

            if (utenti != null)
            {
                _utenti = utenti;
            }
        }
    }

    public List<AccountModel> GetAll() => _utenti;
    public void SaveAll(List<AccountModel> utenti)
    {
        var json = JsonSerializer.Serialize(utenti, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(_path, json);
    }
    
    public void Add(AccountModel acc)
    {
        var utente = GetAll();
        _utenti.Add(acc);
        SaveAll(_utenti);
    }

    public bool EmailExists(string email)
    {
        return GetAll().Any(u => u.Email == email);
    }

    public AccountModel? FindByEmail(string email)
    {
        return GetAll().FirstOrDefault(u => u.Email == email);
    }
}
