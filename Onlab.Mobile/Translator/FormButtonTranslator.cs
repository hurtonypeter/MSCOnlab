using Onlab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Onlab.Mobile.Translator
{
    public class FormButtonTranslator
    {
        public static UIElement Render(MFormButton button)
        {
            return new Button
            {
                Content = new TextBlock { Text = button.Text }
            };
        }
    }
}
