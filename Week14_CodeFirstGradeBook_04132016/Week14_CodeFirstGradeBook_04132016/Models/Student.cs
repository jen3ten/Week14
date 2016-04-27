using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; /*this is needed for Data Annotations*/
using System.Linq;
using System.Web;

namespace Week14_CodeFirstGradeBook_04132016.Models
{
    public class Student    /*public class is needed*/
    {
        /*Fields*/
        /*fields are created behind the scene, these are not needed*/
        private string firstname;
        private string lastname;

        /*Properties*/
        [Key]
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}