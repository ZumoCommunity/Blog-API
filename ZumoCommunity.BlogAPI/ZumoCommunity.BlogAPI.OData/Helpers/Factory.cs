using System;
using System.Threading.Tasks;
using ZumoCommunity.BlogAPI.Data.Context;

namespace ZumoCommunity.BlogAPI.OData.Helpers
{
	public static class Factory
	{
		public static async Task<DataContext> GetDataContextAsync()
		{
			var connectionString = await WebApiApplication.ConfigurationProvider.GetConfigValueAsync("Database");
			return new DataContext(connectionString);
		}
	}
}