using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.IO;
using System.Threading;
using System.Collections;
using System.Collections.Specialized;


namespace Oak
{
    [DebuggerNonUserCode]
    public class Prototype : DynamicObject, IDictionary<string, object>
    {
        Dictionary<string, object> members;

        public Prototype() { members = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase); }

        public Prototype(IDictionary<string, object> dictionary)
        {
            members = new Dictionary<string, object>(dictionary, StringComparer.OrdinalIgnoreCase);
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            if (!members.ContainsKey(binder.Name)) members.Add(binder.Name, null);

            members[binder.Name] = value;

            return true;
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            if (members.ContainsKey(binder.Name))
            {
                result = members[binder.Name];

                return true;
            };

            result = null;

            return false;
        }

        public void Add(string key, object value) { members.Add(key, value); }

        public bool ContainsKey(string key) { return members.ContainsKey(key); }

        public ICollection<string> Keys { get { return members.Keys; } }

        public bool Remove(string key) { return members.Remove(key); }

        public bool TryGetValue(string key, out object value) { return members.TryGetValue(key, out value); }

        public ICollection<object> Values { get { return members.Values; } }

        public object this[string key] { get { return members[key]; } set { members[key] = value; } }

        ICollection<KeyValuePair<string, object>> Collection() { return members; }

        public void Add(KeyValuePair<string, object> item) { Collection().Add(item); }

        public void Clear() { Collection().Clear(); }

        public bool Contains(KeyValuePair<string, object> item) { return Collection().Contains(item); }

