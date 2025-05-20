using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class TransactionController : Controller
    {
        // GET: TransactionController
        // Mostra tutte transazioni
        public ActionResult Index()
        {
            return View();
        }
        // 
    }
}
