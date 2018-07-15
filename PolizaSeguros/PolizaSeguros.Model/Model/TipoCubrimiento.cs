namespace PolizaSeguros.Model.Model
{
	using System.Collections.Generic;

	public class TipoCubrimiento
	{
		public int IdTipoCubrimiento { get; set; }
		public string NombreCubrimiento { get; set; }

		//EntityFramework Section 
		public virtual List<PolizaTipoCubrimiento> PolizaTipoCubrimientos { get; set; }
	}
}
