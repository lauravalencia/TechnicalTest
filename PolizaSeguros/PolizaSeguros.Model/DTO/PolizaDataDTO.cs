namespace PolizaSeguros.Model.DTO
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	public class PolizaDataDTO
	{
		public ICollection<ListDTO> TiposRiesgo { get; set; }
	}
}
