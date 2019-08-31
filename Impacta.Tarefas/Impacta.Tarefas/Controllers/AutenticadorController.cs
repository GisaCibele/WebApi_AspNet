using Impacta.MOD;
using System.Web.Mvc;

namespace Impacta.Tarefas.Controllers
{
	public class AutenticadorController : Controller
    {
        // GET: Autenticador
        public ActionResult Formulario()
        {
            return View();
        }
		public ActionResult Entrar(Usuario usuario)
		{
			if (usuario.Username != null && usuario.Password != null &&
				usuario.Username.Equals("Gisele") && usuario.Password.Equals("1234"))
			{
				Session["Usuario"] = usuario;
				return RedirectToAction("Index", "RealBooks");

			}
			else
			{
				ViewBag.Mensagem = "Usuario ou senha incorretos";
				return View("Formulario");
			}
		}
		public ActionResult Sair()
		{
			Session.Abandon();
			return RedirectToAction("Formulario", "Autenticador");
		}
	}
}