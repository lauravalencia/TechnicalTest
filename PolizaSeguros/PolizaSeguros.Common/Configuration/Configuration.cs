namespace PolizaSeguros.Common.Configuration
{
	using System;
	using System.Configuration;

	public class Configuration
	{
		private static string polizaDB = GetConnectionString(Common.Constants.PolizaSeguros.connectionString);
		private static object unityConfiguration = GetConfigurationSection(Common.Constants.PolizaSeguros.UnitySection);

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

		public static object UnitySection
		{
			get
			{
				if (unityConfiguration == null)
				{
					throw new Exception(Common.Resources.ExceptionMessages.UnityNotFound);
				}
				return unityConfiguration;
			}
		}

		private static object GetConfigurationSection(string sectionName)
		{
			return ConfigurationManager.GetSection(sectionName);
		}

	}
}
