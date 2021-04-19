using System.Collections.Generic;
using UmbracoContents.Common.Models;
using Umbraco.Core.Models.PublishedContent;

namespace UmbracoContents.Common.Resolvers
{
    public interface IContentResolver
    {
        ContentModel ResolveContent(IPublishedElement content, Dictionary<string, object> options = null);
    }
}