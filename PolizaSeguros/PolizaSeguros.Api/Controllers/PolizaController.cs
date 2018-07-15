namespace PolizaSeguros.Api.Controllers
{
	using System;
	using Model.DTO;
	using System.Threading.Tasks;
	using PolizaSeguros.Logic.Facades;
	using System.Web.Mvc;

	public class PolizaController : Controller
    {
		public PolizaFacade polizaFacade = new PolizaFacade();

		public ActionResult Create()
		{
			return View();
		}

	}
}