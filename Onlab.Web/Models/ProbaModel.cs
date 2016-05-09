using Onlab.Web.Framework.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Onlab.Web.Models
{
    [ModelType(ModelTypes.Form)]
    public class ProbaModel
    {
        [ModelType(ModelTypes.Hidden)]
        public int Id { get; set; }

        [ModelType(ModelTypes.Edit)]
        public string Name { get; set; }
    }
}