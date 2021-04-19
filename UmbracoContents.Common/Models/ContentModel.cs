using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UmbracoContents.Common.Models
{
    public class ContentModel
    {
        public SystemModel System { get; set; }
        public Dictionary<string, object> Fields { get; set; }
    }
}