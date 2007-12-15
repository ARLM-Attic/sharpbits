using System;
using System.Collections.Generic;
using System.Text;

namespace SharpBits.Base
{
    public class ProxySettings
    {
        private BG_JOB_PROXY_USAGE proxyUsage;
        private string proxyList;
        private string proxyBypassList;
        private IBackgroundCopyJob job;

        internal ProxySettings(IBackgroundCopyJob job)
        {
            this.job = job;
            job.GetProxySettings(out proxyUsage, out proxyList, out proxyBypassList);
        }

        public ProxyUsage ProxyUsage
        {
            get { return (ProxyUsage)this.proxyUsage; }
            set { this.proxyUsage = (BG_JOB_PROXY_USAGE)value; }
        }

        public string ProxyList
        {
            get { return this.proxyList;  }
            set { this.proxyList = value; }
        }

        public string ProxyBypassList
        {
            get { return this.proxyBypassList; }
            set { this.proxyBypassList = value; }
        }

        public void Update()
        {
            this.job.SetProxySettings(this.proxyUsage, this.proxyList, this.proxyBypassList);
        }
    }
}
