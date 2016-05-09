using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Onlab.Web.Framework.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class ModelTypeAttribute : Attribute
    {
        readonly ModelTypes type;
        
        public ModelTypeAttribute(ModelTypes _type)
        {
            this.type = _type;
        }

        public ModelTypes ModelType
        {
            get { return type; }
        }
    }

    public enum ModelTypes
    {
        Edit,
        Display,
        Form,
        Hidden
    }
}