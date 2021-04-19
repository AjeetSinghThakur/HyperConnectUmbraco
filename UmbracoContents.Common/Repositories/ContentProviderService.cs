using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Core.Services;
using Umbraco.Web.PublishedCache;
using UmbracoContents.Common.Models;
using UmbracoContents.Common.Resolvers;

namespace UmbracoContents.Common.Repositories
{
    public class ContentProviderService : IContentProviderService
    {
        private readonly Lazy<IContentResolver> _contentResolver;
        private readonly IContentService _contentService;
        private readonly IPublishedSnapshotService _publishedSnapshotService;
        private readonly IUserService _userService;
        public ContentProviderService(Lazy<IContentResolver> contentResolver,
                                      IContentService contentService,
                                      IPublishedSnapshotService publishedSnapshotService,
                                      IUserService userService)
        {
            _contentService = contentService;
            _publishedSnapshotService = publishedSnapshotService;
            _userService = userService;
            _contentResolver = contentResolver;
        }
        public async Task<ContentModel> GetContent(int contentId)
        {
            IPublishedContent content = _publishedSnapshotService.CreatePublishedSnapshot(
                    _publishedSnapshotService.EnterPreview(
                        _userService.GetUserById(1),
                        _contentService.GetById(contentId).Id))
                .Content.GetById(contentId);

            ContentModel contentModel = _contentResolver.Value.ResolveContent(content);

            return await Task.Run(() => contentModel);
        }
    }
}
