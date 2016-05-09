using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onlab.Model
{
    public class MForm : MElement
    {
        public string TargetUri { get; set; }

        public List<MFormElement> Elements { get; set; }

        public MForm()
        {
            Elements = new List<MFormElement>();
        }

        public void AddButton()
        {

        }
    }
}
