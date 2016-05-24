using Onlab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Onlab.Translator.WP8.Translators
{
    public class FormTextBoxTranslator : BaseTranslator<MFormTextBox>
    {
        public override UIElement Render(MFormTextBox textbox)
        {
            return new TextBox
            {
                Text = textbox.Text
            };
        }
    }
}
