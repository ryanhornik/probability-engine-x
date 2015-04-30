using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpressionEvaluator;

namespace ProbToExcelRebuild.Forms
{
    public partial class ProgramPEX : Form
    {
        //private ExpressionCompiler x = new CompiledExpression();
        public ProgramPEX()
        {
            InitializeComponent();
        }

        private void ErrorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProgramPEX_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reg = new TypeRegistry();
            reg = LoadPreDefinedReg();
            char[] delimitior = {';', '\n'};
            string textboxCompiler = CompilerBox.Text.ToString();
            string[] compileme = textboxCompiler.Split(delimitior);
            //string[] textToCompile = Text.Split(delimitior);

            foreach (string s in compileme)
            {
                var p = new CompiledExpression(compileme.ToString()) {TypeRegistry = reg};
                if (p.Expression.Equals(null))
                {

                }
                else
                {
                    var x = p.Eval();
                    DebugTextBox.Text = x.ToString();
                }
                
            }
        }

        private TypeRegistry LoadPreDefinedReg()
        {
            var reg = new TypeRegistry();
            reg.RegisterType("a##", typeof(double));
            reg.RegisterType("b##", typeof(double));
            reg.RegisterType("c##", typeof(double));
            reg.RegisterType("d##", typeof(double));
            reg.RegisterType("e##", typeof(double));
            reg.RegisterType("f##", typeof(double));
            reg.RegisterType("g##", typeof(double));


            return reg;
        }

        private void compileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
