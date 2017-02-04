using System;
using System.Runtime.Serialization;

namespace MM.Model
{
    [DataContract(IsReference = true)]
    [KnownType(typeof(Product))]
    [Serializable]
    public class TimesCard : MemberProduct
    {
        /// <summary>
        /// 画布介质
        /// </summary>
        [DataMember]
        public Media Media { get; set; }
    }
}