namespace PolizaSeguros.Logic.Interfaces.Repositories
{
	using PolizaSeguros.Model.Model;
	using System;
	using System.Collections.Generic;

	public interface ITipoRiesgoRepository
	{
		ICollection<TipoRiesgo> GetAll();
	}
}
