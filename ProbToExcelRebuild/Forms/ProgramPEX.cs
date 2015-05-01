using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
            reg.RegisterSymbol("db", db);

            string textboxCompiler = CompilerBox.Text;

            Regex tokens = new Regex(@"[A-D,S,N][j,d,u,y][A-Z]?\d+");
            var mo = tokens.Replace(textboxCompiler, ReplaceTokens);

            var expression = new CompiledExpression(mo) { TypeRegistry = reg };

            var result = expression.Eval();

            DebugTextBox.Text = result.ToString();
        }

        private string ReplaceTokens(Match m)
        {
            var avgTypeChar = m.Value[0];
            var subGroupChar = m.Value[1];
            var targetNum = m.Value.Substring(2); // In case of deptID this will be a string not an int
            string ret;
            Averageable averageable;
            switch (subGroupChar)
            {
                case 'j':
                    {
                        var asNum = Convert.ToInt32(targetNum);
                        averageable = db.Job_Title.First(s => s.ID_JOB_TITLE == asNum);
                        break;
                    }
                case 'd':
                    averageable = db.Departments.First(s => s.ID_DEPARTMENT.Equals(targetNum));
                    break;
                case 'u':
                    {
                        var asNum = Convert.ToInt32(targetNum);
                        averageable = db.Universities.First(s => s.ID_UNIVERSITY == asNum);
                        break;
                    }
                case 'y':
                    ret =
                        db.New_Associate_Professor_Average_Salary
                        .Where(s => s.YEAR >= DateTime.Today.Year - Convert.ToInt32(targetNum))
                        .Average(s => s.AVERAGE_SALARY).ToString();
                    return ret; //If we hit this no further calculations are needed maybe?
                default: throw new Exception("The command you have entered is invalid at character (2) legal characters include 'j','d','u','y' See help menu for details");
            }
            switch (avgTypeChar)
            {
                case 'A':
                    ret = averageable.CalculateAverages().Mean.ToString();
                    break;
                case 'B':
                    ret = averageable.CalculateAverages().IQR1.ToString();
                    break;
                case 'C':
                    ret = averageable.CalculateAverages().Median.ToString();
                    break;
                case 'D':
                    ret = averageable.CalculateAverages().IQR3.ToString();
                    break;
                case 'S':
                    ret = averageable.Employees.Sum(s => s.TOTAL_SALARY).ToString();
                    break;
                case 'N':
                    ret = averageable.Employees.Count.ToString();
                    break;
                default: throw new Exception("The command you have entered is invalid at character (1) legal characters include 'A','B','C','D','S','N' See help menu for details");
            }

            return ret;
        }

        private void compileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
