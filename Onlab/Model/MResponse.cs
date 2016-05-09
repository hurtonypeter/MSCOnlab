using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onlab.Model
{
    public class MResponse
    {
        public bool Success { get; set; }

        public List<string> Messages { get; set; }

        public MAction NextAction { get; set; }

        public MPage NextPage { get; set; }
    }

    public enum MAction
    {
        RenderPage
    }
}
