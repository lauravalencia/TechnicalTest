namespace PolizaSeguros.Model.Model
{
	using System.Collections.Generic;

	public class TipoDocumento
	{
		public int IdTipoDocumento { get; set; }
		public string NombreTipoDocumento { get; set; }
		
		//EntityFramework Section 
		public virtual List<Cliente> Clientes { get; set; }
	}
}
