using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM.Model.Exceptions
{
    [Serializable]
    public class LectureExistException : Exception
    {
        public LectureExistException() { }
        public LectureExistException(string message) : base(message) { }
        public LectureExistException(string message, Exception inner) : base(message, inner) { }
        protected LectureExistException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
