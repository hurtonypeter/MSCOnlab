using Onlab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Onlab.Translator.XAML
{
    public class PageTranslator
    {
        UIElement Render(MPage page)
        {
            UIElement rendered = new Grid();

            foreach (var item in page.Elements)
            {
                switch (item.GetType().ToString())
                {
                    case "MForm":
                        var itemRenderer = new FormTranslator();
                        break;
                }
            }

            return rendered;
        }
    }
}
