using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using Oak;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Reflection;
using System.IO;

namespace System
{
    [DebuggerNonUserCode]
    public static class TypeExtensions
    {
        public static bool IsOfType<T>(this object o)
        {
            return o.GetType() == typeof(T);
        }

        public static bool IsOfKind<T>(this object o)
        {
            return o is T;
        }

        public static IDictionary<string, object> Exclude(this IDictionary<string, object> dictionary, params string[] keys)
        {
            var result = dictionary.Where(s => !keys.Contains(s.Key)).ToDictionary(s => s.Key, s => s.Value);

            return new Dictionary<string, object>(result, StringComparer.OrdinalIgnoreCase);
        }

        public static Stream FromBeginning(this Stream s)
        {
            s.Seek(0, SeekOrigin.Begin);
            return s;
        }

        public static string CollectionToString(this object[] args)
        {
            if (args == null) return "";

            var s = "";
            for (int i = 0; i < args.Length; i++)
            {
                s += "[" + i + "] " + args[i] + Environment.NewLine;
            }

            return s;
        }
    }

    [DebuggerNonUserCode]
    public static class DynamicExtensions
    {
        public static bool CanConvertToPrototype(this object o)
        {
            return (o is Prototype) || 
                (o is NameValueCollection) || 
                (o is ExpandoObject) || 
                (o is Gemini) || 
                (o is IDictionary<string, object>);
        }

        public static dynamic ToPrototype(this object o)
        {
            var result = new Prototype();
            var d = result as IDictionary<string, object>;

            if (o.GetType() == typeof(Prototype)) return o;
            if (o is ExpandoObject) return new Prototype(o as IDictionary<string, object>);
            if (o is IDictionary<string, object>) return new Prototype(o as IDictionary<string, object>);
            if (o is Gemini) return ((Gemini)o).Prototype;

            if (o.GetType() == typeof(NameValueCollection) || o.GetType().IsSubclassOf(typeof(NameValueCollection)))
            {
                var nv = (NameValueCollection)o;
                nv.Cast<string>().Select(key => new KeyValuePair<string, object>(key, nv[key])).ToList().ForEach(i => d.Add(i));
            }
            else
            {
                var props = o.GetType().GetProperties();
                foreach (var item in props)
                {
                    d.Add(item.Name, item.GetValue(o, null));
                }
            }
            return result;
        }

        public static IDictionary<string, object> ToDictionary(this object thingy)
        {
            return (IDictionary<string, object>)thingy.ToPrototype();
        }
    }
}