using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Week14_CodeFirstGradeBook_04132016
{
    public class Assignments
    {
        [Key]
        public int AssignmentID { get; set; }
        public string Title { get; set; }
        public int PointsAvailable { get; set; }
    }
}