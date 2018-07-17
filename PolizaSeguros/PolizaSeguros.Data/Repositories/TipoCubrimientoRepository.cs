namespace PolizaSeguros.Data.Repositories
{
	using PolizaSeguros.Logic.Interfaces.Repositories;
	using PolizaSeguros.Model.Model;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class TipoCubrimientoRepository : ITipoCubrimientoRepository
	{
		public ICollection<TipoCubrimiento> GetAll()
		{
			using (PSContext cnx = new PSContext())
			{
				ICollection<TipoCubrimiento> cubrimientos = (from item in cnx.TipoCubrimientos
												   select item).ToList();

				return cubrimientos;
			}

		}
	}
}
