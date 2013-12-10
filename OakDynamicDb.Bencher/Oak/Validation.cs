using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Massive;
using System.Text.RegularExpressions;

namespace Oak
{
    public class Validations
    {
        dynamic @this;

        List<dynamic> rules;

        List<dynamic> errors;

        public Validations(dynamic mixWith)
        {
            rules = new List<dynamic>();

            errors = new List<dynamic>();

            @this = mixWith;

            mixWith.SetMember("Errors", new DynamicFunction(Errors));

            mixWith.SetMember("IsValid", new DynamicFunctionWithParam(IsValid));

            mixWith.SetMember("FirstError", new DynamicFunction(FirstError));

            if (HasValidationCapabilities(mixWith))
            {
                try
                {
                    IEnumerable<dynamic> validationRules = @this.Validates();
                    foreach (var validationRule in validationRules)
                    {
                        validationRule.Init(mixWith);
                        AddRule(validationRule);
                    }
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException(
                        String.Format("Validation initialization failed for class {0}.  Check the Validates method on {0} for a validation declaration related to this exception: {1}", 
                            @this.GetType().Name, 
                            ex.Message), 
                        ex);
                }
            }
        }

        public bool HasValidationCapabilities(dynamic mixWith)
        {
            return mixWith.GetType().GetMethod("Validates") != null || mixWith.RespondsTo("Validates");
        }

        public void AddError(string property, string message)
        {
            errors.Add(new Gemini(new { Key = property, Value = message }));
        }

        public void AddRule(dynamic rule)
        {
            rules.Add(rule);
        }

        public dynamic Errors()
        {
            return errors;
        }

        public virtual dynamic IsValid(dynamic property)
        {
            if(property == null) return IsValid(s => true);

            return IsValid(s => s.Property == property);
        }

        public virtual bool IsValid(Func<dynamic, bool> filter)
        {
            errors.Clear();

            bool isValid = true;

            foreach (var rule in rules.Where(filter)) isValid = Validate(rule) && isValid;

            return isValid;
        }

        public bool Validate(dynamic rule)
        {
            if (rule.Before != null) rule.Before();

            if (rule.If != null && !rule.If()) return true;

            if (rule.Unless != null && rule.Unless()) return true;

            bool isValid = rule.Validate(@this);

            if (rule.After != null) rule.After();

            if (!isValid) AddError(rule.Property, rule.Message());

            return isValid;
        }

        public dynamic FirstError()
        {
            var error = errors.FirstOrDefault();

            if (object.ReferenceEquals(error, null)) return null;

            return error.Value;
        }
    }

    public class Validation
    {
        public string Property { get; set; }

        public dynamic ErrorMessage { get; set; }

        public Validation(string property)
        {
            Property = property;
        }

        public virtual void Init(dynamic entity) 
        {
            AddProperty(entity, Property);
        }

        public void AddProperty(dynamic entity, string property)
        {
            if (!entity.RespondsTo(property)) entity.SetMember(property, null);
        }

        public virtual string Message()
        {
            if (ErrorMessage is Delegate) return ErrorMessage();

            if (!string.IsNullOrEmpty(ErrorMessage)) return ErrorMessage;

            return Property + " is invalid.";
        }

        public dynamic StringifyValue(dynamic entity)
        {
            var value = PropertyValueIn(entity);

            return (value ?? "").ToString();
        }

        public dynamic PropertyValueIn(dynamic entity)
        {
            return PropertyValueIn(Property, entity);
        }

        public dynamic PropertyValueIn(string property, dynamic entity)
        {
            return entity.GetMember(property);
        }

        public Func<bool> If { get; set; }

        public Func<bool> Unless { get; set; }

        public Action Before { get; set; }

        public Action After { get; set; }
    }

    public class Acceptance : Validation
    {
        public Acceptance(string property)
            : base(property)
        {
            Accept = true;
        }

        public dynamic Accept { get; set; }

        public bool Validate(dynamic entity)
        {
            return PropertyValueIn(entity).Equals(Accept);
        }
    }

    public class Confirmation : Validation
    {
        public Confirmation(string property)
            : base(property)
        {
            
        }

        public override void Init(dynamic entity)
        {
            base.Init(entity as object);

            AddProperty(entity, Property + "Confirmation");
        }

        public bool Validate(dynamic entity)
        {
            return PropertyValueIn(entity) == PropertyValueIn(Property + "Confirmation", entity);
        }
    }

