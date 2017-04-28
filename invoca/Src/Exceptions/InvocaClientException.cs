using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Invoca.Exceptions
{
    class InvocaClientException : Exception
    {
        public InvocaClientException()
        {
        }

        public InvocaClientException(string message) : base(message)
        {
        }

        public InvocaClientException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvocaClientException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
