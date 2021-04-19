
using System.Threading.Tasks;
using UmbracoContents.Common.Models;

namespace UmbracoContents.Common.Repositories
{
    public interface IContentProviderService
    {
        Task<ContentModel> GetContent(int contentId);
    }
}
