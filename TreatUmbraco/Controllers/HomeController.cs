using System.Threading.Tasks;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using UmbracoContents.Common.Repositories;

namespace TreatUmbraco.Controllers
{
    public class HomeController : RenderMvcController
    {
        private readonly IContentProviderService _contentProviderService;
        public HomeController(IContentProviderService contentProviderService)
        {
            _contentProviderService = contentProviderService;
        }

        public async Task<ActionResult> Index()
        {
            var contentModel = await _contentProviderService.GetContent(1059);
            return View();
        }
    }
}