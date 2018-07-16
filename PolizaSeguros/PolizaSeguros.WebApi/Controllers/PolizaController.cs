namespace PolizaSeguros.WebApi.Controllers
{
	using PolizaSeguros.Logic.Facades;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Web;
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