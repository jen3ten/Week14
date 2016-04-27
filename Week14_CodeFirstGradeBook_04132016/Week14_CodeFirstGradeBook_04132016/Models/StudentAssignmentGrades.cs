using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Week14_CodeFirstGradeBook_04132016.Models
{
    public class StudentAssignmentGrades
    /* This class has a Composite Key. It joins Student and Assignment classes*/
    {
        [Key][Column(Order=1)] /*2 keys, so order must be designated*/
        public int StuID { get; set; } /*Connect to StudentID of Student class*/
        [ForeignKey("StuID")] /*This is the property of the current class...*/
        public Student StudentID { get; set; } /*it attaches to the StudentID property of the Student class*/

        [Key][Column(Order=2)]
        public int AssignID { get; set; } /*Connect to AssignmentID of Assignments class*/
        [ForeignKey("AssignID")] /*This is the property of the current class...*/
        public Assignments AssignmentID { get; set; } /*it attaches to the AssignmentID property of the Assignments class*/

        [Required]  /*This makes PointsAwarded property a required field*/
        public int PointsAwarded { get; set; }
        public string Grade { get; set; }
    }
}