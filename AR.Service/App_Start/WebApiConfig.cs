using System.Web.Http;

namespace AR.Service.App_Start
{
  public class WebApiConfig
  {
    public static void Configure(HttpConfiguration config) {
      config.MapHttpAttributeRoutes();

      config.Routes.MapHttpRoute(
          name: "DefaultApi",
          routeTemplate: "api/{controller}/{id}",
          defaults: new { id = RouteParameter.Optional }
      );
    }
  }
}