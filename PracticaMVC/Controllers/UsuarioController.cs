using Microsoft.AspNetCore.Mvc;

namespace PracticaMVC.Controllers
{
	public class UsuarioController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
