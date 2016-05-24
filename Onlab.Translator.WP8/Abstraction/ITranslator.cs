using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace Onlab.Translator.WP8.Abstraction
{
    public interface ITranslator
    {
        UIElement Render(object model);
    }

    public interface ITranslator<T> : ITranslator
    {
        UIElement Render(T model);
    }
}
