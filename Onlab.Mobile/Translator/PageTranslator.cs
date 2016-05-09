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

namespace Onlab.Mobile.Translator
{
    public class PageTranslator
    {
        public static UIElement Render(MPage page)
        {
            Grid grid = new Grid();

            foreach (var item in page.Elements)
            {
                var type = item.GetType().Name;
                switch (type)
                {
                    case "MForm":
                        grid.Children.Add(FormTranslator.Render((MForm)item));
                        break;
                }
            }

            return grid;
        }
    }
}
