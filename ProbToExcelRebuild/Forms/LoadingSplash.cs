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
    public partial class LoadingSplash : Form
    {
        public int numOfRows{get;set;}

        public LoadingSplash()
        {
            InitializeComponent();

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int returnint = 0;
            for (int i = 0; i <= 100; i++)
            {
                returnint = ((i * 100) / numOfRows);
                backgroundWorker1.ReportProgress(returnint);
            }
        }

        public void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        public class NewProgressBar : ProgressBar
        {
            public void SetValue(int value)
            {
                SetValue(value, null);
            }

            private readonly Font BarFont = new Font("Arial", (float) 8.25, FontStyle.Regular);

            public void SetValue(int value, string message)
            {
                var text = message ?? value+"%";
                Value = Math.Min(value,100);
                CreateGraphics().DrawString(
                    text,
                    BarFont,
                    Brushes.Black, 
                    new PointF(Width / 2 - 10, Height / 2 - 7));
            }

            public NewProgressBar()
            {
                SetStyle(ControlStyles.UserPaint, true);
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                Rectangle rec = e.ClipRectangle;

                rec.Width = (int)(rec.Width * ((double)Value / Maximum)) - 4;
                if (ProgressBarRenderer.IsSupported)
                    ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);
                rec.Height = rec.Height - 4;
                
                e.Graphics.FillRectangle(Brushes.Aqua, 2, 2, rec.Width, rec.Height);
                
            }
        }

       
    }
}
