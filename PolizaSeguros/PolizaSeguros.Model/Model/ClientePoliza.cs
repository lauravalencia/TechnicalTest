namespace PolizaSeguros.Model.Model
{
	using System.Collections.Generic;

	public class ClientePoliza
	{
		public int IdClientePoliza { get; set; }
		public int IdCliente { get; set; }
		public int IdPoliza { get; set; }
		public int IdEstado { get; set; }

		//EntityFramework Section 
		public virtual Cliente Cliente { get; set; }
		public virtual Poliza Poliza { get; set; }
		public virtual Estado Estado { get; set; }
	}
}
