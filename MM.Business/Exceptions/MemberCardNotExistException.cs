using System;

namespace MM.Business.Exceptions
{
    /// <summary>
    /// 会员卡不存在
    /// </summary>
    [Serializable]
    public class MemberCardNotExistException : Exception
    {
        public MemberCardNotExistException() { }
        public MemberCardNotExistException(string message) : base(message) { }
        public MemberCardNotExistException(string message, Exception inner) : base(message, inner) { }
        protected MemberCardNotExistException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
