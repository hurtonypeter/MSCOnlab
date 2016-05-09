using Onlab.Model;
using Onlab.Web.Framework.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace Onlab.Web.Framework.Translator
{
    public class ModelTranslator
    {
        public static MPage Translate(object model)
        {
            var page = new MPage();

            Type modelType = model.GetType();

            var modelAttr = modelType.GetCustomAttribute<ModelTypeAttribute>();

            if (modelAttr != null && modelAttr.ModelType == ModelTypes.Form)
            {
                var form = new MForm();

                foreach (PropertyInfo property in modelType.GetProperties())
                {
                    var propAttr = property.GetCustomAttribute<ModelTypeAttribute>();
                    if (propAttr != null)
                    {
                        if (property.PropertyType.IsPrimitive || property.PropertyType == typeof(string))
                        {
                            switch (property.PropertyType.Name)
                            {
                                case "String":
                                    if (propAttr.ModelType == ModelTypes.Edit)
                                    {
                                        form.Elements.Add(new MFormTextBox { Text = (string)property.GetValue(model) });
                                    }
                                    else if (propAttr.ModelType == ModelTypes.Display)
                                    {
                                        form.Elements.Add(new MFormText { Text = (string)property.GetValue(model) });
                                    }
                                    break;
                            }

                        }
                        else
                        {
                            // egy osztály típus, tehát őt is ki kell bontani
                        }

                    }
                }

                page.Elements.Add(form);
            }

            return page;
        }
    }
}