using System.Windows.Forms;

namespace SharpBits.WinClient.Controls
{
    public partial class JobControl : UserControl
    {
        // Fields
        protected bool initialized;
        protected JobWrapper wrapper;

        // Methods
        public JobControl()
        {
            this.InitializeComponent();
        }

        public virtual void DeInitControl()
        {
            this.initialized = false;
        }

        public virtual void InitControl(JobWrapper wrapper)
        {
            this.CreateHandle();
            this.wrapper = wrapper;
            if ((this.wrapper.BitsJob != null) && (this.wrapper.Manager != null))
            {
                this.UpdateControl();
            }
            this.initialized = true;
        }

        public virtual void UpdateControl()
        {
        }
    }


}
