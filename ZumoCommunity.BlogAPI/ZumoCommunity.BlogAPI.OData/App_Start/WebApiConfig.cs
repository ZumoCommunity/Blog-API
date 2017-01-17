using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;
using ZumoCommunity.BlogAPI.Data.Entity;

namespace ZumoCommunity.BlogAPI.OData
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			// Web API configuration and services

			var cors = new EnableCorsAttribute("*", "*", "*");
			config.EnableCors(cors);

			// Web API routes
			//config.MapHttpAttributeRoutes();

			var builder = new ODataConventionModelBuilder();
			config.Count().Filter().OrderBy().Expand().Select().MaxTop(null);

			builder.EntitySet<Post>("Posts");
			builder.EntitySet<Tag>("Tags");

			config.MapODataServiceRoute("odata", "odata/v1", builder.GetEdmModel());
		}
	}
}
