namespace PolizaSeguros.Model.Model
{
	using System.Collections.Generic;

	public class Cliente
	{
		public int IdCliente { get; set; }
		public string NombreCiente { get; set; }
		public int IdTipoDocumento { get; set; }

		//EntityFramework Section
		public virtual TipoDocumento TipoDocumento { get; set; }
		public virtual List<ClientePoliza> ClientePolizas { get; set; }
	}
}
