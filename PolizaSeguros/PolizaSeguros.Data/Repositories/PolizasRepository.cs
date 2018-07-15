namespace PolizaSeguros.Data.Repositories
{
	using Logic.Interfaces.Repositories;
	using Model.Model;
	using System;
	using System.Collections.Generic;
	using System.Data.Entity.Validation;
	using System.Linq;

	public class PolizasRepository : IPolizasRepository
	{
		public void Create(Poliza entidad)
		{
			using (PSContext cnx = new PSContext())
			{
				cnx.Polizas.Add(entidad);
				cnx.SaveChanges();
			}
		}

		public bool Edit(Poliza entidad)
		{
			using (PSContext cnx = new PSContext())
			{
				Poliza poliza = cnx.Polizas.Find(entidad.IdPoliza);

				if (poliza != null)
				{
					poliza.IdTipoRiesgo = entidad.IdTipoRiesgo;
					poliza.NombrePoliza = entidad.NombrePoliza;
					poliza.PrecioPoliza = entidad.PrecioPoliza;
					poliza.FechaInicioVigencia = entidad.FechaInicioVigencia;
					poliza.DescripcionPoliza = entidad.DescripcionPoliza;
					cnx.SaveChanges();
					return true;
				}

				return false;
			}
		}

		public ICollection<Poliza> ReadAll()
		{
			using (PSContext cnx = new PSContext())
			{
				ICollection<Poliza> polizas = (from item in cnx.Polizas
												select item).ToList();

				return polizas;
			}

		}

		public bool Delete(Poliza poliza)
		{
			using (PSContext cnx = new PSContext())
			{
				try
				{
					Poliza findPoliza = (from p in cnx.Polizas
								where p.IdPoliza == poliza.IdPoliza
								select p).FirstOrDefault();

					if(findPoliza != null)
					{
						cnx.Polizas.Remove(findPoliza);
						cnx.SaveChanges();
						return true;
					}

					return false;
					
				}
				catch (DbEntityValidationException)
				{
					throw new Exception();
				}
				catch (Exception ex)
				{
					throw new Exception();
				}
			}

		}
	}
}
