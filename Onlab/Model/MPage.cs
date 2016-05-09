using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onlab.Model
{
    public class MPage
    {
        public List<MElement> Elements { get; set; }

        public MPage()
        {
            Elements = new List<MElement>();
        }
    }
}
