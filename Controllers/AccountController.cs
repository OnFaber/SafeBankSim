using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class AccountController : Controller
    {     
        // GET: AccountController
        // Riepilogo conti
        public ActionResult Index()
        {
            return View();
        }
        // aggiungere conto
        // param = id
        public ActionResult Conto(string id)
        {
            // ContoService
            // Dictionary<> Conto = ContoService.search(id);
            // logica nel json per filtrare il conto con 'id
            
            return View();
        }
        // delete conto
        // singolo conto
        // riepilogo informazioni utente
        
    }
}
