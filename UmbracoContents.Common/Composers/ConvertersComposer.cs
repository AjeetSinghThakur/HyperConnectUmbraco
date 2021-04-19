using System;
using System.Collections.Generic;
using System.Linq;
using UmbracoContents.Common.Converters;
using Umbraco.Core;
using Umbraco.Core.Composing;

namespace UmbracoContents.Common.Composers
{
    public class ConvertersComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            IEnumerable<Type> converters =
                GetType().Assembly.GetTypes().Where(x => x.Implements<IConverter>() && x.IsClass);
            foreach (Type converter in converters)
            {
                composition.Converters().Append(converter);
            }
        }
    }
}