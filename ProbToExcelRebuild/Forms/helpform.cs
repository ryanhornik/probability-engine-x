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
                "(power)\n",
                
                "\nWorking with your data\n\n"+
                "Saving Functions:\n"+
                "You can save any working function you want"+
                " after you have completed it by clicking on the Save"+
                " button. This will allow you to call these functions from the"+
                " drop down menu.\n\n"+
                "Using Stored Data Selectors:\n"+
                "You can use stored data such as University, Job Title, "+
                "etc, that is imported from the excel documents. They are found in the drop"+
                " down menus.\n\n"+
                "Example:\n" +
                "u1 will select for only data related to the university with ID 1\n" +
                "This will not work on it's own you must choose what to do with the data\n" +
                "See \"Special Functions\" for more information\n\n"+
                "Adding Values to the console:\n"+
                "Click on the Add to function button to add a function to the console.\n\n",

                "\nSpecial Functions:\n\n"+
                "A: Finds the mean.\n" +
                "\tMust be narrowed down by a selector see \"Working with your data\"\n"+
                "B: Finds the first quartile.\n"+
                "\tMust be narrowed down by a selector see \"Working with your data\"\n"+
                "C: Finds the median.\n"+
                "\tMust be narrowed down by a selector see \"Working with your data\"\n"+
                "D: Finds the third quartile.\n"+
                "\tMust be narrowed down by a selector see \"Working with your data\"\n"+
                "S: Finds the summation of all total salarys.\n"+
                "\tMust be narrowed down by a selector see \"Working with your data\"\n"+
                "N: Finds the amount of items selected.\n"+
                "\tMust be narrowed down by a selector see \"Working with your data\"\n"+
                "Y: Finds the average salaries for new associate professors for a given year or number of years back\n"+
                "Example:\n"+
                "Y2015 will return the average salary for all associate professors in the year 2015\n" +
                "You can narrow it down by department as well for example Y2015dH0107 will get the average salary for new associates in 2015 for department H0107",

                "\nAdvanced Examples:\n\n" +
                "You can chain many commands together to make very complex calculations\n\n" +
                "((Y2015dH0107 + 7000) * 1.03 ^ 2)/((CdH0107))"


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