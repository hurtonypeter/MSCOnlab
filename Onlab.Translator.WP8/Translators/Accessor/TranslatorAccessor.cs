using Onlab.Translator.WP8.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Onlab.Translator.WP8.Translators.Accessor
{
    public interface ITranslatorAccessor
    {
        ITranslator GetTranslator(Type type);
    }

    public class TranslatorAccessor : ITranslatorAccessor
    {
        #region singleton
        private static TranslatorAccessor instance = new TranslatorAccessor();

        protected TranslatorAccessor() { }

        public static TranslatorAccessor Current {
            get { return instance; }
        }
        #endregion

        private Dictionary<string, ITranslator> translators = new Dictionary<string, ITranslator>();

        public ITranslator GetTranslator(Type type)
        {
            if (translators.ContainsKey(type.FullName))
            {
                return translators[type.FullName];
            }
            else
            {
                var types = (from x in GetType().GetTypeInfo().Assembly.DefinedTypes
                                let y = x.BaseType
                                where !x.IsAbstract && !x.IsInterface && x.ImplementedInterfaces.Contains(typeof(ITranslator)) &&
                                    x.ImplementedInterfaces.Any(i => i.GenericTypeArguments.Contains(type))
                                select x).ToList();
                //var types = (from x in GetType().GetTypeInfo().Assembly.DefinedTypes
                //          let y = x.BaseType
                //          where !x.IsAbstract && !x.IsInterface &&
                //                y != null && y.GenericTypeArguments.Count() > 0 && y.GetGenericTypeDefinition() == typeof(BaseTranslator<>) &&
                //                y.GenericTypeArguments.Contains(type)
                //          select x).ToList();

                TypeInfo translatorType;
                if (types.Count == 0)
                {
                    throw new Exception("Can't find translator for the given type!");
                }
                else if (types.Count == 1)
                {
                    translatorType = types.FirstOrDefault();
                }
                else if (types.Count == 2)
                {
                    translatorType = types[0].IsAssignableFrom(types[1]) ? types[1] : types[0];
                }
                else
                {
                    throw new Exception("Ambiguous translators found!");
                }

                var instance = Activator.CreateInstance(translatorType.AsType()) as ITranslator;
                translators.Add(type.FullName, instance);

                return instance;
            }
        }
    }
}
