using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM.Model.Exceptions
{
    [Serializable]
    public class ProductExistException : Exception
    {
        public ProductExistException() { }
        public ProductExistException(string message) : base(message) { }
        public ProductExistException(string message, Exception inner) : base(message, inner) { }
        protected ProductExistException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
