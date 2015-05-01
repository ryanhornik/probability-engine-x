using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpressionEvaluator;
using ProbToExcelRebuild.Models;

namespace ProbToExcelRebuild.Forms
{
    public partial class ProgramPEX : Form
    {
        //private ExpressionCompiler x = new CompiledExpression();
        private UniversityModel db = new UniversityModel();

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
            Regex tokens = new Regex(@"[A-D,S][j,d,u,y][A-Z]?\d+");
            var mo = tokens.Replace(textboxCompiler, ReplaceTokens);

            foreach (string s in compileme)
            {
                var p = new CompiledExpression(compileme.ToString()) {TypeRegistry = reg};
                if (p.Expression == null)
                {

                }
                else
                {
                    var x = p.Eval();
                    DebugTextBox.Text = x.ToString();
                }
                
            }
        }

        private string ReplaceTokens(Match m)
        {
            var avgTypeChar = m.Value[0];
            var subGroupChar = m.Value[1];
            var targetNum = m.Value.Substring(2); // In case of deptID this will be a string not an int
            string ret;
            switch (subGroupChar)
            {
                case 'j':
                    ret = "db.Job_Title.Find("+targetNum+").CalculateAverages()";
                    break;
                case 'd':
                    ret = "db.Departments.Find("+targetNum+").CalculateAverages()";
                    break;
                case 'u':
                    ret = "db.Universities.Find(" + targetNum + ").CalculateAverages()";
                    break;
                case 'y':
                    ret =
                        db.New_Associate_Professor_Average_Salary.Where(
                            s => s.YEAR >= DateTime.Today.Year - +"targetNum" + ");";
                    break;
                default: throw new Exception("The command you have entered is invalid at character (2) legal characters include 'j','d','u','y' See help menu for details");
            }


            return "";
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
