using Onlab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Onlab.Translator.WP8.Translators
{
    public class PageTranslator : BaseTranslator<MPage>
    {
        public override UIElement Render(MPage page)
        {
            Grid grid = new Grid();

            foreach (var item in page.Elements)
            {
                var type = item.GetType();
                var translator = Container.GetTranslator(type);

                grid.Children.Add(translator.Render(item));
            }

            return grid;
        }
    }
}
