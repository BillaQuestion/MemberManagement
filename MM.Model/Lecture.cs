using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MM.Model
{
    /// <summary>
    /// 课程
    /// </summary>
    [DataContract(IsReference = true)]
    [KnownType(typeof(Product))]
    [KnownType(typeof(MemberProduct))]
    [Serializable]
    public class Lecture : MemberProduct
    {
        /// <summary>
        /// 课程描述
        /// </summary>
        [DataMember]
        public string Description { get; set; }
    }
}