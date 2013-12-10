using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Oak
{
    public class MemoizedMethod
    {
        public string Name { get; set; }
        public dynamic Arguments { get; set; }
    }

    public class Memoize
    {
        dynamic instance;

        Dictionary<string, object> parameterlessFunctions = new Dictionary<string, object>();

        List<KeyValuePair<MemoizedMethod, object>> parameterizedFunctions = new List<KeyValuePair<MemoizedMethod, object>>();

        public Memoize(dynamic gemini)
        {
            instance = gemini;

            if (gemini.RespondsTo("Memoize"))
            {
                var delegates = gemini.Memoize() as IEnumerable<dynamic>;

                delegates.ForEach(MemoizeMethod);
            }
        }

        void MemoizeMethod(dynamic @delegate)
        {
            var methodName = (@delegate as Delegate).Method.Name;

            var newDelegate = CreateCachedMethodFor(@delegate);

            instance.SetMember(methodName, newDelegate);
        }

        DynamicFunction CreateCachedMethodFor(DynamicFunction @delegate)
        {
            var methodName = (@delegate as Delegate).Method.Name;

            var newDelegate = new DynamicFunction(() =>
            {
                if (parameterlessFunctions.ContainsKey(methodName)) return parameterlessFunctions[methodName];

                var result = (@delegate as Delegate).Method.Invoke(instance, null);

                parameterlessFunctions.Add(methodName, result);

                return parameterlessFunctions[methodName];
            });

            return newDelegate;
        }

        DynamicFunctionWithParam CreateCachedMethodFor(DynamicFunctionWithParam @delegate)
        {
            var methodName = (@delegate as Delegate).Method.Name;

            var newDelegate = new DynamicFunctionWithParam(originalParameters =>
            {
                dynamic arguments = null;

                if (originalParameters is Gemini) arguments = originalParameters.HashOfProperties();

                else if (IsValueType(originalParameters)) arguments = originalParameters;

                else arguments = new Gemini(originalParameters).HashOfProperties();

                var cachedValue = null as object;

                if (HasSameArgumgents(methodName, arguments, out cachedValue)) return cachedValue;

                var result = (@delegate as Delegate).Method.Invoke(instance, new[] { originalParameters });

                parameterizedFunctions.Add(
                    new KeyValuePair<MemoizedMethod, object>(
                        new MemoizedMethod { Name = methodName, Arguments = arguments },
                        result));

                return result;
            });

            return newDelegate;
        }

        bool IsValueType(object originalParameters)
        {
            return originalParameters == null || originalParameters.GetType().IsValueType || originalParameters is string;
        }

        bool HasSameArgumgents(string methodName, dynamic args, out object cachedValue)
        {
            var cachedValuesForMethod = parameterizedFunctions.Where(s => s.Key.Name == methodName);

            cachedValue = null;

            if (!cachedValuesForMethod.Any()) return false;

            var foundValue = null as object;

            foreach (var cachedValues in cachedValuesForMethod)
            {
                if (ValueTypesEqual(args, cachedValues.Key.Arguments))
                {
                    cachedValue = cachedValues.Value;
                    return true;
                }

                if (DictionaryEqual(cachedValues.Key.Arguments, args))
                {
                    cachedValue = cachedValues.Value;
                    return true;
                }
            }

            return false;
        }

        bool ValueTypesEqual(dynamic first, dynamic second)
        {
            if (first == null && second == null) return true;
            if (!IsValueType(first)) return false;
            return first.Equals(second);
        }

        public static bool DictionaryEqual(dynamic firstObject, dynamic secondObject)
        {
            var first = firstObject as IDictionary<string, object>;
            var second = secondObject as IDictionary<string, object>;
            if ((first == null) || (second == null)) return false;
            if (first == second) return true;
            if (first.Count != second.Count) return false;

            var comparer = EqualityComparer<object>.Default;

            foreach (KeyValuePair<string, object> kvp in first)
            {
                object secondValue;
                if (!second.TryGetValue(kvp.Key, out secondValue)) return false;
                if (!comparer.Equals(kvp.Value, secondValue)) return false;
            }
            return true;
        }
    }
}