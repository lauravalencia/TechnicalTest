namespace PolizaSeguros.Model.Model
{
	using System.Collections.Generic;

	public class TipoRiesgo
	{
		public int IdTipoRiesgo { get; set; }
		public string NombreTipoRiesgo { get; set; }

		//EntityFramework Section 
		public virtual List<Cliente> Clientes { get; set; }
		public virtual List<Poliza> Polizas { get; set; }
	}
}
