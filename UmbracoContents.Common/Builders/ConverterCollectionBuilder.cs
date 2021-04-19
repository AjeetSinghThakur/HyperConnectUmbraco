using UmbracoContents.Common.Converters;
using Umbraco.Core.Composing;

namespace UmbracoContents.Common.Builders
{
    public class ConverterCollectionBuilder : OrderedCollectionBuilderBase<ConverterCollectionBuilder,
        ConverterCollection, IConverter>
    {
        protected override ConverterCollectionBuilder This => this;
    }
}