        public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex) { Collection().CopyTo(array, arrayIndex); }

        public int Count { get { return Collection().Count; } }

        public bool IsReadOnly { get { return Collection().IsReadOnly; } }

        public bool Remove(KeyValuePair<string, object> item) { return Collection().Remove(item); }

        IEnumerable<KeyValuePair<string,object>> Enumerable() { return members; }

        public IEnumerator<KeyValuePair<string, object>> GetEnumerator() { return Enumerable().GetEnumerator(); }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return (Enumerable() as System.Collections.IEnumerable).GetEnumerator(); }

        public override string ToString()
        {
            return GeminiInfo.Parse(this);
        }
    }

    [DebuggerNonUserCode]
    public static class HelpfulExtensions
    {
        public static object ForEach(this object enumerable, Action<dynamic> action)
        {
            dynamic temp = enumerable;

            foreach (var item in temp) action(item);

            return enumerable;
        }

        public static object ForEach<T>(this object enumerable, Action<T> action)
        {
            dynamic temp = enumerable;

            foreach (var item in temp) action(item);

            return enumerable;
        }

        public static bool None<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            return !source.Any(predicate);
        }
    }

    public delegate dynamic DynamicFunction();

    public delegate dynamic DynamicFunctionWithParam(dynamic parameter);

    public delegate void DynamicMethodWithParam(dynamic parameter);

    public delegate dynamic DynamicMethod();

    [DebuggerNonUserCode]
    public class Gemini : DynamicObject
    {
        static Gemini()
        {
            Gemini.Initialized<Gemini>(d => d.AddRedefinableDelegates());
        }

        private bool initialized;

        private static List<KeyValuePair<Type, Func<dynamic, dynamic>>> ExtendHooks = new List<KeyValuePair<Type, Func<dynamic, dynamic>>>();

        private static List<KeyValuePair<Type, Action<dynamic>>> MethodHooks = new List<KeyValuePair<Type, Action<dynamic>>>();

        private static List<KeyValuePair<Type, Action<dynamic>>> InitializationHooks = new List<KeyValuePair<Type, Action<dynamic>>>();

        private static Dictionary<Type, List<MethodInfo>> MethodCache = new Dictionary<Type, List<MethodInfo>>();

        private static Dictionary<Type, Dictionary<string, PropertyInfo>> PropertyCache = new Dictionary<Type, Dictionary<string, PropertyInfo>>();

        private List<Type> types = new List<Type>();

        private List<Type> extendedWith = new List<Type>();

        public virtual List<Type> ExtendedWith()
        {
            return extendedWith;
        }

        public dynamic Prototype { get; set; } //this used to be called Expando

        public static void Extend<A, B>()
        {
            ExtendHooks.Add(new KeyValuePair<Type, Func<dynamic, dynamic>>(typeof(A), (i) =>
            {
                i.Extend<B>();

                return null;
            }));
        }

        public static void Extend<T>(Func<dynamic, dynamic> extension)
        {
            ExtendHooks.Add(new KeyValuePair<Type, Func<dynamic, dynamic>>(typeof(T), extension));
        }

        public static void Extend<T>(Action<dynamic> extension)
        {
            ExtendHooks.Add(new KeyValuePair<Type, Func<dynamic, dynamic>>(typeof(T), (i) => { extension(i); return null; }));
        }

        public static void Initialized<T>(Action<dynamic> callback)
        {
            InitializationHooks.Add(new KeyValuePair<Type, Action<dynamic>>(typeof(T), callback));
        }

        public static void MethodDefined<T>(Action<dynamic> extension)
        {
            MethodHooks.Add(new KeyValuePair<Type, Action<dynamic>>(typeof(T), extension));
        }

        protected dynamic _
        {
            get { return this as dynamic; }
        }

        public dynamic This()
        {
            return _;
        }

        public Gemini()
            : this(new { })
        {

        }

        public Gemini(object dto)
        {
            AttachDtoValues(dto);

            ApplyValuesToWritableProperties();

            ConstructTypeHierarchy();

            ApplyExtensions();

            initialized = false;
        }

        private void AttachDtoValues(object dto)
        {
            if (dto == null) dto = new Prototype();

            else if (dto is string || dto.GetType().IsValueType) dto = new { Value = dto };

            else if (dto is IEnumerable && !dto.CanConvertToPrototype()) dto = new { Items = dto };

            if (dto is Prototype) Prototype = dto;

            else Prototype = dto.ToPrototype();
        }

        private void ConstructTypeHierarchy()
        {
            var currentType = this.GetType();

            while (currentType != typeof(object))
            {
                types.Add(currentType);

                currentType = currentType.BaseType;
            }
        }

        public dynamic AddRedefinableDelegates()
        {
            foreach (var method in DynamicDelegates(this.GetType()))
            {
                if(!RespondsTo(method.Name)) AddDynamicMember(method);
            }

            return this;
        }

        private void ApplyExtensions()
        {
            var includes = ExtendHooks.Where(s => types.Contains(s.Key));

            foreach (var include in includes)
            {
                object result = (include.Value(this) as object);

                if (result == null) continue;

                (result.ToPrototype() as IDictionary<string, object>).ToList().ForEach(s => SetMember(s.Key, s.Value));
            }
        }

        private void ApplyValuesToWritableProperties()
        {
            var props = AutoProperties();

            foreach (var key in props.Keys)
            {
                var propInfo = props[key];

                var dict = Prototype as IDictionary<string, object>;

                if (dict.ContainsKey(propInfo.Name) && propInfo.CanWrite)
                {
                    propInfo.SetValue(this, dict[propInfo.Name], null);

                    (Prototype as IDictionary<string, object>).Remove(propInfo.Name);
                }
            }
        }

        private Dictionary<string, PropertyInfo> AutoProperties()
        {
            lock(typeof(Gemini))
            {
                if (!PropertyCache.ContainsKey(GetType()))
                {
                    PropertyCache.Add(
                        GetType(),
                        PropertiesExcludingPrototype().ToDictionary(s => s.Name));
                }

                return PropertyCache[GetType()];
            }
        }

        private IEnumerable<PropertyInfo> PropertiesExcludingPrototype()
        {
            return GetType().GetProperties().Where(s => s.Name != "Prototype");
        }

        private void AddDynamicMember(MethodInfo method)
        {
            var parameters = method.GetParameters().ToList();

            if (IsDynamicFunction(method, parameters)) TrySetMember(method.Name, DynamicFunctionFor(method));

            else if (IsDynamicFunctionWithParam(method, parameters)) TrySetMember(method.Name, DynamicFunctionWithParamFor(method));

            else if (IsDynamicMethod(method, parameters)) TrySetMember(method.Name, DynamicMethodFor(method));

            else if (IsDynamicMethodWithParam(method, parameters)) TrySetMember(method.Name, DynamicFunctionWithParamFor(method));
        }

        public DynamicFunction DynamicFunctionFor(MethodInfo method)
        {
            return new DynamicFunction(() => Invoke(method, null));
        }

        public DynamicFunctionWithParam DynamicFunctionWithParamFor(MethodInfo method)
        {
            return new DynamicFunctionWithParam((arg) => Invoke(method, new[] { arg }));
        }

        private DynamicMethod DynamicMethodFor(MethodInfo method)
        {
            return new DynamicMethod(() => Invoke(method, null));
        }

        private object Invoke(MethodInfo method, object[] parameters)
        {
            try { return method.Invoke(this, parameters); }
            catch (Exception ex) { throw InvocationException(ex); }
        }

        public BindingFlags PrivateFlags()
        {
            return BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly;
        }

        public MethodInfo Method(string name)
        {
            return (this).GetType().GetMethod(name, PrivateFlags());
        }

        public bool IsDynamicFunction(MethodInfo method, List<ParameterInfo> parameters)
        {
            if (method.ReturnType != typeof(object) && method.ReturnType != typeof(IEnumerable<dynamic>)) return false;

            if (parameters.Any()) return false;

            return true;
        }

        public dynamic Extend<T>() where T : class
        {
            var constructor = typeof(T).GetConstructor(new Type[] { typeof(object) });

            try { constructor.Invoke(new object[] { this }); }
            catch (Exception ex) { throw InvocationException(ex); }

            extendedWith.Add(typeof(T));

            return this;
        }

        Exception InvocationException(Exception ex)
        {
            Exception innerException = ex.InnerException;
            ThreadStart savestack = Delegate.CreateDelegate(typeof(ThreadStart), innerException, "InternalPreserveStackTrace", false, false) as ThreadStart;
            if (savestack != null) savestack();
            throw ex.InnerException;
        }

        public bool IsDynamicFunctionWithParam(MethodInfo method, List<ParameterInfo> parameters)
        {
            if (method.ReturnType != typeof(object) && method.ReturnType != typeof(IEnumerable<dynamic>)) return false;

            if (parameters.Count != 1) return false;

            if (parameters.Any(s => s.ParameterType != typeof(object))) return false;

            return true;
        }

        public bool IsDynamicMethod(MethodInfo method, List<ParameterInfo> parameters)
        {
            if (method.ReturnType != typeof(void)) return false;

            if (parameters.Any()) return false;

            return true;
        }

        public bool IsDynamicMethodWithParam(MethodInfo method, List<ParameterInfo> parameters)
        {
            if (method.ReturnType != typeof(void)) return false;

            if (parameters.Count != 1) return false;

            if (parameters.Any(s => s.ParameterType != typeof(object))) return false;

            return true;
        }

        public IEnumerable<MethodInfo> DynamicDelegates(Type type)
        {
            if (type == typeof(object)) return new List<MethodInfo>();

            lock(typeof(Gemini))
            {
                if (MethodCache.ContainsKey(type)) return MethodCache[type];

                var delegates = type
                    .GetMethods(PrivateFlags())
                    .Where(s => IsDynamicDelegate(s, s.GetParameters().ToList())).ToList();

                if (type == typeof(Gemini)) delegates.RemoveAll(s => s.Name != "SetMembers");

                delegates.AddRange(DynamicDelegates(type.BaseType));

                MethodCache.Add(type, delegates);

                return delegates;
            }
        }

        public bool IsDynamicDelegate(MethodInfo method, List<ParameterInfo> parameters)
        {
            return IsDynamicFunction(method, parameters) ||
                IsDynamicFunctionWithParam(method, parameters) ||
                IsDynamicMethod(method, parameters) ||
                IsDynamicMethodWithParam(method, parameters);
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            return TryGetMember(binder.Name, out result);
        }

        public virtual bool RespondsTo(string property)
        {
            object result = null;

            return TryGetMember(property, out result);
        }

        Dictionary<string, PropertyInfo> InstanceAutoProperties()
        {
            return PropertyCache[GetType()];
        }

        public bool TryGetMember(string name, out object result)
        {
            InitializeIfNeeded(name);

            var dictionary = Hash();

            if (dictionary.ContainsKey(name))
            {
                result = dictionary[name];
                return true;
            }

            if (InstanceAutoProperties().ContainsKey(name))
            {
                result = InstanceAutoProperties()[name].GetValue(this, null);
                return true;
            }

            result = null;
            return false;
        }

        public dynamic InitializeExtensions()
        {
            InitializeIfNeeded(null);

            return this;
        }

        void InitializeIfNeeded(string property)
        {
            if (initialized) return;

            initialized = true;

            var hooks = InitializationHooks.Where(s => types.Contains(s.Key));

            foreach (var hook in hooks) hook.Value(this);
        }

        public virtual dynamic GetMember(string property)
        {
            object result = null;

            if (TryGetMember(property, out result)) return result;

            throw MemberDoesntExistException(property);
        }

        public InvalidOperationException MemberDoesntExistException(string name)
        {
            return new InvalidOperationException(
                "This instance of type " +
                this.GetType().Name +
                " does not respond to the member " +
                name +
                ".  These are the members that exist on this instance: " + __Info__());
        }

        public virtual dynamic __Info__()
        {
            return GeminiInfo.Parse(this);
        }

        public virtual dynamic SetMember(string property, object value, bool suppress)
        {
            TrySetMember(property, value, suppress);

            return this;
        }

        public virtual dynamic SetMember(string property, object value)
        {
            TrySetMember(property, value, suppress: false);

            return this;
        }

        void SetMembers(dynamic o)
        {
            var dictionary = (o as object).ToDictionary();

            foreach (var item in dictionary) SetMember(item.Key, item.Value);
        }

        public virtual void UpdateMembers(dynamic o)
        {
            var dictionary = (o as object).ToDictionary();

            foreach (var item in dictionary) UpdateMember(item.Key, item.Value);
        }

        public virtual void UpdateMember(string property, object value)
        {
            if (RespondsTo(property)) SetMember(property, value);
        }

        string Capitalized(string s)
        {
            return s[0].ToString().ToUpper() + s.Substring(1);
        }

        string Fuzzy(IDictionary<string, object> dictionary, string name)
        {
            foreach (var kvp in dictionary) if (kvp.Key.Equals(name, StringComparison.InvariantCultureIgnoreCase)) return kvp.Key;

            return "";
        }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            return TrySetMember(binder.Name, value, suppress: false);
        }

        public bool TrySetMember(string property, object value, bool suppress = false)
        {
            InitializeIfNeeded(property);

            var dictionary = Hash();

            if (dictionary.ContainsKey(property))
            {
                dictionary[property] = value;
                return true;
            }

            if (InstanceAutoProperties().ContainsKey(property))
            {
                InstanceAutoProperties()[property].SetValue(this, value, null);
                return true;
            }

            if (IsSame(value))
            {
                TrySetMember(property, new DynamicFunction(() => value), suppress);
            }
            else
            {
                dictionary.Add(property, value);

                if (!suppress)
                {
                    var hooks = MethodHooks.Where(s => s.Key == this.GetType());

                    foreach (var hook in hooks) hook.Value(new Gemini(new { Name = property, Instance = this })); //not under test yet...
                }    
            }
            return true;
        }

        public bool IsSame(dynamic o)
        {
            if (o is Gemini && this.Prototype == (o as Gemini).Prototype) return true;

            return false;
        }

        public virtual IEnumerable<string> Members()
        {
            return Hash().Select(s => s.Key).ToList();
        }

        public virtual IDictionary<string, object> Hash()
        {
            InitializeIfNeeded("Hash");

            return Prototype as IDictionary<string, object>;
        }

        public virtual IDictionary<string, object> HashOfProperties()
        {
            var dynamicProps = HashExcludingDelegates();

            var props = AutoProperties();

            foreach (var key in props.Keys)
            {
                if (!props[key].CanRead) continue;

                dynamicProps.Add(props[key].Name, props[key].GetValue(this, null));
            }

            return dynamicProps;
        }

        public virtual IDictionary<string, object> HashOfWritableProperties()
        {
            var dynamicProps = HashExcludingDelegates();

            var props = AutoProperties();

            foreach (var key in props.Keys)
            {
                if (!props[key].CanWrite) continue;

                if(props[key].CanRead) dynamicProps.Add(props[key].Name, props[key].GetValue(this, null));
            }

            return dynamicProps;
        }

        public virtual IDictionary<string, object> HashExcludingDelegates()
        {
            var dictionary = new Prototype() as IDictionary<string, object>;

            var hashset = new HashSet<string>(Delegates().Select(s => s.Key));

            Hash().ForEach<KeyValuePair<string, object>>(s =>
            {
                if (!hashset.Contains(s.Key)) dictionary.Add(s.Key, s.Value);
            });

            return dictionary;
        }

        public virtual IEnumerable<KeyValuePair<string, object>> Delegates()
        {
            return Hash().Where(s => s.Value is Delegate).ToList();
        }

        public virtual dynamic DeleteMember(string member)
        {
            Hash().Remove(Fuzzy(Hash(), member));

            return this;
        }

        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            InitializeIfNeeded(binder.Name);

            result = null;

            if (!RespondsTo(binder.Name)) return MethodMissing(binder, args, ref result);

            var member = GetMember(binder.Name);

            if (!DynamicFunction(member)) return base.TryInvokeMember(binder, args, out result);

            result = InvokeDynamicFunction(member, args, binder.CallInfo.ArgumentNames.ToArray());

            return true;
        }

        public virtual bool MethodMissing(InvokeMemberBinder binder, object[] args, ref object result)
        {
            if (RespondsTo("MethodMissing"))
            {
                var argNames = binder.CallInfo.ArgumentNames.ToArray();

                result = _.MethodMissing(
                    new Gemini(new
                    {
                        Name = binder.Name,
                        Parameters = args,
                        ParameterNames = argNames,
                        Instance = this,
                        Parameter = GetNamedArgs(args, argNames)
                    }));

                return true;
            }

            return false;
        }

        public virtual bool DynamicFunction(object member)
        {
            return (member is DynamicFunctionWithParam) || (member is DynamicMethodWithParam);
        }

        public virtual dynamic InvokeDynamicFunction(dynamic member, object[] args, string[] argNames)
        {
            Func<dynamic> function = () =>
            {
                member.Invoke(args.FirstOrDefault());

                return null;
            };

            if (member is DynamicFunctionWithParam)
            {
                var argsToInvokeWith = args.FirstOrDefault() as dynamic;

                if (argNames.Any()) argsToInvokeWith = GetNamedArgs(args, argNames);

                else if (args.Count() > 1) argsToInvokeWith = args;

                function = () => member.Invoke(argsToInvokeWith);
            };

            return function();
        }

        private dynamic GetNamedArgs(object[] args, string[] argNames)
        {
            var namedArgs = new Gemini();

            argNames.Zip(
                args.Skip(args.Length - argNames.Length),
                (argName, argValue) => new
                {
                    name = argName,
                    value = argValue
                })
                .ForEach(arg => namedArgs.SetMember(arg.name, arg.value));

            return namedArgs;
        }

        dynamic ToDynamicParam(object[] args, string[] argNames)
        {
            if (AllParametersAreNamed(args, argNames))
            {
                var prototype = new Prototype() as IDictionary<string, object>;

                for (int i = 0; i < args.Count(); i++) prototype.Add(argNames[i], args[i]);

                return prototype;
            }

            return args.FirstOrDefault();
        }

        private bool AllParametersAreNamed(object[] args, IEnumerable<string> argNames)
        {
            return args.Count() == argNames.Count();
        }

        public virtual dynamic Select(params string[] args)
        {
            var prototype = new Prototype() as IDictionary<string, object>;

            args.ForEach(s =>
            {
                if (RespondsTo(s)) prototype.Add(s, GetMember(s));
            });

            return new Gemini(prototype);
        }

        public virtual dynamic Exclude(params string[] args)
        {
            var prototype = (HashOfProperties() as IDictionary<string, object>).ToList();

            var dictionary = new Prototype() as IDictionary<string, object>;

            args = args.Select(s => s.ToLower()).ToArray();

            prototype.ForEach(s =>
            {
                if (!args.Contains(s.Key.ToLower())) dictionary.Add(s.Key, GetMember(s.Key));
            });

            return new Gemini(dictionary);
        }

        public virtual bool IsOfType<T>()
        {
            return TypeExtensions.IsOfType<T>(this);
        }

        public virtual bool IsOfKind<T>()
        {
            return TypeExtensions.IsOfKind<T>(this) || ExtendedWith().Contains(typeof(T));
        }

        public override string ToString()
        {
            return __Info__();
        }
    }
}
