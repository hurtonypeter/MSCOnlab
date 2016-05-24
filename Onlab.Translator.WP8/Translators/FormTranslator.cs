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
    public class FormTranslator : BaseTranslator<MForm>
    {
        public override UIElement Render(MForm model)
        {
            var formGrid = new Grid();

            foreach (var item in model.Elements)
            {
                var type = item.GetType();
                var translator = Container.GetTranslator(type);

                formGrid.Children.Add(translator.Render(item));
            }

            return formGrid;
        }
        
    }
}
