using Onlab.Model;
using Onlab.Translator.WP8.Abstraction;
using Onlab.Translator.WP8.Translators.Accessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace Onlab.Translator.WP8.Translators
{
    public abstract class BaseTranslator<TModel> : ITranslator<TModel> where TModel : IMElement
    {
        public UIElement Render(object model)
        {
            return Render((TModel)model);
        }

        public abstract UIElement Render(TModel model);

        protected IStyleAccessor Styles { get { return StyleAccessor.Current; } }

        protected ITranslatorAccessor Container { get { return TranslatorAccessor.Current; } }
    }
}
