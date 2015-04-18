using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProbabilityToExcel;
using ProbabilityToExcel.Models;

namespace ProbabilityToExcel
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {

            using (var db = new UniversityContext())
            {
                db.Universities.Add(new University()
                {
                    UniversityName = "University of Houston"
                });
                db.SaveChanges();

                db.JobTitles.Add(new JobTitle()
                {
                    JobTitleName = "Professor"
                });
                db.SaveChanges();

                db.Departments.Add(new Department()
                {
                    DepartmentId = "H0081",
                    DepartmentName = "HRM Faculty"
                });
                db.SaveChanges();

                db.Employees.Add(new Employee()
                {
                    UniversityId = 1,
                    DepartmentId = "H0081",
                    JobTitleId = 1
                });
                db.SaveChanges();


                db.DemographicData.Add(new DemographicData()
                {
                    EmployeeId = 1
                });
                db.SaveChanges();

                db.Salaries.Add(new Salary()
                {
                    EmployeeId = 1,
                    SalaryAmmount = 40000
                });
                db.SaveChanges();
            }




            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }


}
