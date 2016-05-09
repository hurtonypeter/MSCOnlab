using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onlab.DataStructure
{
    public class MForm : MElement
    {
        public string TargetUri { get; set; }

        public List<MFormElement> Elements { get; set; }
    }
}
