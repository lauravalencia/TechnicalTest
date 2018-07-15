namespace PolizaSeguros.Logic.Services
{
	using PolizaSeguros.Logic.Interfaces.Repositories;
	using PolizaSeguros.Logic.Interfaces.Services;
	using PolizaSeguros.Model.DTO;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public partial class TipoRiesgoService : ITipoRiesgoService
	{
		private ITipoRiesgoRepository _tipoRiesgoRepository;

		public TipoRiesgoService
		(
			ITipoRiesgoRepository tipoRiesgoRepository
		)
		{
			_tipoRiesgoRepository = tipoRiesgoRepository;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public GenericResponseDTO GetAll()
		{
			PolizaDataDTO polizaDataDTO = new PolizaDataDTO();

			try
			{
				var typesRisk = (from c in _tipoRiesgoRepository.GetAll()
								 select new { c.IdTipoRiesgo, c.NombreTipoRiesgo }).ToList();

				polizaDataDTO.TiposRiesgo = new List<ListDTO>();

				foreach (var item in typesRisk)
				{
					polizaDataDTO.TiposRiesgo.Add(new ListDTO { Id = item.IdTipoRiesgo, Name = item.NombreTipoRiesgo });
				}

				return new GenericResponseDTO()
				{
					OperationSuccess = true,
					ObjectResponse = polizaDataDTO
				};
			}
			catch (Exception)
			{

				throw;
			}
		}
	}
}
