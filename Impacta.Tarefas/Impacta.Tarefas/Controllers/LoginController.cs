using System.Web.Mvc;
using Impacta.MOD;
using System.Web.Security;

namespace Impacta.Tarefas.Controllers
{
	public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
			Usuario usuario = null;
            return View(usuario);
        }

		public ActionResult AutenticarLogin(Usuario usuario)
		{
			FormsAuthentication.SetAuthCookie(usuario.Username, false);
			return RedirectToAction("Index", "RealBooks");
		}
		public ActionResult Logout()
		{
			FormsAuthentication.SignOut();
			return View("Autenticacao");
		}
    }
}