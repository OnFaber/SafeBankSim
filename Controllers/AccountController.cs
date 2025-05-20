using Microsoft.AspNetCore.Mvc;

namespace SafeBankSim.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserService _userService;

        public AccountController(UserService userService)
        {
            _userService = userService;
        }
        
        // GET: AccountController
        // Riepilogo conti
        public ActionResult Index(string id)
        {
            var utenti = _userService.GetAll();
            return View(utenti);
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
