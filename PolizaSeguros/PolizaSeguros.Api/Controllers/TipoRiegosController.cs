namespace PolizaSeguros.Api.Controllers
{
	using PolizaSeguros.Logic.Facades;
	using PolizaSeguros.Model.DTO;
	using PolizaSeguros.Model.Model;
	using System;
	using System.Collections.Generic;
	using System.Web.Http;
	using System.Web.Http.Results;

	//[Authorize]
	[RoutePrefix("api/RiskType")]
	public class TipoRiegosController : ApiController
    {
        // GET: TipoRiegos
		[HttpGet]
		[Route("GetAll")]
		public GenericResponseDTO GetAll()
        {
			List<TipoRiesgo> tiposRiesgo = new List<TipoRiesgo>();
			PolizaFacade entryFacade = new PolizaFacade();

			GenericResponseDTO result =  entryFacade.GetAllTypesRisk();

			return result;
        }
    }
}