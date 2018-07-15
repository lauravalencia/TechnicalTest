namespace PolizaSeguros.Data.Repositories
{
	using Logic.Interfaces.Repositories;
	using Model.Model;
	using System;
	using System.Collections.Generic;
	using System.Data.Entity.Validation;
	using System.Linq;

	public class TipoRiesgosRepository
	{
		public ICollection<TipoRiesgo> GetAll()
		{
			using (PSContext cnx = new PSContext())
			{
				ICollection<TipoRiesgo> riesgos = (from item in cnx.TipoRiesgos
											   select item).ToList();

				return riesgos;
			}

		}
	}
}
