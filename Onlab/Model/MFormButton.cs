using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onlab.Model
{
    public class MFormButton : MFormElement
    {

        public string Text { get; set; }

        public MForm Form { get; private set; }

        public MButtonType Type { get; private set; }

        public MFormButton(MForm form, MButtonType type)
        {
            Form = form;
        }
    }
}
