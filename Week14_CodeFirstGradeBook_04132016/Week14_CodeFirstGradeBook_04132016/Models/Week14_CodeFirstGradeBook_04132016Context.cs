using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Week14_CodeFirstGradeBook_04132016.Models
{
    public class Week14_CodeFirstGradeBook_04132016Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Week14_CodeFirstGradeBook_04132016Context() : base("name=Week14_CodeFirstGradeBook_04132016Context")
        {
        }

        public System.Data.Entity.DbSet<Week14_CodeFirstGradeBook_04132016.Models.Student> Students { get; set; }

        public System.Data.Entity.DbSet<Week14_CodeFirstGradeBook_04132016.Assignments> Assignments { get; set; }

        public System.Data.Entity.DbSet<Week14_CodeFirstGradeBook_04132016.Models.StudentAssignmentGrades> StudentAssignmentGrades { get; set; }
    }
}
