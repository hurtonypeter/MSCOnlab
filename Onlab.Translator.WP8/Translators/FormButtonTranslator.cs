using Onlab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Documents;

namespace Onlab.Translator.WP8.Translators
{
    public class FormButtonTranslator : BaseTranslator<MFormButton>
    {
        public override UIElement Render(MFormButton button)
        {
            var ret = new Button
            {
                Content = new TextBlock { Text = button.Text },
                Style = new Style(typeof(Button))
            };

            var setters = Styles.GetSettersFor(element: nameof(Button));
            foreach (var item in setters)
            {
                ret.Style.Setters.Add(item);
            }

            return ret;
        }
    }
}
