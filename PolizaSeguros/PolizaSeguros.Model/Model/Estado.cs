namespace PolizaSeguros.Model.Model
{
	using System.Collections.Generic;

	public class Estado
	{
		public int IdEstado { get; set; }
		public string NombreEstado { get; set; }

		//EntityFramework Section 
		public virtual List<ClientePoliza> ClientePolizas { get; set; }
	}
}
