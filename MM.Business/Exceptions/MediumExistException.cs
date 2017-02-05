using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM.Business.Exceptions
{
    [Serializable]
    public class MediumExistException : Exception
    {
        public MediumExistException() { }
        public MediumExistException(string message) : base(message) { }
        public MediumExistException(string message, Exception inner) : base(message, inner) { }
        protected MediumExistException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
