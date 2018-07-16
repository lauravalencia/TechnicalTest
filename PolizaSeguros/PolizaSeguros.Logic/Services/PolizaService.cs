namespace PolizaSeguros.Logic.Services
{
	using PolizaSeguros.Logic.Interfaces.Repositories;
	using PolizaSeguros.Logic.Interfaces.Services;
	using PolizaSeguros.Model.DTO;
	using PolizaSeguros.Model.Model;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class PolizaService : IPolizasService
	{
		private IPolizasRepository _polizaRepository;

		public PolizaService
		(
			IPolizasRepository polizaRepository
		)
		{
			_polizaRepository = polizaRepository;
		}

		public GenericResponseDTO Create(Poliza item)
		{

			return new GenericResponseDTO()
			{
				OperationSuccess = true,
				ObjectResponse = ""
			};
		}

		public GenericResponseDTO Update(Poliza item)
		{

			return new GenericResponseDTO()
			{
				OperationSuccess = true,
				ObjectResponse = ""
			};

		}

		public GenericResponseDTO Delete(Poliza item)
		{

			return new GenericResponseDTO()
			{
				OperationSuccess = true,
				ObjectResponse = ""
			};

		}

	}
}
