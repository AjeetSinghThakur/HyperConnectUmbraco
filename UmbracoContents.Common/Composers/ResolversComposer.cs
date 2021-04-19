using UmbracoContents.Common.Resolvers;
using Umbraco.Core;
using Umbraco.Core.Composing;
using UmbracoContents.Common.Repositories;

namespace UmbracoContents.Common.Composers
{
    internal class ResolversComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Register<IContentResolver, ContentResolver>();
            composition.Register<IContentProviderService, ContentProviderService>();
        }
    }
}