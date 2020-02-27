using System.Web.Mvc;
using Cadastro.Aplicacao;
using Cadastro.Dominio;

namespace Cadastro.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}