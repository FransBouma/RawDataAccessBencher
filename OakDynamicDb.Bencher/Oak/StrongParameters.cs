using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Oak
{
    public class StrongParameters
    {
        DynamicFunctionWithParam originalSetMembers;

        List<string> permitted = new List<string>();

        public StrongParameters(dynamic gemini)
        {
            gemini.Permit = new DynamicFunctionWithParam(Permit);

            originalSetMembers = gemini.GetMember("SetMembers") as DynamicFunctionWithParam;

            gemini.SetMembers = new DynamicFunctionWithParam(SetMembers);
        }

        public virtual dynamic Permit(dynamic args)
        {
            if (args is string) permitted.Add(args);

            else permitted.AddRange((args as object[]).Select(s => s as string));

            return args;
        }

        public virtual dynamic SetMembers(dynamic args)
        {
            var members = (args as object).ToPrototype().Keys as IEnumerable<string>;

            var unpermitted = new List<string>();

            foreach (var member in members) if (!IsPermitted(member)) unpermitted.Add(member);

            if (unpermitted.Any()) throw new InvalidOperationException("The following members are not allowed for mass assignment through SetMembers, use the Permit(/* property names */) method to approve parameters for mass assignment: " + string.Join(", ", unpermitted));

            return originalSetMembers.Invoke(args);
        }

        public virtual bool IsPermitted(string member)
        {
            return permitted.Contains(member);
        }
    }
}