using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace Onlab.Mobile.Translator
{
    public interface ITranslator<T>
    {
        UIElement Render(T model);
    }
}
