using PolizaSeguros.Logic.Facades;
using PolizaSeguros.Model.DTO;
using PolizaSeguros.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace PolizaSeguros.WebApi.Controllers
{
	[RoutePrefix("api/CoverageType")]
	public class TipoCoberturaController : ApiController
    {
		// GET: TipoCobertura
		[HttpGet]
		[Route("GetAll")]
		public GenericResponseDTO GetAll()
		{
			List<TipoCubrimiento> tipoCubrimientos = new List<TipoCubrimiento>();
			PolizaFacade entryFacade = new PolizaFacade();

			GenericResponseDTO result = entryFacade.GetAllTypesCoverage();

			return result;
		}
	}
}