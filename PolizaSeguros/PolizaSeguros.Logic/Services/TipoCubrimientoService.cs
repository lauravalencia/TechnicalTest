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

	public class TipoCubrimientoService: ITipoCubrimientoService
	{
		private ITipoCubrimientoRepository _tipoCubrimientoRepository;
		public TipoCubrimientoService
		(
			ITipoCubrimientoRepository tipoCubrimientoRepository
		)
		{
			_tipoCubrimientoRepository = tipoCubrimientoRepository;
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
				var typesCoverage = (from c in _tipoCubrimientoRepository.GetAll()
								 select new { c.IdTipoCubrimiento, c.NombreCubrimiento }).ToList();

				polizaDataDTO.TiposCubrimiento = new List<ListDTO>();

				foreach (var item in typesCoverage)
				{
					polizaDataDTO.TiposCubrimiento.Add(new ListDTO { Id = item.IdTipoCubrimiento, Name = item.NombreCubrimiento });
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
