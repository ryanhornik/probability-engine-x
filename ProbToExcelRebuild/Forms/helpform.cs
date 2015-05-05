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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            helpText = new []
            {
                "\nPlease choose a help topic on the " +
                "left to begin",

                "\nEntering A New Function\n\n" +
                "You can create a new function by " +
                "typing in the text box on the lower " +
                "left side of the form.\n\nWhen you are " +
                "ready to execute your new function you " +
                "can press run and the function will run.\n\n" +
                "After running you will see your output " +
                "in the text area at the top left.",

                "",
                
                "",

                ""//TODO finish help text
            };
            InitializeComponent();
        }

        private readonly string[] helpText;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = helpText[listBox1.SelectedIndex];
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 0;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}