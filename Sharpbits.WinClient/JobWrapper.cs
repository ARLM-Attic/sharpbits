using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpBits.Base;

namespace SharpBits.WinClient
{
    [Serializable]
public class JobWrapper
{
    // Fields
    private bool autoComplete;
    private bool deleteLocal;
    [NonSerialized]
    private string[] fileList;
    [NonSerialized]
    private BitsJob job;
    private Guid jobId;
    [NonSerialized]
    internal BitsManager manager;

    // Methods
    public JobWrapper()
    {
        this.autoComplete = true;
    }

    public JobWrapper(BitsManager manager, Guid jobId) : this()
    {
        this.manager = manager;
        this.jobId = jobId;
    }

    // Properties
    public bool AutoComplete
    {
        get
        {
            return this.autoComplete;
        }
        set
        {
            this.autoComplete = value;
        }
    }

    public BitsJob BitsJob
    {
        get
        {
            if (this.job == null)
            {
                this.job = this.manager.Jobs[this.jobId];
            }
            return this.job;
        }
    }

    public bool DeleteLocalFile
    {
        get
        {
            return this.deleteLocal;
        }
        set
        {
            this.deleteLocal = value;
        }
    }

    public string[] FileList
    {
        get
        {
            return this.fileList;
        }
        set
        {
            this.fileList = value;
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

    public BitsManager Manager
    {
        get
        {
            return this.manager;
        }
    }
}

 
}
