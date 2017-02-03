using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM.Model
{
    [Serializable]
    public class CountNotEnoughtException : Exception
    {
        public CountNotEnoughtException() { }
        public CountNotEnoughtException(string message) : base(message) { }
        public CountNotEnoughtException(string message, Exception inner) : base(message, inner) { }
        protected CountNotEnoughtException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
