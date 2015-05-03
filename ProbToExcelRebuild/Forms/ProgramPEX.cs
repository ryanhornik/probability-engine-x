using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpressionEvaluator;
using Microsoft.Office.Interop.Excel;
using ProbToExcelRebuild.Models;
 

namespace ProbToExcelRebuild.Forms
{
    
    public partial class ProgramPEX : Form
    {
        private UniversityModel db = new UniversityModel();

        public ProgramPEX()
        {
            InitializeComponent();
        }

        private void SetBox<k,v>(ComboBox cb, IDictionary<k,v> dict)
        {
            if(dict.Count == 0)
                return;
            var jt = new SortedDictionary<k,v>(dict);
            cb.DataSource = new BindingSource(jt, null);
            cb.DisplayMember = "Key";
            cb.ValueMember = "Value";
        }

        private string ToDouble(Match m)
        {
            return "((double)"+m.Value+")";
        }

        private string ReplacePowers(Match m)
        {
            var caret = m.Value.IndexOf('^');
            double before = Convert.ToDouble(m.Value.Substring(0,caret));
            double after = Convert.ToDouble(m.Value.Substring(caret+1));
            return Math.Pow(before, after).ToString();
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
                {
                    var asNum = Convert.ToInt32(targetNum);
                    ret = db.New_Associate_Professor_Average_Salary
                        .Where(s => s.YEAR >= DateTime.Today.Year - asNum)
                        .Average(s => s.AVERAGE_SALARY).ToString();
                    return ret; //If we hit this no further calculations are needed maybe?
                    }
                default: throw new Exception("The command you have entered is invalid at character (2) legal characters include 'A','B','C','D','S','N' See help menu for details");
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

        private void button1_Click(object sender, EventArgs e)
        {
            var textboxCompiler = CompilerBox.Text;
            if (textboxCompiler.Length == 0)
            {
                DebugTextBox.Text = "Please enter an expression";
                return;
            }

            var reg = new TypeRegistry();
            reg.RegisterSymbol("db",db);
            
            Regex tokens = new Regex(@"[A-D,S,N][j,d,u,y][A-Z]?\d+");
            var mo = tokens.Replace(textboxCompiler, ReplaceTokens);

            Regex powers = new Regex(@"\d+(\.\d+)? ?\^ ?\d+(\.\d+)?");
            mo = powers.Replace(mo, ReplacePowers);

            Regex doubles = new Regex(@"\d+(\.\d+)?");
            mo = doubles.Replace(mo, ToDouble);

            var expression = new CompiledExpression(mo) { TypeRegistry = reg };

            var result = expression.Eval();

            DebugTextBox.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ProgramPEX_Load_1(object sender, EventArgs e)
        {
            var cfDict = db.CustomFunctions.ToDictionary(s => s.NAME, s => s.FUNCTION);
            SetBox(CustomFunctionList, cfDict);
            var jtDict = db.Job_Title.ToDictionary(s => s.JOB_TITLE_NAME, s => "j" + s.ID_JOB_TITLE);
            SetBox(JobTitleList,jtDict);
            var uDict = db.Universities.ToDictionary(s => s.UNIVERSITY_NAME, s => "u" + s.ID_UNIVERSITY);
            SetBox(UniversityList, uDict);
            var dDict = db.Departments.ToDictionary(s => s.ID_DEPARTMENT, s => "d" + s.ID_DEPARTMENT);
            SetBox(DepartmentList, dDict);
            var specialFunctions = new Dictionary<string, string>()
            {
                {"Mean","A"},
                {"1st Quartile","B"},
                {"Median","C"},
                {"3rd Quartile","D"},
                {"Sum","S"},
                {"Count","N"}
            };
            SetBox(SpecialFunctionList, specialFunctions);
        }
    }
}
