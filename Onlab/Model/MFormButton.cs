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

        public MForm Form { get; set; }

        public MFormButton(MForm form)
        {
            Form = form;
        }
    }

    public enum MFormButtonType
    {
        Submit
    }
}
