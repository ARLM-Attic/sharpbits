using System;

using SharpBits.Base;

namespace SharpBits.WinClient
{
    [Serializable]
    public class CredentialsCacheItem : IComparable<CredentialsCacheItem>
    {
        // Fields
        private AuthenticationScheme authenticationScheme;
        private AuthenticationTarget authenticationTarget;
        private Guid jobId;
        private string userName;

        // Methods
        public CredentialsCacheItem()
        {
        }

        public CredentialsCacheItem(BitsCredentials credentials, Guid jobId)
        {
            this.userName = credentials.UserName;
            this.jobId = jobId;
            this.authenticationScheme = credentials.AuthenticationScheme;
            this.authenticationTarget = credentials.AuthenticationTarget;
        }

        public CredentialsCacheItem(AuthenticationScheme authenticationScheme, AuthenticationTarget authenticationTarget, string userName, Guid jobId)
        {
            this.userName = userName;
            this.jobId = jobId;
            this.authenticationScheme = authenticationScheme;
            this.authenticationTarget = authenticationTarget;
        }

        public int CompareTo(CredentialsCacheItem other)
        {
            if (((this.JobId == other.JobId) && (this.AuthenticationScheme == other.AuthenticationScheme)) && (this.AuthenticationTarget == other.AuthenticationTarget))
            {
                return 0;
            }
            if ((this.AuthenticationTarget != other.AuthenticationTarget) && (this.AuthenticationScheme != other.AuthenticationScheme))
            {
                return -1;
            }
            return 1;
        }

        public override bool Equals(object obj)
        {
            CredentialsCacheItem item = obj as CredentialsCacheItem;
            return (((item != null) && (item.JobId == this.JobId)) && ((item.AuthenticationScheme == this.AuthenticationScheme) && (item.AuthenticationTarget == this.AuthenticationTarget)));
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        // Properties
        public AuthenticationScheme AuthenticationScheme
        {
            get
            {
                return this.authenticationScheme;
            }
            set
            {
                this.authenticationScheme = value;
            }
        }

        public AuthenticationTarget AuthenticationTarget
        {
            get
            {
                return this.authenticationTarget;
            }
            set
            {
                this.authenticationTarget = value;
            }
        }

        public BitsCredentials BitsCredentials
        {
            get
            {
                BitsCredentials credentials = new BitsCredentials();
                credentials.AuthenticationScheme = this.authenticationScheme;
                credentials.AuthenticationTarget = this.authenticationTarget;
                credentials.UserName = this.userName;
                return credentials;
            }
        }

        public Guid JobId
        {
            get
            {
                return this.jobId;
            }
            set
            {
                this.jobId = value;
            }
        }

        public string UserName
        {
            get
            {
                return this.userName;
            }
            set
            {
                this.userName = value;
            }
        }
    }
}
