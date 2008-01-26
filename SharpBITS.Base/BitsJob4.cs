using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;

namespace SharpBits.Base
{
    public partial class BitsJob : IDisposable
    {
        private IBackgroundCopyJob4 job4;

        #region public properties

        #region IBackgroundCopyJob4
        public ulong MaximumDownloadTime
        {
            get
            {
                ulong maxTime = 0;
                try
                {
                    if (this.job4 != null)// only supported from IBackgroundCopyJob4 and above
                    {
                        this.job4.GetMaximumDownloadTime(out maxTime);
                    }
                    else
                    {
                        throw new NotSupportedException("IBackgroundCopyJob4");
                    }
                }
                catch (COMException exception)
                {
                    manager.PublishException(this, exception);
                }
                return maxTime;
            }
            set
            {
                try
                {
                    if (this.job4 != null)// only supported from IBackgroundCopyJob4 and above
                    {
                        this.job4.SetMaximumDownloadTime(value);
                    }
                    else
                    {
                        throw new NotSupportedException("IBackgroundCopyJob4");
                    }
                }
                catch (COMException exception)
                {
                    manager.PublishException(this, exception);
                }
            }
        }

        public PeerCachingFlags PeerCachingFlags
        {
            get
            {
                PEER_CACHING_FLAGS peerCaching = 0;
                try
                {
                    if (this.job4 != null)// only supported from IBackgroundCopyJob4 and above
                    {
                        this.job4.GetPeerCachingFlags(out peerCaching);
                    }
                    else
                    {
                        throw new NotSupportedException("IBackgroundCopyJob4");
                    }
                }
                catch (COMException exception)
                {
                    manager.PublishException(this, exception);
                }
                return (PeerCachingFlags)peerCaching;
            }
            set
            {
                try
                {
                    if (this.job4 != null)// only supported from IBackgroundCopyJob4 and above
                    {
                        this.job4.SetPeerCachingFlags((PEER_CACHING_FLAGS)value);
                    }
                    else
                    {
                        throw new NotSupportedException("IBackgroundCopyJob4");
                    }
                }
                catch (COMException exception)
                {
                    manager.PublishException(this, exception);
                }
            }
        }

        public ulong OwnerIntegrityLevel
        {
            get
            {
                ulong integrityLevel = 0;
                try
                {
                    if (this.job4 != null)// only supported from IBackgroundCopyJob4 and above
                    {
                        this.job4.GetOwnerIntegrityLevel(out integrityLevel);
                    }
                    else
                    {
                        throw new NotSupportedException("IBackgroundCopyJob4");
                    }
                }
                catch (COMException exception)
                {
                    manager.PublishException(this, exception);
                }
                return integrityLevel;
            }
        }

        public bool OwnerElevationState
        {
            get
            {
                bool elevated = false;
                try
                {
                    if (this.job4 != null)// only supported from IBackgroundCopyJob4 and above
                    {
                        this.job4.GetOwnerElevationState(out elevated);
                    }
                    else
                    {
                        throw new NotSupportedException("IBackgroundCopyJob4");
                    }
                }
                catch (COMException exception)
                {
                    manager.PublishException(this, exception);
                }
                return elevated;
            }
        }
        #endregion

        #endregion
    }
}
