using System;

namespace MM.Model.Exceptions
{
    /// <summary>
    /// 教师不存在
    /// </summary>
    [Serializable]
    public class TutorNotExistException : Exception
    {
        public TutorNotExistException() { }
        public TutorNotExistException(string message) : base(message) { }
        public TutorNotExistException(string message, Exception inner) : base(message, inner) { }
        protected TutorNotExistException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
