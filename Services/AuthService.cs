using System.Text;
using System.Security.Cryptography;

public class AuthService
{
    public string HashPassword(string password, out string salt)
    {
        salt = Guid.NewGuid().ToString();
        using var sha256 = SHA256.Create();
        var bytes = Encoding.UTF8.GetBytes(password + salt);
        var hash = sha256.ComputeHash(bytes);
        return Convert.ToBase64String(hash);
    }

    public bool VerifyPassword(string input, string savedHash, string savedSalt)
    {
        using var sha256 = SHA256.Create();
        var inputBytes = Encoding.UTF8.GetBytes(input + savedSalt);
        var inputHash = sha256.ComputeHash(inputBytes);
        var savedHashBytes = Convert.FromBase64String(savedHash);
        return CryptographicOperations.FixedTimeEquals(inputHash, savedHashBytes);
    }
}
