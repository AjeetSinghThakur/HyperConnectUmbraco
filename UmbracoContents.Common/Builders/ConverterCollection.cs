using System.Collections.Generic;
using UmbracoContents.Common.Converters;
using Umbraco.Core.Composing;

namespace UmbracoContents.Common.Builders
{
    public class ConverterCollection : BuilderCollectionBase<IConverter>
    {
        public ConverterCollection(IEnumerable<IConverter> items)
            : base(items)
        { }
    }
}