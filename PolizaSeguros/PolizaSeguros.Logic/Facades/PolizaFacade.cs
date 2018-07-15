﻿namespace PolizaSeguros.Logic.Facades
{
	using System;
	using Microsoft.Practices.Unity;
	using PolizaSeguros.Common.Unity;
	using PolizaSeguros.Logic.Interfaces.Services;
	using PolizaSeguros.Model.Model;
	using PolizaSeguros.Model.DTO;
	using Newtonsoft.Json;

	public class PolizaFacade
	{
		public GenericResponseDTO CreatePoliza(GenericResponseDTO genericObject)
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

		public GenericResponseDTO GetAllTypesRisk()
		{
			try
			{
				using (var container = new ContainerFactory())
				{
					ITipoRiesgoService riskService = container.GetContainer().Resolve<ITipoRiesgoService>();

					return riskService.GetAll();
				}
			}
			catch (Exception)
			{

				throw;
			}
		}
	}
}