    public class Exclusion : Validation
    {
        public Exclusion(string property)
            : base(property)
        {
            
        }
        public dynamic[] In { get; set; }

        public bool Validate(dynamic entity)
        {
            return !In.Contains(PropertyValueIn(entity) as object);
        }
    }

    public class Format : Validation
    {
        public Format(string property)
            : base(property)
        {
            
        }

        public string With { get; set; }

        public bool Validate(dynamic entity)
        {
            return Regex.IsMatch(StringifyValue(entity), With);
        }
    }

    public class Inclusion : Validation
    {
        public Inclusion(string property)
            : base(property)
        {
            
        }

        public dynamic[] In { get; set; }

        public bool Validate(dynamic entity)
        {
            return In.Contains(PropertyValueIn(entity) as object);
        }
    }

    public class Presence : Validation
    {
        public Presence(string property)
            : base(property)
        {
            
        }

        public override void Init(dynamic entity)
        {
            base.Init(entity as object);

            if (ErrorMessage != null) return;

            if (string.IsNullOrEmpty(ErrorMessage)) ErrorMessage = Property + " is required.";
        }

        public bool Validate(dynamic entity)
        {
            return !string.IsNullOrEmpty(StringifyValue(entity));
        }
    }

    public class Uniqueness : Validation
    {
        public Uniqueness(string property, DynamicRepository usingRepository)
            : base(property)
        {
            Repository = usingRepository;
        }

        public override void Init(dynamic entity)
        {
            base.Init(entity as object);

            if (ErrorMessage != null) return;

            if (string.IsNullOrEmpty(ErrorMessage)) ErrorMessage = Property + " is taken.";
        }

        public DynamicRepository Repository { get; set; }

        public bool Validate(dynamic entity)
        {
            object value = entity.GetMember(Property);

            var whereClause = Property + " = @0";

            var values = new List<object> { value };

            if (entity.RespondsTo(Repository.PrimaryKeyField))
            {
                whereClause += " and [" + Repository.PrimaryKeyField + "] != @1";

                values.Add(entity.Id);
            }

            if (Repository.SingleWhere(whereClause, values.ToArray()) != null) return false;

            return true;
        }
    }

    public class Numericality : Validation
    {
        public Numericality(string property)
            : base(property)
        {
        }

        public bool OnlyInteger { get; set; }

        public double? GreaterThan { get; set; }

        public double? GreaterThanOrEqualTo { get; set; }

        public double? EqualTo { get; set; }

        public double? LessThan { get; set; }

        public double? LessThanOrEqualTo { get; set; }

        public bool Odd { get; set; }

        public bool Even { get; set; }

        public bool Validate(dynamic entity)
        {
            string value = entity.GetMember(Property).ToString();

            var decimalValue = Double(value);

            if (decimalValue == null) return false;

            if (OnlyInteger == true && !IsInteger(value)) return false;

            if (GreaterThan != null && decimalValue <= GreaterThan) return false;

            if (GreaterThanOrEqualTo != null && decimalValue < GreaterThanOrEqualTo) return false;

            if (EqualTo != null && decimalValue != EqualTo) return false;

            if (LessThan != null && decimalValue >= LessThan) return false;

            if (LessThanOrEqualTo != null && decimalValue > LessThanOrEqualTo) return false;

            if (Odd == true && decimalValue % 2 == 0) return false;

            if (Even == true && decimalValue % 2 == 1) return false;
            
            return true;
        }

        public double? Double(string value)
        {
            double doubleResult;

            if (double.TryParse(value, out doubleResult)) return doubleResult;

            return null;
        }

        public bool IsInteger(string value)
        {
            int intResult;

            return int.TryParse(value, out intResult);
        }
    }
    
    public class Length : Validation
    {
        public Length(string property)
            : base(property)
        {
        }

        public int? Minimum { get; set; }

        public int? Maximum { get; set; }

        public IEnumerable<int> In { get; set; }

        public int? Is { get; set; }
        
        public bool IgnoreNull { get; set; }
        
        public bool Validate(dynamic entity)
        {
            dynamic value = entity.GetMember(Property);

            if (value == null && IgnoreNull == true) return true;

            if (value == null) return false;

            int length = value.Length;

            if (Minimum != null && length < Minimum) return false;
            
            if (Maximum != null && length > Maximum) return false;

            if (In != null && !In.Contains(length)) return false;
            
            if (Is != null && length != Is) return false;
            
            return true;
        }
    }
}
