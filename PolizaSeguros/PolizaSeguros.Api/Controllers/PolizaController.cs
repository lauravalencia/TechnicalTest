namespace PolizaSeguros.Api.Controllers
{
	using System;
	using Model.DTO;
	using System.Threading.Tasks;
	using System.Web.Http;
	using PolizaSeguros.Logic.Facades;

	[RoutePrefix("api/Policy")]
	public class PolizaController : ApiController
    {
		public PolizaFacade polizaFacade = new PolizaFacade();

		[HttpGet]
		[Route("Create")]
		public GenericResponseDTO Create(GenericResponseDTO genericObject)
		{
			if (genericObject == null) throw new ArgumentNullException(nameof(genericObject));
			//polizaFacade.
			return EntryToFacade(genericObject);
		}

	}
}