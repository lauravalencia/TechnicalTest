namespace PolizaSeguros.Logic.Interfaces.Services
{
	using PolizaSeguros.Model.DTO;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public interface ITipoCubrimientoService
	{
		GenericResponseDTO GetAll();
	}
}
