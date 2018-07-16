using System;
using System.Collections.Generic;
using Microsoft.Owin;
using Owin;
using PolizaSeguros.Api;

[assembly: OwinStartup(typeof(PolizaSeguros.Api.Startup))]

namespace PolizaSeguros.Api
{
	public partial class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			ConfigureAuth(app);
		}
	}
}