namespace PolizaSeguros.Logic.Interfaces.Repositories
{
	using PolizaSeguros.Model.Model;
	using System;
	using System.Collections.Generic;

	public interface IPolizasRepository
	{
		void Create(Poliza entidad);
		bool Edit(Poliza entidad);
		ICollection<Poliza> ReadAll();
		bool Delete(Poliza poliza);
	}
}
