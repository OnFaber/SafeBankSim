using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class AuthController : Controller
    {
        private readonly AuthService _authService;
        private readonly UserService _userService;
        private readonly ILogger<AuthController> _logger;
        
        public AuthController(AuthService authService, UserService userService, ILogger<AuthController> logger) {
            _authService = authService;
            _userService = userService;
            _logger = logger;
        }
        
        // GET: AuthController
        [HttpGet]
        public IActionResult Index()
        {            
            return View();
        }

        [HttpPost]
        public IActionResult Index(string email, string password)
        {
            var user = _userService.FindByEmail(email);
            if (user == null || !_authService.VerifyPassword(password, user.Password, user.salt))
            {
                _logger.LogWarning("Login fallito per email: {Email}. Utente trovato? {UserFound}", email, user != null);
                ViewBag.Error = "credenziali errate";


                return View();
            }
            
            _logger.LogInformation("Login riuscito per email: {Email}", email);
            return RedirectToAction("Index", "Account");
        }

        public IActionResult Register(){
            
            return View();
        }
    }
}
