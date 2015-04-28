using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpressionEvaluator;

namespace ProbToExcelRebuild.Forms
{
    public partial class ProgramPEX : Form
    {
        private ExpressionCompiler x = new CompiledExpression();
        public ProgramPEX()
        {
            InitializeComponent();
        }

        private void ErrorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
