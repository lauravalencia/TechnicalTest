namespace PolizaSeguros.WebApi.Controllers
{
	using PolizaSeguros.Common.Helpers;
	using PolizaSeguros.Logic.Facades;
	using PolizaSeguros.Model.DTO;
	using PolizaSeguros.Model.Model;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Web;
	using System.Web.Mvc;

	public class PolizaController : Controller
    {
		public PolizaFacade polizaFacade = new PolizaFacade();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="vm"></param>
		/// <returns></returns>
		[HttpPost]
		public JsonResult Create(Poliza vm)
		{
			if (ModelState.IsValid)
			{
				try
				{
					GenericResponseDTO response =  polizaFacade.CreatePoliza(vm);
					return SerializeAndSendResponse(response);
				}
				catch (Exception ex)
				{
					return SerializeAndSendResponse(new GenericResponseDTO()
					{
						OperationSuccess = false,
						ErrorMessage = ex.Message.ToString()
					});
				}

			}
			return SerializeAndSendResponse(new GenericResponseDTO()
			{
				OperationSuccess = false
			});
		}

		#region Métodos

		private JsonResult SerializeAndSendResponse(object response)
		{
			return Json(JsonHelper.Serialize(response), JsonRequestBehavior.AllowGet);
		}

		#endregion
	}
}