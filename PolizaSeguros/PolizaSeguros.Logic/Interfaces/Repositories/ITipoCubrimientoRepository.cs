namespace PolizaSeguros.Logic.Interfaces.Repositories
{
	using PolizaSeguros.Model.Model;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public interface ITipoCubrimientoRepository
	{
		ICollection<TipoCubrimiento> GetAll();
	}
}
