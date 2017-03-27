using System;

namespace MM.Model.Exceptions
{
    [Serializable]
    public class MemberExistException : Exception
    {
        public MemberExistException() { }
        public MemberExistException(string message) : base(message) { }
        public MemberExistException(string message, Exception inner) : base(message, inner) { }
        protected MemberExistException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

}
