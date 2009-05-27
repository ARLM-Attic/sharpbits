using System.IO;
using System.Text;
using System.Windows.Forms;
using SharpBits.Base;

namespace SharpBits.WinClient
{
    public static class DragDropHandler
    {
        // Methods
        public static string[] DragDrop(DragEventArgs e)
        {
            if (e.Data.GetDataPresent("UniformResourceLocator"))
            {
                MemoryStream data = (MemoryStream)e.Data.GetData("UniformResourceLocator", true);
                StringBuilder builder = new StringBuilder();
                for (int i = data.ReadByte(); i != 0; i = data.ReadByte())
                {
                    builder.Append((char)i);
                }
                return new string[] { builder.ToString() };
            }
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                object[] objArray = e.Data.GetData(DataFormats.FileDrop) as object[];
                return (objArray as string[]);
            }
            return null;
        }

        public static JobType DragEnter(DragEventArgs e)
        {
            if (e.Data.GetDataPresent("UniformResourceLocator"))
            {
                e.Effect = DragDropEffects.Link;
                return JobType.Download;
            }
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
                return JobType.Upload;
            }
            e.Effect = DragDropEffects.None;
            return JobType.Unknown;
        }

        public static void DragEnter(DragEventArgs e, JobType jobType)
        {
            if (e.Data.GetDataPresent("UniformResourceLocator") && (jobType == JobType.Download))
            {
                e.Effect = DragDropEffects.Link;
            }
            else if (e.Data.GetDataPresent(DataFormats.FileDrop) && (jobType == JobType.Upload))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }


}
