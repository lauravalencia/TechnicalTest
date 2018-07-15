namespace PolizaSeguros.Logic.Facades
{
	using PolizaSeguros.Model.DTO;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using Microsoft.Practices.Unity;
	using PolizaSeguros.Common.Unity;
	using PolizaSeguros.Logic.Interfaces.Services;
	using PolizaSeguros.Model.Model;
	using Newtonsoft.Json;

	public class PolizaFacade
	{
		private GenericResponseDTO CreatePoliza(GenericResponseDTO genericObject)
		{
			try
			{
				using (var container = new ContainerFactory())
				{
					IPolizasService policyService = container.GetContainer().Resolve<IPolizasService>();

					Poliza dto = JsonConvert.DeserializeObject<Poliza>(genericObject.ObjectResponse.ToString());
					return policyService.Create(dto);
						
				}
			}
			catch (Exception)
			{

				throw;
			}
		}
	}
}
