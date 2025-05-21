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
        public ActionResult Index(string email)
        {
            var UserEmail = HttpContext.Session.GetString("UserEmail");            
            if (string.IsNullOrEmpty(UserEmail))
            {
                return RedirectToAction("Index", "Auth");
            }
            var utente = _userService.FindByEmail(UserEmail);
            var conto = utente?.Conto;
            
            return View(conto);
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
