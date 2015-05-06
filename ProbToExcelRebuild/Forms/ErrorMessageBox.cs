using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbToExcelRebuild.Forms
{
    public partial class ErrorMessageBox : Form
    {
        private string additionalInfo;
        private Exception exception;

        public ErrorMessageBox(Exception ex, string additionalInfo)
        {
            InitializeComponent();
            exception = ex;
            this.additionalInfo = additionalInfo;
        }

        private void ErrorMessageBox_Load(object sender, EventArgs e)
        {
            InformationLabel.Text = "\n"+additionalInfo + "\nIf the issue persists please copy and paste the text below into a e-mail to"+
                                                 "[redacted] along with a description of what you were doing when it occured";
            ExceptionInfo.Text = "Exception Message:" + FullExceptionMessage(exception) + "\nStack Trace:\n"+ exception.StackTrace + 
                "\n\nOccured at " + DateTime.UtcNow.ToString("O") + " UTC" + "\n\nWith OS version " + Environment.OSVersion.VersionString;
        }

        private string FullExceptionMessage(Exception ex)
        {
            var ret = "";
            while (ex != null)
            {
                ret += ex.Message + "\n\n";
                ex = ex.InnerException;
            }
            return ret;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
