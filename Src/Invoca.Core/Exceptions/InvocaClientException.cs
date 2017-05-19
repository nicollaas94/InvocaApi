using System;
using System.Runtime.Serialization;

namespace Invoca.Core.Exceptions
{
    public class InvocaClientException : Exception
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
