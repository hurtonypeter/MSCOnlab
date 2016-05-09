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
    public class FormTranslator
    {
        public static UIElement Render(MForm form)
        {
            var formGrid = new Grid();

            foreach (var item in form.Elements)
            {
                switch (item.GetType().Name)
                {
                    case "MFormButton":
                        formGrid.Children.Add(FormButtonTranslator.Render((MFormButton)item));
                        break;
                    case "MFormTextBox":
                        formGrid.Children.Add(FormTextBoxTranslator.Render((MFormTextBox)item));
                        break;
                }
            }

            return formGrid;
        }
    }
}
