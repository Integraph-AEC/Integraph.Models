using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Integraph.Models.Common.Metadata
{
    public class ExpressTypeDictionary : Dictionary<Type, ExpressType>
    {
        public ExpressType this[IPersist ent]
        {
            get { return this[ent.GetType()]; }
        }
    }
}
