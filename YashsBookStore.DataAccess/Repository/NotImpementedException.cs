using System;
using System.Runtime.Serialization;

namespace YashsBookStore.DataAccess.Repository
{
    [Serializable]
    internal class NotImpementedException : Exception
    {
        public NotImpementedException()
        {
        }

        public NotImpementedException(string message) : base(message)
        {
        }

        public NotImpementedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotImpementedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}