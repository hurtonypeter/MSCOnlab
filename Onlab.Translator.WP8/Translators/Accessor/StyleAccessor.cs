using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Windows.Data.Xml.Dom;
using Windows.UI.Xaml;

namespace Onlab.Translator.WP8.Translators.Accessor
{
    public interface IStyleAccessor
    {
        List<Setter> GetSettersFor(string element = null, string id = null, string @class = null);
    }

    public class StyleAccessor : IStyleAccessor
    {
        private XmlDocument xml;

        #region singleton
        private static StyleAccessor instance = new StyleAccessor();

        protected StyleAccessor()
        {
            xml = new XmlDocument();
            xml.LoadXml(XDocument.Load("style.xml").ToString());
        }

        public static StyleAccessor Current
        {
            get { return instance; }
        }
        #endregion

        private KeyValuePair<string, string> styleToKeyValuePair(string str)
        {
            var splitted = str.Split(':');
            return new KeyValuePair<string, string>(splitted[0].Trim(), splitted[1].Trim());
        }

        public List<Setter> GetSettersFor(string element = null, string id = null, string @class = null)
        {
            var asd  = xml.DocumentElement.GetElementsByTagName("Style");

            var setters = new List<Setter>();

            if (element != null)
            {
                var xmlstyles = xml.DocumentElement.GetElementsByTagName("Style");
                var styles = xmlstyles.Select(s => new
                {
                    selector = s.Attributes.GetNamedItem("selector").NodeValue.ToString(),
                    value = s.Attributes.GetNamedItem("value").NodeValue.ToString()
                }).ToList();
                var current = styles.SingleOrDefault(s => s.selector == element);
                if (current != null)
                {
                    var listofstyles = current.value
                        .Split(';')
                        .Select(x => styleToKeyValuePair(x)).ToList();
                }
            }

            if (id != null)
            {

            }

            if (@class != null)
            {

            }

            return setters;
        }
    }
}
