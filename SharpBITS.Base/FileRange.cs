using System;
using System.Collections.Generic;
using System.Text;

namespace SharpBits.Base
{
    public class FileRange
    {
        private BG_FILE_RANGE fileRange;

        internal FileRange(BG_FILE_RANGE fileRange)
        {
            this.fileRange = fileRange;
        }

        public FileRange(ulong initialOffset, ulong length)
        {
            this.fileRange = new BG_FILE_RANGE();
            this.fileRange.InitialOffset = initialOffset;
            this.fileRange.Length = length;
        }

        public ulong InitialOffset
        {
            get { return this.fileRange.InitialOffset; }
        }

        public ulong Length 
        {
            get { return this.fileRange.Length; }
        }

        internal BG_FILE_RANGE _BG_FILE_RANGE
        {
            get { return this.fileRange; }
        }
    }
}
