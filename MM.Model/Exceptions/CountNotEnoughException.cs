using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM.Model.Exceptions
{
    [Serializable]
    public class CountNotEnoughException : Exception
    {
        public CountNotEnoughException() { }
        public CountNotEnoughException(string message) : base(message) { }
        public CountNotEnoughException(string message, Exception inner) : base(message, inner) { }
        protected CountNotEnoughException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
