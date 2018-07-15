namespace PolizaSeguros.Model.Model
{
	using System;
	using System.Collections.Generic;

	public class Poliza
	{
		public int IdPoliza { get; set; }
		public string NombrePoliza { get; set; }
		public string DescripcionPoliza { get; set; }
		public DateTime FechaInicioVigencia { get; set; }
		public int PrecioPoliza { get; set; }
		public int IdTipoRiesgo { get; set; }

		//EntityFramework Section
		public virtual TipoRiesgo TipoRiesgo { get; set; }
		//EntityFramework Section 
		public virtual List<ClientePoliza> ClientePolizas { get; set; }
		public virtual List<PolizaTipoCubrimiento> PolizaTipoCubrimientos { get; set; }
	}
}
