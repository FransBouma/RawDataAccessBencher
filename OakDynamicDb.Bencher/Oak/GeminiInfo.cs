using System;
using System.Collections.Generic;
using System.Text;

namespace Oak
{
    public class GeminiInfo
    {
        public static string Parse(dynamic o)
        {
            var sb = new StringBuilder();
            Parse(sb, "this", o, 0, new List<object>());
            return sb.ToString();
        }

        public static bool IsValueType(object o)
        {
            if (o == null) return false;

            return o is string || o.GetType().IsValueType;
        }

        public static void Parse(StringBuilder stringBuilder, string name, dynamic o, int tab, List<object> encounteredObjects)
        {
            if (encounteredObjects.Contains(o))
            {
                WriteName(stringBuilder, tab, name, "circular", null);

                return;
            }

            if (!IsValueType(o) && !IsNull(o)) encounteredObjects.Add(o);

            if (o is Gemini)
            {
                WriteName(stringBuilder, tab, name, o.GetType().Name, null);

                WriteDictionary(stringBuilder, o.Hash(), tab, encounteredObjects);
            }
            else if (o is IEnumerable<dynamic>)
            {
                WriteName(stringBuilder, tab, name, "IEnumerable<dynamic>", null);
                int index = 0;
                foreach (var r in o as IEnumerable<dynamic>)
                {
                    Parse(stringBuilder, string.Format("[{0}]", index), r, tab + 1, encounteredObjects);
                    index++;
                }
            }
            else if (o is Prototype)
            {
                WriteName(stringBuilder, tab, name, o.GetType().Name, null);

                WriteDictionary(stringBuilder, o, tab, encounteredObjects);
            }
            else
            {
                if (!IsNull(o)) WriteName(stringBuilder, tab, name, o.GetType().Name, o);

                else WriteName(stringBuilder, tab, name, "null", null);
            }
        }

        public static bool IsNull(dynamic o)
        {
            return ReferenceEquals(o, null);
        }

        public static void WriteDictionary(StringBuilder stringBuilder, IDictionary<string, object> o, int tab, List<object> encounteredObjects)
        {
            foreach (var kvp in o) Parse(stringBuilder, kvp.Key, kvp.Value, tab + 1, encounteredObjects);
        }

        public static void WriteName(StringBuilder stringBuilder, int tabIndent, string name, string meta, dynamic value)
        {
            WriteTabs(stringBuilder, tabIndent);
            stringBuilder.Append(name);

            if (string.IsNullOrEmpty(meta) == false)
            {
                stringBuilder.Append(" (" + meta + ")");
            }

            if (!IsNull(value) && !(value is Delegate))
            {
                stringBuilder.Append(": ");

                stringBuilder.Append(value.ToString());
            }

            stringBuilder.Append(Environment.NewLine);
        }

        public static void WriteTabs(StringBuilder stringBuilder, int count)
        {
            for (int i = 0; i < count; i++)
            {
                stringBuilder.Append("  ");
            }
        }
    }
}