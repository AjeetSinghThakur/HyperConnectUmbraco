using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Umbraco.Web.WebApi;

namespace HyperConnectUmbracoAPI.Controllers
{
    public class HomeController : UmbracoApiController
    {
        [AllowAnonymous]
        [HttpGet]
        public IEnumerable<string> GetAllProducts()
        {
            return new[] { "Table", "Chair", "Desk", "Computer" };
        }
    }
}
