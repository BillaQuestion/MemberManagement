using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM.Model.Exceptions
{
    [Serializable]
    public class BalanceNotEnoughException : Exception
    {
        public BalanceNotEnoughException() { }
        public BalanceNotEnoughException(string message) : base(message) { }
        public BalanceNotEnoughException(string message, Exception inner) : base(message, inner) { }
        protected BalanceNotEnoughException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
