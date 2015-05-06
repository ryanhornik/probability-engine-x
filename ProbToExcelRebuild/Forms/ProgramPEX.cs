using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ExpressionEvaluator;
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

        private void SetBox<k, v>(ComboBox cb, IDictionary<k, v> dict)
        {
            if (dict.Count == 0)
                return;
            var jt = new SortedDictionary<k, v>(dict);
            cb.DataSource = new BindingSource(jt, null);
            cb.DisplayMember = "Key";
            cb.ValueMember = "Value";
        }

        private string ToDouble(Match m)
        {
            return "((double)" + m.Value + ")";
        }

        private string ReplacePowers(Match m)
        {
            var caret = m.Value.IndexOf('^');
            double before = Convert.ToDouble(m.Value.Substring(0, caret));
            double after = Convert.ToDouble(m.Value.Substring(caret + 1));
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
            processFunction();//This way regardless of how we exit we can do a couple things

            if (currentResultAmmount > RESULT_LIMIT)
            {
                IEnumerable<string> lines = DebugTextBox.Text.Split('\n');
                lines = lines.Skip(RESULTS_TO_DELETE_ON_LIMIT);
                var newText = lines.Aggregate("", (current, l) => current + (l + "\n"));
                DebugTextBox.Text = newText.Remove(newText.Length - 1);
                currentResultAmmount -= RESULTS_TO_DELETE_ON_LIMIT;
                DebugTextBox.ScrollToCaret();
            }

            CompilerBox.Focus();
        }

        private void processFunction()
        {
            var textboxCompiler = CompilerBox.Text;
            if (textboxCompiler.Length == 0)
            {
                DebugTextBox.Text = "Please enter an expression";
                return;
            }

            var reg = new TypeRegistry();
            reg.RegisterSymbol("db", db);

            Regex years = new Regex(@"Y\d{1,4}(d[A-Z]\d*)?");
            Regex tokens = new Regex(@"[A-D,S,N][j,d,u,y][A-Z]?\d+");
            textboxCompiler = years.Replace(textboxCompiler, ProcessYears);
            textboxCompiler = tokens.Replace(textboxCompiler, ReplaceTokens); // These do not depend on parenthesis

            Regex powers = new Regex(@"\d+(\.\d+)? ?\^ ?\d+(\.\d+)?");
            Regex doubles = new Regex(@"\d+(\.\d+)?");

            Stack<int> openingBraces = new Stack<int>();
            try
            {
                for (int i = 0; i < textboxCompiler.Length; i++)
                {
                    if (textboxCompiler[i] == '(')
                    {
                        openingBraces.Push(i);
                    }
                    else if (textboxCompiler[i] == ')')
                    {
                        var popped = openingBraces.Pop();
                        var mo = powers.Replace(textboxCompiler.Substring(popped, i - popped + 1), ReplacePowers);//Include parenthesis
                        mo = doubles.Replace(mo, ToDouble);
                        var expression = new CompiledExpression(mo) { TypeRegistry = reg };
                        var result = expression.Eval();
                        textboxCompiler = textboxCompiler.Remove(popped, i - popped + 1).Insert(popped,result.ToString());
                        i = popped + result.ToString().Length-1;
                    }

                }
                DebugTextBox.AppendText(textboxCompiler + "\n");
                currentResultAmmount++;
            }
            catch (Exception ex)
            {
                new ErrorMessageBox(ex, "Function parsing failed").ShowDialog();
            }


        }

        private string ProcessYears(Match m)
        {
            var yearLength = m.Value.IndexOf('d') - 1; // Y2015dH10020 make year length 4 from ([5] - 1)
            var ret = "";
            if (yearLength == -2) // Department is not listed
            {
                yearLength = m.Value.Length - 1;
                var asNum = Convert.ToInt32(m.Value.Substring(1, yearLength));
                if (yearLength == 4)
                {
                    ret = db.New_Associate_Professor_Average_Salary
                        .Where(s => s.YEAR == asNum)
                        .Average(s => s.AVERAGE_SALARY).ToString();
                }
                else
                {
                    ret = db.New_Associate_Professor_Average_Salary
                        .Where(s => s.YEAR >= DateTime.Today.Year - asNum)
                        .Average(s => s.AVERAGE_SALARY).ToString();
                }
            }
            else // Department is listed
            {
                var deptId = m.Value.Substring(yearLength + 2);
                var asNum = Convert.ToInt32(m.Value.Substring(1, yearLength));
                if (yearLength == 4)
                {
                    ret = db.New_Associate_Professor_Average_Salary
                        .First(s => s.YEAR == asNum &&
                                    s.ID_DEPARTMENT.Equals(deptId))
                                    .AVERAGE_SALARY.ToString(); // There should be only one result for this
                }
                else
                {
                    ret = db.New_Associate_Professor_Average_Salary
                        .Where(s => s.YEAR >= DateTime.Today.Year - asNum)
                        .Where(s => s.ID_DEPARTMENT.Equals(deptId))
                        .Average(s => s.AVERAGE_SALARY).ToString();
                }
            }
            return ret;
        }

        private const int RESULT_LIMIT = 200;
        private const int RESULTS_TO_DELETE_ON_LIMIT = 50;
        private int currentResultAmmount = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProgramPEX_Load_1(object sender, EventArgs e)
        {
            var cfDict = db.CustomFunctions.ToDictionary(s => s.NAME, s => s.FUNCTION);
            SetBox(CustomFunctionList, cfDict);
            var jtDict = db.Job_Title.ToDictionary(s => s.JOB_TITLE_NAME, s => "j" + s.ID_JOB_TITLE);
            SetBox(JobTitleList, jtDict);
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
            CompilerBox.Focus();
        }

        private void AddCustom_Click(object sender, EventArgs e)
        {
            AddText(CustomFunctionList);
        }

        private void AddText(ComboBox cb)
        {
            if (cb.SelectedItem == null)
            {
                SystemSounds.Asterisk.Play();
                return;
            }
            var insertText = cb.SelectedValue.ToString();
            var newSelectIndex = CompilerBox.SelectionStart + insertText.Length;
            CompilerBox.Text = CompilerBox.Text.Insert(CompilerBox.SelectionStart, insertText);
            CompilerBox.SelectionStart = newSelectIndex;
            CompilerBox.Focus();
        }

        private void AddSpecial_Click(object sender, EventArgs e)
        {

            AddText(SpecialFunctionList);
        }

        private void AddTitle_Click(object sender, EventArgs e)
        {
            AddText(JobTitleList);
        }

        private void AddDepartment_Click(object sender, EventArgs e)
        {
            AddText(DepartmentList);
        }

        private void AddUniversity_Click(object sender, EventArgs e)
        {
            AddText(UniversityList);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (CompilerBox.Text.Length == 0)
            {
                SystemSounds.Asterisk.Play();
                return;
            }
            var funcName = FunctionName();
            if (funcName == null)
            {
                return;
            }
            try
            {
                var cf = new CustomFunction()
            {
                NAME = funcName,
                FUNCTION = CompilerBox.Text
            };
                db.CustomFunctions.Add(cf);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                new ErrorMessageBox(ex, "Failed to save the function - the name may already be taken").ShowDialog();
            }


            var dict = db.CustomFunctions.ToDictionary(s => s.NAME, s => s.FUNCTION);
            SetBox(CustomFunctionList, dict);
        }

        public static string FunctionName()
        {
            var textLabel = new Label() { Left = 25, Top = 20, Text = "Function Name" };
            var textBox = new TextBox() { Left = 25, Top = 50, Width = 175 };
            var confirmation = new Button() { Text = "Ok", Left = 25, Width = 75, Top = 80 };
            var cancel = new Button() { Text = "Cancel", Left = 130, Width = 75, Top = 80 };
            var prompt = new Form
            {
                Width = 250,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "New Function",
                StartPosition = FormStartPosition.WindowsDefaultLocation,
                AcceptButton = confirmation,
                CancelButton = cancel,
                ControlBox = false,
                MaximumSize = new Size(250, 150),
                MinimumSize = new Size(250, 150)
            };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancel);
            prompt.Controls.Add(textLabel);
            confirmation.Click += (sender, e) => { prompt.DialogResult = DialogResult.OK; prompt.Close(); };
            cancel.Click += (sender, e) => { prompt.DialogResult = DialogResult.Cancel; prompt.Close(); };

            var result = prompt.ShowDialog();
            return result == DialogResult.OK ? textBox.Text : null;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var form = new HelpForm();
            form.ShowDialog();
        }
    }
}
