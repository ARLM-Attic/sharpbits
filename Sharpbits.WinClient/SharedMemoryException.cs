using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpBits.WinClient
{
    [Serializable]
    public class SharedMemoryException : ApplicationException
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
    }

}
