using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM.Business.Exceptions
{
    [Serializable]
    public class MemberNotExistException : Exception
    {
        public MemberNotExistException() { }
        public MemberNotExistException(string message) : base(message) { }
        public MemberNotExistException(string message, Exception inner) : base(message, inner) { }
        protected MemberNotExistException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
