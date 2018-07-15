namespace PolizaSeguros.Model.Model
{
	using System;
	using System.Collections.Generic;

	public class PolizaTipoCubrimiento
	{
		public int IdPolizaCubrimiento { get; set; }
		public int IdPoliza { get; set; }
		public int IdTipoCubrimiento { get; set; }

		//EntityFramework Section
		public virtual Poliza Poliza { get; set; }
		public virtual TipoCubrimiento TipoCubrimiento { get; set; }

	}
}
