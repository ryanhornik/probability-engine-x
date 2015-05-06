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

                "\nSupport Operators\n\n"+
                "These are the supported operators: +(plus)"+
                ", -(subtraction), /(divide), *(multiplication)\n"+
                ", )((parentheses), <=(less than or equal), >="+
                ", <(less than), >(greater than), ==(equals), ^"+
                "(power)",
                
                "\nWorking with your data\n\n"+
                "Saving Functions:\n"+
                "You can save any working function you want"+
                " after you have completed it by clicking on the Save"+
                " button. This will allow you to call these functions from the"+
                " drop down menu.\n\n"+
                "Using Stored Data:\n"+
                "You can use stored data such as University, Job Title, "+
                "etc, that is imported from the excel documents. They are found in the drop"+
                " down menus.\n\n"+
                "Adding Values to the console:\n"+
                "Click on the Add to function button to add a function to the console.\n\n",

                "Special Functions:\n\n"+
                "A: Finds the mean.\n"+
                "B: Finds the first quartile.\n"+
                "C: Finds the median.\n"+
                "D: Finds the third quartile.\n"+
                "S: Finds the summation of all total salarys.\n"+
                "N: Finds the amount of items selected.\n"+
                "AyX: Finds the average salary of a given title of X number of years back.\n"


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