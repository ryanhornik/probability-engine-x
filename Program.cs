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

            using (var db = new UniversityEntities())
            {
                db.Universities.Add(new University()
                {
                    UNIVERSITY_NAME = "University of Houston"
                });
                db.SaveChanges();
            }




            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }


}
