using System;
using System.Web.Mvc;
using System.Web.Routing;
using Umbraco.Core.Composing;

namespace HyperConnectUmbracoAPI
{
    public class RegisterCustomRouteComposer : ComponentComposer<RegisterCustomRouteComponent>
    {
    }
    public class RegisterCustomRouteComponent : IComponent
    {
        public void Initialize()
        {
           // GlobalConfiguration.Configuration.MapHttpAttributeRoutes();
        }

        public void Terminate()
        {
            throw new NotImplementedException();
        }
    }
}