using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM.Model.Exceptions
{
    [Serializable]
    public class ProductNotExistException : Exception
    {
        public ProductNotExistException() { }
        public ProductNotExistException(string message) : base(message) { }
        public ProductNotExistException(string message, Exception inner) : base(message, inner) { }
        protected ProductNotExistException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
