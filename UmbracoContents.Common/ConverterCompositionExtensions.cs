using UmbracoContents.Common.Builders;
using Umbraco.Core.Composing;

namespace UmbracoContents.Common
{
    public static class ConverterCompositionExtensions
    {
        public static ConverterCollectionBuilder Converters(this Composition composition)
        {
            return composition.WithCollectionBuilder<ConverterCollectionBuilder>();
        }
    }
}