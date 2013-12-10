using System;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;

namespace Oak
{
    public class DynamicModel : Gemini
    {
        static DynamicModel()
        {
            Gemini.Initialized<DynamicModel>(instance =>
            {
                new Validations(instance);

                new Associations(instance);

                new Changes(instance);
            });
        }

        public DynamicModel(object dto)
            : base(dto)
        {

        }

        public DynamicModel()
            : this(new { })
        {

        }
    }
}
