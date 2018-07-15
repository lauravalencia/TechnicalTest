namespace PolizaSeguros.Logic.Interfaces.Services
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using PolizaSeguros.Model.DTO;

	public interface ITipoRiesgoService
	{
		GenericResponseDTO GetAll();
	}
}
