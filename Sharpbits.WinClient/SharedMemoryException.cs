using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace SharpBits.WinClient
{
    [Serializable]
    public class SharedMemoryException : Exception
    {
        // Methods
        public SharedMemoryException()
        {
        }

        public SharedMemoryException(string message)
            : base(message)
        {
        }

        public SharedMemoryException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected SharedMemoryException(SerializationInfo info, StreamingContext context)
            : base( info, context )
        {
        }
    }

}
