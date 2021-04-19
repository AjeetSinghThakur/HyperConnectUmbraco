using System;
using System.Web.Mvc;
using System.Web.Routing;
using Umbraco.Core.Composing;

namespace TreatUmbraco
{
    public class RegisterCustomRouteComposer : ComponentComposer<RegisterCustomRouteComponent>
    {
    }
    public class RegisterCustomRouteComponent : IComponent
    {
        public void Initialize()
        {
            //Custom Routes
            RouteTable.Routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );
        }

        public void Terminate()
        {
            throw new NotImplementedException();
        }
    }
}