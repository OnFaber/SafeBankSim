// deposita
// preleva
// bonifico // id utente corrente
// controlli se preleva è maggiore di saldo

public class TransactionService
{
    public void Bonifico(ContoModel mittente, ContoModel destinatario, double input)
    {
        if (input > mittente.saldo)
        {
            throw new NotImplementedException();
        }
        if (UserService.EmailExists(mittente) && UserService.EmailExists(destinatario))
        {
            mittente.saldo -= input;
            destinatario.saldo += input;
            System.Console.WriteLine($"Bonifico avvenuto con successo: "{ input});
        }
        else
        {
            throw new NotImplementedException();
        }
    }

    public void Deposit(ContoModel utente, double input)
    {
        if (UserService.EmailExists(utente.email))
        {
            utente.saldo += input;
            System.Console.WriteLine($"Deposito eseguito con successo: "{ input});
        }
    }

    public void Withdraw(ContoModel utente, double input)
    {
        if (!UserService.EmailExists(utente.email))
        {
            throw new NotImplementedException();
        }
        if (utente.saldo > input)
        {
            tente.saldo -= input;
            System.Console.WriteLine($"Prelevato con successo: "{ input});
        }
        else
        {
            throw new NotImplementedexception();
        }
    }
}