using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SharpBits.Base;

namespace SharpBits.WinClient
{
    public delegate void CredentialsUpdated(object sender, BitsCredentials credentials);
    public delegate void DragDropCallback(JobType jobType, string[] files);

    internal delegate void JobMessageCallback(string message);
    internal delegate void JobMessageLevelCallback(string message, MessageLevel level);

}
