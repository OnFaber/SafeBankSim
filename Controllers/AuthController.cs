using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class AuthController : Controller
    {
        private readonly AuthService _authService;
        private readonly UserService _userService;
        private readonly ILogger<AuthController> _logger;

        public AuthController(AuthService authService, UserService userService, ILogger<AuthController> logger)
        {
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
        public IActionResult Index(LoginViewModel model)
        {
            var user = _userService.FindByEmail(model.Email);
            if (user == null || !_authService.VerifyPassword(model.Password, user.PasswordHash, user.Salt))
            {
                _logger.LogWarning("Login fallito per email: {Email} con password {Password}. Utente trovato? {UserFound}", model.Email, model.Password, user != null);
                ViewBag.Error = "credenziali errate";


                return View();
            }

            HttpContext.Session.SetString("UserId", user.Id.ToString());
            HttpContext.Session.SetString("UserEmail", user.Email);

            _logger.LogInformation("Login riuscito per email: {Email}", model.Email);
            return RedirectToAction("Index", "Account");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string nome, string cognome, string email, string plainPassword, AuthService authService)
        {
            Guid guid = Guid.NewGuid();
            string salt;
            string hash = _authService.HashPassword(plainPassword, out salt);

            var account = new AccountModel
            {
                Id = Guid.NewGuid(),
                Nome = nome,
                Cognome = cognome,
                Email = email,
                PasswordHash = hash,
                Salt = salt,
            };

            _userService.Add(account);
            _logger.LogWarning("Login per email: {Email} con password {Password}.", email, plainPassword);
            return RedirectToAction("Index", "Auth");
        }
    }
}
