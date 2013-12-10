using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Dynamic;

namespace Oak
{
    public static class DynamicModelExtensions
    {
        public static DynamicModels ToModels(this IEnumerable<dynamic> enumerable)
        {
            return new DynamicModels(enumerable);
        }
    }

    public class DynamicModels : Gemini, IEnumerable<object>
    {
        public List<dynamic> Models { get; set; }

        public DynamicModels(IEnumerable<dynamic> models)
        {
            Models = models.ToList();
        }

        public new IEnumerable<dynamic> Select(params string[] properties)
        {
            foreach (dynamic model in Models) yield return Select(model, properties);
        }

        dynamic Select(dynamic model, params string[] properties)
        {
            var hash = (model as object).ToDictionary();

            var prototype = new Prototype() as IDictionary<string, object>;

            hash.Where(s => properties.Contains(s.Key)).ForEach(kvp => prototype.Add(kvp.Key, kvp.Value));

            if (prototype.Count == 1) return prototype.First().Value;

            return prototype;
        }

        public bool Any(dynamic options)
        {
            options = (options as object).ToPrototype();

            foreach (dynamic model in Models) if (IsMatch(options, model)) return true;

            return false;
        }

        public List<dynamic> ToList()
        {
            return new List<dynamic>(Models);
        }

        public bool Any()
        {
            return Models.Any();
        }

        public int Count()
        {
            return Models.Count;
        }

        public dynamic First()
        {
            return Models.FirstOrDefault();
        }

        public dynamic Second()
        {
            if (Models.Count >= 2)  return Models[1];

            return null;
        }

        public dynamic Last()
        {
            return Models.LastOrDefault();
        }

        public dynamic Last(dynamic options)
        {
            return Where(options as object).LastOrDefault();
        }

        public dynamic First(dynamic options)
        {
            return Where(options as object).FirstOrDefault();
        }

        public dynamic OrderBy(dynamic options)
        {
            var dict = (options as object).ToPrototype() as IDictionary<string, object>;

            dynamic results = Models.AsEnumerable();

            dict.ForEach(kvp => results = Sort(results, kvp.Key, kvp.Value));

            return new DynamicModels(results);
        }

        public dynamic Sort(IEnumerable<dynamic> models, string property, object direction)
        {
            if (models is IOrderedEnumerable<dynamic>)
            {
                var ordered = (models as IOrderedEnumerable<dynamic>);

                if (IsAscending(direction)) return ordered.ThenBy(s => ValueFor(s, property));

                return ordered.ThenByDescending(s => ValueFor(s, property));
            }

            if (IsAscending(direction)) return models.OrderBy(s => ValueFor(s, property));

            return models.OrderByDescending(s => ValueFor(s, property));
        }

        public dynamic ValueFor(dynamic model, string property)
        {
            return ValueFor((ToHash(model) as IDictionary<string, object>)[property]);
        }

        public bool IsAscending(object value)
        {
            return (value as string) == "asc";
        }

        public DynamicModels Where(dynamic options)
        {
            options = (options as object).ToPrototype();

            var results = new List<dynamic>();

            foreach (dynamic model in Models) if (IsMatch(options, model)) results.Add(model);

            return new DynamicModels(results);
        }

        private bool IsMatch(IDictionary<string, dynamic> options, dynamic model)
        {
            IDictionary<string, object> hash = ToHash(model);

            return options.All(s => s.Value == ValueFor(hash[s.Key]));
        }

        private IDictionary<string, object> ToHash(dynamic model)
        {
            if (model is Gemini) return model.Hash();

            return (model as object).ToPrototype();
        }

        private dynamic ValueFor(dynamic value)
        {
            if (value is Delegate) return value();

            return value;
        }

        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            if (RespondsTo(binder.Name)) return base.TryInvokeMember(binder, args, out result);

            return EagerLoad(binder.Name, args, out result);
        }

        private bool EagerLoad(string collectionName, object[] args, out object result)
        {
            result = new HashSet<dynamic>();

            if (!Models.Any()) return true;

            dynamic options = null;

            if (args.Any()) options = args[0];

            foreach(var m in Models)
            {
                var association = m.AssociationNamed(collectionName);
                
                IEnumerable<dynamic> values = association.EagerLoad(Models, options);

                foreach(var v in values) (result as HashSet<dynamic>).Add(v);

                if(association is SingleAssociation) break;
            }

            result = new DynamicModels(result as HashSet<dynamic>);

            return true;
        }

        private dynamic Get(string collectionName, dynamic model)
        {
            return model.GetMember(collectionName).Invoke(null);
        }

        public IEnumerator<object> GetEnumerator()
        {
            return Models.GetEnumerator();
        }

        public DynamicModels Include(params string[] methods)
        {
            var result = new object();

            methods.ForEach(s => 
            {
                EagerLoad(s, new object[] { }, out result);
            });

            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Models.GetEnumerator();
        }

        public override string ToString()
        {
            var fullString = base.ToString();

            fullString += "========= Entries ===========" + Environment.NewLine;

            foreach (var model in Models)
            {
                fullString += model + Environment.NewLine;
            }

            fullString += "=============================" + Environment.NewLine;

            return fullString;
        }
    }
}
