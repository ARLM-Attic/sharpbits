using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading;
using SharpBits.Base;

namespace SharpBitsConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            BitsManager manager = new BitsManager();

            System.Console.WriteLine("Bits Version is {0}", BitsManager.BitsVersion);

            if (BitsManager.BitsVersion >= BitsVersion.Bits2_0)
            {
                //BitsJob newJob = manager.CreateJob("TestJob2", JobType.Download);
                //Collection<FileRange> fileRanges = new Collection<FileRange>();
                //fileRanges.Add(new FileRange(0, 1000));
                //fileRanges.Add(new FileRange(2000, 1000));
                //fileRanges.Add(new FileRange(4000, 1000));
                //fileRanges.Add(new FileRange(6000, 1000));
                //fileRanges.Add(new FileRange(8000, 1000));
                //newJob.AddFileWithRanges("http://localhost/bits/en_windows_sharepoint_services_3.0.exe", "C:\\temp\\download.file", fileRanges);
            }
            else
            {
//            BitsJob newJob = manager.CreateJob("TestJob", JobType.Upload);
//            newJob.AddFile("http://localhost/bits/UploadReply.file", "C:\\temp\\download.file");
//            string program = @"C:\Program Files\TextPad 5\TextPad.exe";
            //newJob.NotifyCommandLineProgram = program;
            //newJob.NotifyCommandLineParameters = "C:\\Temp\\New Text Document.cs";
            //newJob.NotificationFlags = NotificationFlags.JobTransferred | NotificationFlags.JobErrorOccured;
            }

            manager.EnumJobs(JobOwner.CurrentUser);
            System.Console.WriteLine("Job Count for current user: {0}", manager.Jobs.Count.ToString());
            foreach (BitsJob job in manager.Jobs.Values)
            {
                System.Console.WriteLine("Displayname for job: {0}", job.DisplayName);
                System.Console.WriteLine("Description: {0}", job.Description);
                System.Console.WriteLine("Owner: {0}", job.Owner);
                System.Console.WriteLine("Owner Name: {0}", job.OwnerName);
                System.Console.WriteLine("Priority: {0}", job.Priority.ToString());
                job.EnumFiles();
                System.Console.WriteLine("File Count for current job: {0}", job.Files.Count.ToString());
                foreach (BitsFile file in job.Files)
                {
                    System.Console.WriteLine("File Name: {0}", file.LocalName);
                    System.Console.WriteLine("Remote File Name: {0}", file.RemoteName);
                    System.Console.WriteLine("Bytes total: {0}", file.Progress.BytesTotal.ToString());
                    System.Console.WriteLine("Bytes transfered: {0}", file.Progress.BytesTransferred.ToString());
                    System.Console.WriteLine("File Completed: {0}", file.Progress.Completed.ToString());

                    if (BitsManager.BitsVersion >= BitsVersion.Bits2_0)
                    {
                        System.Console.WriteLine("File Ranges for current job: {0}", file.FileRanges.Count.ToString());
                        foreach (FileRange range in file.FileRanges)
                        {
                            System.Console.WriteLine("File Range Offset: {0}", range.InitialOffset);
                            System.Console.WriteLine("File Range Length: {0}", range.Length);
                        }
                    }
                }
                System.Console.WriteLine("Job Id: {0}", job.JobId.ToString());
                System.Console.WriteLine("Job State: {0}", job.State.ToString());
                System.Console.WriteLine("Job CreationTime: {0}", job.JobTimes.CreationTime.ToString());
                System.Console.WriteLine("Job ModificationTime: {0}", job.JobTimes.ModificationTime.ToString());
                System.Console.WriteLine("Job TransferCompletionTime: {0}", job.JobTimes.TransferCompletionTime.ToString());
                System.Console.WriteLine("Job Type: {0}", job.JobType.ToString());
                job.ProxySettings.ProxyUsage = ProxyUsage.AutoDetect; 
                System.Console.WriteLine("Proxy Usage: {0}", job.ProxySettings.ProxyUsage.ToString());
                System.Console.WriteLine("Proxy List: {0}", job.ProxySettings.ProxyList);
                System.Console.WriteLine("Proxy Bypass List: {0}", job.ProxySettings.ProxyBypassList);
                System.Console.WriteLine("Error Count for current job: {0}", job.ErrorCount.ToString());
                BitsError error = job.Error;
                if (null != error)
                {
                    System.Console.WriteLine("Error Code: {0}", error.ErrorCode.ToString());
                    System.Console.WriteLine("Error Description: {0}", error.Description);
                    System.Console.WriteLine("Error Context: {0}", error.ErrorContext.ToString());
                    System.Console.WriteLine("Error Context Description: {0}", error.ContextDescription);
                    System.Console.WriteLine("Error Protocol: {0}", error.Protocol);
                }
                //job.NotificationFlags = NotificationFlags.JobTransferred | NotificationFlags.JobErrorOccured;
                System.Console.WriteLine("Notification Flags: {0}", job.NotificationFlags.ToString());

                System.Console.WriteLine("Notify CommandLine: {0}", job.NotifyCommandLineProgram);
                System.Console.WriteLine("CommandLine Parameters: {0}", job.NotifyCommandLineParameters);
//                System.Console.WriteLine("Reply File Name: {0}", job.ReplyFileName);

//                job.Resume();
//                System.Threading.Thread.Sleep(1000);
                //job.Suspend();
                
//                job.Complete();
                //job.Cancel();

            }

            System.Console.Write("Press any key to close");
            Console.ReadKey();
        }

    }
}
