using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace MXTires.Microdata.Validators
{
    class NamespaceTypes
    {
        public static List<string> GetClasses(string nameSpace)
        {
            Assembly asm = Assembly.GetExecutingAssembly();

            List<string> namespacelist = new List<string>();
            List<string> classlist = new List<string>();

            foreach (Type type in asm.GetTypes())
            {
                if (type.Namespace == nameSpace)
                    namespacelist.Add(type.Name);
            }

            foreach (string classname in namespacelist)
                classlist.Add(classname);

            return classlist;
        }

        public static List<Type> GetNamespaceTypes(string nameSpace, IList<string> exclude)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            List<Type> typelist = new List<Type>();

            foreach (Type type in asm.GetTypes())
            {
                if (type.Namespace == nameSpace && (exclude == null || exclude.IndexOf(type.Name) == -1))
                    typelist.Add(type);
            }

            return typelist;
        }
    }
}
