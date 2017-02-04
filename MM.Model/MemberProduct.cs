using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MM.Model
{
    [DataContract(IsReference = true)]
    [KnownType(typeof(Product))]
    [Serializable]
    public abstract class MemberProduct : Product
    {
        [DataMember]
        public int Count { get; set; }
    }
}