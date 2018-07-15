namespace PolizaSeguros.Common.Configuration
{
	using System;
	using System.Configuration;

	public class Configuration
	{
		private static string polizaDB = GetConnectionString(Common.Constants.PolizaSeguros.connectionString);

		private static string GetConnectionString(string connectionStringName)
		{
			return ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
		}
		public static string PolizaDB
		{
			get
			{
				if (string.IsNullOrEmpty(polizaDB))
				{
					throw new Exception(Common.Resources.ExceptionMessages.polizaConnectionStringError);
				}
				return polizaDB;
			}
		}

	}
}
