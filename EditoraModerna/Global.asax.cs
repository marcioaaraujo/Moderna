using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace EditoraModerna
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            GestaoConvidado.Mappers.AutoMapperConfig.RegisterMappings();
            GestaoEvento.Mappers.AutoMapperConfig.RegisterMappings();
            IdentidadeAcesso.Mappers.AutoMapperConfig.RegisterMappings();
        }
    }
}
